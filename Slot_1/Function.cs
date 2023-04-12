using Microsoft.VisualBasic;
using Slot_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_1
{
	public class Function
	{
		User u = new User();
		Teacher t = new Teacher();
		Student s = new Student();
		public Function() { }
		public void MakeTeacher()
		{
			Console.WriteLine("Enter information: ");
			Console.Write("Enter id:");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter name:");
			string name = Console.ReadLine();
			if (name == "")
			{
				name = "null";
			}
			Console.Write("Enter date of birth:");
			DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
			Console.Write("Enter Certificate:");
			string cer = Console.ReadLine();
			if (cer == "")
			{
				cer = "null";
			}
			Console.Write("Enter description:");
			string des = Console.ReadLine();
			if (des == "")
			{
				des = "null";
			}
			Console.Write("Enter salary:");
			float salary = float.Parse(Console.ReadLine());
			t = new Teacher(id, name, dob, cer, des, salary);
		}
		public void ShowT()
		{
			t.Display();
		}
		public void MakeStudent()
		{
			Console.WriteLine("Enter information: ");
			Console.Write("Enter id:");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter name:");
			string name = Console.ReadLine();
			if (name == "")
			{
				name = "null";
			}
			Console.Write("Enter date of birth:");
			DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
			Console.Write("Enter Roll number:");
			string rn = Console.ReadLine();
			if (rn == "")
			{
				rn = "null";
			}
			Console.Write("Enter Major:");
			string mj = Console.ReadLine();
			if (mj == "")
			{
				mj = "null";
			}
			Console.Write("Enter Enroll Year:");
			int ey = Convert.ToInt32(Console.ReadLine());
			s = new Student(id, name, dob, rn, mj, ey);
		}

		public void ShowS()
		{
			s.Display();
		}
	}
}
