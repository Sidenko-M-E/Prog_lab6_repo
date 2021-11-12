﻿using System;

namespace Prog_lab6
{
    public class Human
    {
		//Attributes
		private int id;
		private int age;
		private int height;
		private double weight;
		private char gender;
		public Fio fioField = new Fio();

		//Methods
		public bool SetId(int buf)
		{
			if (buf < 0 || buf > 9999)
				return (true);
			else
			{
				id = buf;
				return (false);
			}
		}

		public bool SetAge(int buf)
		{
			if (buf < 0 || buf > 200)
				return (true);
			else
			{
				age = buf;
				return (false);
			}
		}

		public bool SetHeight(int buf)
		{
			if (buf < 40 || buf > 300)
				return (true);
			else
			{
				height = buf;
				return (false);
			}
		}

		public bool SetWeight(double buf)
		{
			//round *.* format to *.1 format 
			buf = (double)(Math.Round(buf * 10)) / 10;
			if (buf < 0 || buf > 650)
				return (true);
			else
			{
				weight = buf;
				return (false);
			}
		}

		public bool SetGender(char buf)
		{
			if (buf == 'M' || buf == 'F')
			{
				gender = buf;
				return (false);
			}
			else
				return (true);
		}

		public int GetId()
		{ return (id); }

		public int GetAge()
		{ return (age); }

		public int GetHeight()
		{ return (height); }

		public double GetWeight()
		{ return (weight); }

		public char GetGender()
		{ return (gender); }

		public bool Init(int bufId, int bufAge, int bufHeight, double bufWeight, char bufGender, Fio bufFio)
		{
			Human check = new Human();

			if (check.SetId(bufId) || check.SetAge(bufAge) || check.SetHeight(bufHeight) ||
				check.SetWeight(bufWeight) || check.SetGender(bufGender))
				return (true);
			else
			{
				this.SetId(check.GetId());
				this.SetAge(check.GetAge());
				this.SetHeight(check.GetHeight());
				this.SetWeight(check.GetWeight());
				this.SetGender(check.GetGender());
				this.fioField.Init(bufFio.GetSurname(), bufFio.GetName(), bufFio.GetPatronymic());
				return (false);
			}
		}

		public bool Read()
		{
			Human check = new Human();
			int intBuf;
			double doubleBuf;
			char charBuf;

			Console.Write("Enter id:\n");
			if (!int.TryParse(Console.ReadLine(), out intBuf))
				return (true);
			if (check.SetId(intBuf))
				return (true);


			Console.Write("Enter age:\n");
			if (!int.TryParse(Console.ReadLine(), out intBuf))
				return (true);
			if (check.SetAge(intBuf))
				return (true);


			Console.Write("Enter height:\n");
			if (!int.TryParse(Console.ReadLine(), out intBuf))
				return (true);
			if (check.SetHeight(intBuf))
				return (true);


			Console.Write("Enter weight:\n");
			if (!double.TryParse(Console.ReadLine(), out doubleBuf))
				return (true);
			if (check.SetWeight(doubleBuf))
				return (true);


			Console.Write("Enter gender:\n");
			if (!char.TryParse(Console.ReadLine(), out charBuf))
				return (true);
			if (check.SetGender(charBuf))
				return (true);


			if (check.fioField.Read())
				return (true);


			this.Init(check.GetId(), check.GetAge(), check.GetHeight(), check.GetWeight(), check.GetGender(), check.fioField);
			return (false);
		}

		public void Display()
		{
			Console.Write("id: {0}\n", id);
			Console.Write("age: {0}\n", age);
			Console.Write("height: {0}\n", height);
			Console.Write("weight: {0:f1}\n", weight);
			Console.Write("gender: {0}\n", gender);
			fioField.Display();
		}

		static void Main(string[] args)
		{
			Fio myFio = new Fio();                              //mentioned thing
			if (myFio.Init("Sidenko", "Matvey", "Evgenievich")) //mentioned thing
				Console.Write("error\n");                       //mentioned thing
			else                                                //mentioned thing
				myFio.Display();                                //mentioned thing


			Console.Write("--------Human class--------\n");
			Console.Write("------init method-------\n");
			Human myHuman = new Human();
			if (myHuman.Init(1984, 45, 193, 90.87, 'M', myFio))
				Console.Write("error\n");
			else
				myHuman.Display();


			Console.Write("\n------Read method------\n");
			if (myHuman.Read())
				Console.Write("error\n");
			else
				myHuman.Display();


			Console.Write("\n------Set methods-------\n");
			if (myHuman.SetId(1999) || myHuman.SetAge(27) || myHuman.SetHeight(180) ||
				myHuman.SetWeight(80.890) || myHuman.SetGender('M'))
				Console.Write("error\n");
			else
				myHuman.Display();
			Console.ReadKey();
		}
	}
}
