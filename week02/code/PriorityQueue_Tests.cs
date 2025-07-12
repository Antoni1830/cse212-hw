using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue 3 items with increasing priority: Task1 (1), Task2 (2), Task3 (3)
    // Expected Result: Dequeue should return Task3, as it has the highest priority.
    // Defect(s) Found: The original loop condition was incorrect: it iterated to Count - 1,
    // which skipped the last item in the queue. As a result, Task3 was never checked and Task2 was returned instead.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 2);
        priorityQueue.Enqueue("Task3", 3);

        var expectedResult = "Task3"; // Highest priority should be dequeued first

        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, dequeuedValue);
    }

    [TestMethod]
    // Scenario: Enqueue 4 items, with two items having the same highest priority (Task3 and Task4 with priority 3)
    // Expected Result: Dequeue should return the first of the tied highest priority items (Task3)
    // Defect(s) Found: The original comparison used '>=' instead of '>' which caused the loop
    // to always favor the last item with the same priority instead of preserving FIFO among equals.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 2);
        priorityQueue.Enqueue("Task3", 3);
        priorityQueue.Enqueue("Task4", 3);

        var expectedResult = "Task3"; // Highest priority should be dequeued first

        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, dequeuedValue);
    }

    [TestMethod]
    /// Scenario: Enqueue multiple items, where the highest-priority item is in the middle.
    /// Call Dequeue once, then inspect the next item returned.
    /// Expected Result: The highest-priority item is returned first, then the next-highest.
    /// This verifies that the first item was correctly removed from the queue.
    /// Defect(s) Found: Original implementation did not remove the dequeued item, so it could be returned again.
    public void TestPriorityQueue_ItemIsRemoved()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Task1", 1);
        queue.Enqueue("Task2", 10); 
        queue.Enqueue("Task3", 5);

        var firstExpectedResult = queue.Dequeue();  // Should return Task2
        var secondExpectedResult = queue.Dequeue(); // Should return Task3

        Assert.AreEqual("Task2", firstExpectedResult);
        Assert.AreEqual("Task3", secondExpectedResult);
    }

}