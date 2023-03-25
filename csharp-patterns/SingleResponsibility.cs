
namespace SiningleResponsibilityPattern{
    public class SingleResponsibilityPatternExample
    {
        public void Run()
        {
            InputReader inputReader = new InputReader();
            OutputWriter outputWriter = new OutputWriter();

            ICalculationMethod calculationMethod;

            outputWriter.Write("Enter int for number 1: ");
            int number1 = inputReader.ReadInt32();

            outputWriter.Write("Enter int for number 2: ");
            int number2 = inputReader.ReadInt32();

            outputWriter.Write("1 - Add");
            outputWriter.Write("2 - Subtract");
            outputWriter.Write("3 - Multiply");
            outputWriter.Write("4 - Divide");
            outputWriter.Write("Choose Operation: ");

            int choice = inputReader.ReadInt32();


            switch (choice)
            {
                case 1:
                    calculationMethod = new AddCalculation();
                    break;

                case 2:
                    calculationMethod = new SubtractCalculation();
                    break;

                case 3:
                    calculationMethod = new MultiplyCalculation();
                    break;

                case 4:
                    calculationMethod = new DivideCalculation();
                    break;

                default:
                    calculationMethod = new AddCalculation();
                    break;
            }

            Calculator calculator = new Calculator();
            int result = calculator.Calculate(number1, number2, calculationMethod);

            Console.WriteLine("result: {0}", result);
        }
    }

    public class InputReader
    {
        public int ReadInt32()
        {
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }

    public class OutputWriter
    {
        public void Write(string output)
        {
            Console.WriteLine(output);
        }
    }

    public class Calculator
    {
        public int Calculate(int number1, int number2, ICalculationMethod calculationMethod)
        {
            int result = calculationMethod.Calculate(number1, number2);

            return result;
        }
    }

    public interface ICalculationMethod
    {
        public int Calculate(int num1, int num2);
    }

    public class AddCalculation : ICalculationMethod
    {
        public int Calculate(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class SubtractCalculation : ICalculationMethod
    {
        public int Calculate(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    public class MultiplyCalculation : ICalculationMethod
    {
        public int Calculate(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    public class DivideCalculation : ICalculationMethod
    {
        public int Calculate(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}