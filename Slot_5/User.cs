﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_5
{
	public class User
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public DateTime Dob { get; set; }
		public User() { }
		public User(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}
		public User(int id, string? name, DateTime dob) : this(id, name)
		{
			this.Dob = dob;
		}
		public override string ToString()
		{
			return $"Id = {Id}, Name = {Name}, Date of birth = {(string)Dob.ToString("dd/MM/yyyy")}";
		}
		public void Display()
		{
			Console.WriteLine(this);
		}
	}
}
