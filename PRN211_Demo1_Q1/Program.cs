using PRN211_Demo1_Q1;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("TC1:");
            Book b1 = new Book("1", "", new DateTime(2018, 1, 1));
            Console.WriteLine(b1.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("\nTC2:");
        Book b2 = new Book(1 + "", "Refactoring: Improving the Design of Existing Code", new DateTime(2019, 1, 1));
        Console.WriteLine("Add Authors:");
        while (true)
        {
            try
            {
                Console.WriteLine("Enter author's name (empty to stop):");
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) break;
                b2.AddAuthor(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine(b2.ToString());
        Console.ReadLine();
    }

}