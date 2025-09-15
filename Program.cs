namespace TimeComplexities
{
    internal class AsymptoticAnalysis
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            int linearCounter = Linear(numbers);
            System.Console.WriteLine();
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine();

            System.Console.WriteLine($"\nLinear Search took {linearCounter} iterations to complete.");

            int constantCounter = Constant(numbers);
            System.Console.WriteLine($"\nConstant Search took {constantCounter} iterations to complete.");

            int logarithmCounter = Logarithm(numbers);
            System.Console.WriteLine($"\nLogarithm Search took {logarithmCounter} iterations to complete.");

            int quadraticCounter = Quadratic(numbers);
            System.Console.WriteLine($"\nQuadratic Search took {quadraticCounter} iterations to complete.");
            System.Console.WriteLine();


        }

        // this function repersentes a linear time complexity O(n) by iterating through each element in the array once.
        public static int Linear(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write("," + array[i]);
                counter++;
            }
            return counter;
        }
        // this function repersentes a constant time complexity O(1) by performing a single operation regardless of the input size.
        public static int Constant(int[] array)
        {
            int counter = 0;
            int number = array[0]; // Accessing the first element
            counter++;
            return counter;
        }

        // this function repersentes a logarithmic time complexity O(log n) by dividing the input size in half each time through the loop.
        public static int Logarithm(int[] array)
        {
            int counter = 0;
            int length = array.Length;
            while (length > 1)
            {
                length = length / 2;
                counter++;
            }
            return counter;
        }
        // this function repersentes a quadratic time complexity O(n^2) by taking the outer loop which goes through n elements, inner loop goes through n elements → total ~ n × n steps
        public static int Quadratic(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    
}