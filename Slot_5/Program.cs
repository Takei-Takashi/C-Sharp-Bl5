using Slot_5;
using System.Threading.Channels;

internal class Program
{
	private static void Main(string[] args)
	{
		List<User> users = new List<User>
		{
			new User(1, "hung", new DateTime(1999,1,1)),
			new User(7, "hoa", new DateTime(1995,1,1)),
			new User(2, "an", new DateTime(1999,1,1)),
			new User(7, "hoa", new DateTime(1997,1,12)),
			new User(12, "an", new DateTime(1998,1,12)),
		};
		users.Select(x => x.Dob.Year).ToList().ForEach(x => Console.WriteLine(x));
		Console.ReadLine();
		users.Select(x => x.Dob.Year).Distinct().OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

	}
}