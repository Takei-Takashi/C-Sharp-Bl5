using Slot_1;
using Slot_1.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		Function f = new Function();
		//f.MakeTeacher();
		//f.ShowT();
		//f.MakeStudent();
		//f.ShowS();
		string filePath = @"D:\Visual Studio Code\Bl5\Slot_1\StudentFile.txt";
		string[] lines = File.ReadAllLines(filePath);
		foreach (string line in lines)
		{
			try
			{
				string[] fields = line.Split(';');
				int id = int.Parse(fields[0]);
				string name = fields[1];
				DateTime dob = DateTime.Parse(fields[2]);
				string rollNumber = fields[3];
				string major = fields[4];
				int enrollYear = int.Parse(fields[5]);

				Student student = new Student(id, name, dob, rollNumber, major, enrollYear);
				Console.WriteLine(student.ToString());
			}
			catch (Exception)
			{

				continue;
			}
		}
	}
}