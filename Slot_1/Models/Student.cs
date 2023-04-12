using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_1.Models
{
	internal class Student : User
	{
		private string? RollNumber;
		private string? Major;
		private int EnrollYear;
		public Student()
		{

		}
		public Student(int id, string name, DateTime dob, string? rollnumber, string? major, int enrollYear) : base(id, name, dob)
		{
			this.RollNumber = rollnumber;
			this.Major = major;
			this.EnrollYear = enrollYear;
		}
		public override string ToString()
		{
			return base.ToString() + $", Roll number = {RollNumber}, Major = {Major}, Enroll year = {EnrollYear}";
		}
		public void Display()
		{
            Console.WriteLine(this);
        }
	}
}
