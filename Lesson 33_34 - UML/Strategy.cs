// Behavioral - Strategy: hesablama usulunu deyismek olur.
public interface IOperation
{
    int Execute(int a, int b);
}

public class AddStrategy : IOperation
{
    public int Execute(int a, int b) => a + b;
}

public class MultiplyStrategy : IOperation
{
    public int Execute(int a, int b) => a * b;
}

public class Calculator
{
    private IOperation operation;

    public Calculator(IOperation operation) => this.operation = operation;

    public void SetStrategy(IOperation operation) => this.operation = operation;

    public int Calculate(int a, int b) => operation.Execute(a, b);
}
