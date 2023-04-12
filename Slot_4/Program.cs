using Slot_4;

internal class Program
{
	static int Add(int a, int b)
	{
        Console.WriteLine("Add function.");
		return a + b;
    }
	static int Sub(int a, int b)
	{
		Console.WriteLine("Sub function");
		return a - b;
	}
	private static void Main(string[] args)
	{
		Caculator c;
		c = Add;
        Console.WriteLine(c(5,4));
		c = Sub;
        Console.WriteLine(c(5,4));
    }
}