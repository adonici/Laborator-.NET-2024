namespace Lab2
{
    public class Printer
    {
        public void Print(int number)
        {
            Console.WriteLine(number);
        }

        public void Print(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        // Overloaded method for printing a double
        public void Print(double number)
        {
            Console.WriteLine(number);
        }

        // Overloaded method for printing a string
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        // Overloaded method for printing multiple integers
        public void Print(int number1, int number2, int number3)
        {
            Console.WriteLine(number1 + number2 + number3);
        }

        // Overloaded method for printing an array of integers
        public void Print(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }

        // Overloaded method with a different order of parameters
        public void Print(string prefix, int number)
        {
            Console.WriteLine($"{prefix}: {number}");
        }
    }
}
