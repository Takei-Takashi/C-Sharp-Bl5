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
	static void DemoUsingDelegate()
	{
		List<User> users = new List<User>
		{
			new User(1, "hung", new DateTime(1999,1,1)),
			new User(7, "hoa", new DateTime(1995,1,1)),
			new User(2, "an", new DateTime(1999,1,1)),
		};

	}
	private static void Main(string[] args)
	{
		//Caculator c;
		//c = Add;
  //      Console.WriteLine(c(5,4));
		//c = Sub;
  //      Console.WriteLine(c(5,4));

    }
}