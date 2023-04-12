using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_1.Models
{
	internal class Teacher : User
	{
		private string? Certificate { get; set; }
		private string? Des { get; set; }
		private float Salary { get; set; }
		public Teacher() { }
		public Teacher(int id, string? name, DateTime dob, string certificate, string des, float salary) : base(id, name, dob)
		{
			this.Certificate = certificate;
			this.Des = des;
			this.Salary = salary;
		}
		public override string ToString()
		{
			return $"Id = {Id}, Name = {Name}, Date of birth = {(string)Dob.ToString("dd/MM/yyyy")}, Certificate = {Certificate}, Description = {Des}, Salary = {Salary}";
		}
		public void Display()
		{
			Console.WriteLine(this);
		}
	}
}
