namespace Calculator
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter operation (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                Calculator calc = new Calculator();
                int result = calc.Calculate(a, b, op);

                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" Error: Cannot divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine(" Error: Please enter valid numbers!");
            }
            finally
            {
                Console.WriteLine(" Calculation attempt complete.");
            }
        }
    }
}