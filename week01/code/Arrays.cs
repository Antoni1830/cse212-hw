

public static class Arrays
{
    // 1. Define the MultiplesOf function, which takes two parameters:
// - double number: the initial number from which the multiples will be generated.
// - int length: the number of multiples to generate.
// 2. Validate the input parameters:
// - Make sure 'length' is a positive number, since multiples cannot be generated if at least one is not requested.
// 3. Create a double array with a length equal to 'length'.
// - This array will store the generated multiples.
// 4. Use a for loop to fill the array:
// - On each iteration, calculate the corresponding multiple by multiplying 'number' by (i + 1).
// - Store the result in position i of the array.
// 5. Return the array containing the generated multiples
    public static double[] MultiplesOf(double number, int length)
    {

        if (length <= 0)
        {
            throw new ArgumentException("El length debe ser un número positivo mayor que 0.");
        }


        double[] multiples = new double[length];


        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1); // Calcular el múltiplo y almacenarlo
        }

        
        return multiples;
    }

        public static void RotateListRight(List<int> data, int amount)
    {
       // 1. Define the RotateListRight function, which takes two parameters:
// - List<int> data: The list of integers to rotate.
// - int amount: The number of positions to rotate right.
// 2. Validate the input parameters:
// - Ensure that the list 'data' is not null and has elements.
// - Ensure that 'amount' is in the range of 1 to data.Count, inclusive.
// 3. Calculate the list size:
// - Save the list size to a variable for use in later calculations.
// 4. Normalize the 'amount' value:
// - If 'amount' is greater than the list size, calculate the effective rotation value using 'amount % size'.
// - This ensures that unnecessary rotations are not performed.
// 5. Split the list into two parts:
// - The part that will move to the front (the last 'amount' elements).
// - The part that will stay in place (the first 'size - amount' elements).
// 6. Combine the two parts in the correct order:
// - Create a new list containing the part that will move to the front first, followed by the part that remains.
// 7. Assign the new list to 'data' to reflect the rotation.
        if (data == null || data.Count == 0)
        {
            throw new ArgumentException("La lista no puede ser nula o vacía.");
        }

        if (amount < 1 || amount > data.Count)
        {
            throw new ArgumentException("El valor de amount debe estar en el rango de 1 a data.Count.");
        }

        // 2. Calcular el tamaño de la lista
        int size = data.Count;

        // 3. Normalizar el valor de 'amount'
        amount = amount % size; // Esto maneja el caso donde amount es mayor que el tamaño de la lista

        // 4. Dividir la lista en dos partes y combinarlas
        List<int> rotatedList = new List<int>();
        rotatedList.AddRange(data.GetRange(size - amount, amount)); // Parte que se moverá al frente
        rotatedList.AddRange(data.GetRange(0, size - amount)); // Parte que permanece

        // 5. Asignar la nueva lista a 'data'
        data.Clear(); // Limpiar la lista original
        data.AddRange(rotatedList); // Agregar los elementos rotados
    }

    static void main( string[] args)
    {
        // Ejemplo de uso de la función MultiplesOf
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine("Múltiplos de 7:");
        Console.WriteLine(string.Join(", ", multiples)); // Salida: 7, 14, 21, 28, 35

        // Ejemplo de uso de la función RotateListRight
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(data, 3);
        Console.WriteLine("Lista rotada a la derecha por 3:");
        Console.WriteLine(string.Join(", ", data)); // Salida: 7, 8, 9, 1, 2, 3, 4, 5, 6

        // Otro ejemplo de rotación
        List<int> anotherData = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(anotherData, 5);
        Console.WriteLine("Lista rotada a la derecha por 5:");
        Console.WriteLine(string.Join(", ", anotherData)); // Salida: 5, 6, 7, 8, 9, 1, 2, 3, 4
    }
}
