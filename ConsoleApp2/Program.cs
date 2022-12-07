// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class EdenredFunctions
{
    IEdenredMaths _math;

    public EdenredFunctions(IEdenredMaths math)
    {
        _math = math;
    }

    public bool IsEven(int number)
    {
        if (number == 100)
        {
            return false;
        }

        return _math.Mod(number, 2) == 0;
    }
}

public interface IEdenredMaths
{
   double Mod(int first, int second);
}
















public class EdenredMaths : IEdenredMaths
{
    public double Mod(int first, int second)
    {
        return first % second;
    }
}