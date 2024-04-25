public class Calculator
{
    // Define a delegate that matches the signature of the arithmetic methods
    public delegate double ArithmeticOperation(double a, double b);

    // Define an event that is fired after an operation is performed
    public event Action<string, double> OperationPerformed;

    public double Add(double a, double b)
    {
        double result = a + b;
        OperationPerformed?.Invoke("Addition", result); // Fire event
        return result;
    }

    public double Subtract(double a, double b)
    {
        double result = a - b;
        OperationPerformed?.Invoke("Subtraction", result); // Fire event
        return result;
    }

    public double Multiply(double a, double b)
    {
        double result = a * b;
        OperationPerformed?.Invoke("Multiplication", result); // Fire event
        return result;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        double result = a / b;
        OperationPerformed?.Invoke("Division", result); // Fire event
        return result;
    }
}
