public enum Operators
{
    Add,
    Subtract,
    Multiply,
    Divide
}

public class Calculator
{
    public Operators? Operator { get; set; }
    public double? X { get; set; }
    public double? Y { get; set; }

    public string Op
    {
        get
        {
            return Operator switch
            {
                Operators.Add => "+",
                Operators.Subtract => "-",
                Operators.Multiply => "*",
                Operators.Divide => "/",
                _ => ""
            };
        }
    }

    public bool IsValid()
    {
        return Operator != null && X != null && Y != null;
    }

    public double Calculate()
    {
        return Operator switch
        {
            Operators.Add => (double)(X + Y),
            Operators.Subtract => (double)(X - Y),
            Operators.Multiply => (double)(X * Y),
            Operators.Divide => (double)(X / Y),
            _ => double.NaN
        };
    }
}
