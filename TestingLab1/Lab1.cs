namespace TestingLab1
{
    public class Lab1
    {
        public static void Main(string[] args)
        {
            double[] numbers = new double[3];

            Console.WriteLine("Enter three real numbers:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double[] squaredNumbers = SquareNonNegativeNumbers(numbers);

            Console.WriteLine("Squared numbers:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Number {0}: {1}", i + 1, squaredNumbers[i]);
            }
        }

        public static double[] SquareNonNegativeNumbers(double[] numbers)
        {
            double[] squaredNumbers = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    squaredNumbers[i] = numbers[i] * numbers[i];
                }
                else
                {
                    squaredNumbers[i] = numbers[i];
                }
            }

            return squaredNumbers;
        }
    
}
}