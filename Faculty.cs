using System;

namespace Prog_lab6 
{
	public class Faculty 
	{
		//Attributes
		private string facultyName;
		private int quantityOfStudents;
		private int quantityOfBachelors;
		private int quantityOfMasters;
		private int quantityOfTeachers;
		private int quantityOfCandidates;
		private int quantityOfDoctors;
		private int quantityOfDisciplines;


		//Methods
		public bool SetFacultyName(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
			{
				return (true);
			}

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					return (true);
			}

			facultyName = new string (bufString.ToCharArray());
			return (false);
		}

		public bool SetQuantityOfStudents(int buf)
		{
			if (buf < 0 || buf > 1000)
				return (true);
			else
			{
				quantityOfStudents = buf;
				return (false);
			}
		}

		public bool SetQuantityOfBachelors(int buf)
		{
			if (buf < 0 || buf > 1000)
				return (true);
			else
			{
				quantityOfBachelors = buf;
				return (false);
			}
		}

		public bool SetQuantityOfMasters(int buf)
		{
			if (buf < 0 || buf > 1000)
				return (true);
			else
			{
				quantityOfMasters = buf;
				return (false);
			}
		}

		public bool SetQuantityOfTeachers(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfTeachers = buf;
				return (false);
			}
		}

		public bool SetQuantityOfCandidates(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfCandidates = buf;
				return (false);
			}
		}

		public bool SetQuantityOfDoctors(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfDoctors = buf;
				return (false);
			}
		}

		public bool SetQuantityOfDisciplines(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfDisciplines = buf;
				return (false);
			}
		}

		public bool SetStudentsInfo(int allQuantity, int bachelorsQuantity, int mastersQuantity)
		{
			if (allQuantity < 0 || allQuantity > 1000 || bachelorsQuantity < 0 || bachelorsQuantity > 1000 || mastersQuantity < 0 || mastersQuantity > 1000)
				return (true);
			else
			{
				quantityOfStudents = allQuantity;
				quantityOfBachelors = bachelorsQuantity;
				quantityOfMasters = mastersQuantity;
				return (false);
			}
		}

		public bool SetTeachersInfo(int allQuantity, int candidatesQuantity, int doctorsQuantity)
		{
			if (allQuantity < 0 || allQuantity > 100 || candidatesQuantity < 0 || candidatesQuantity > 100 || doctorsQuantity < 0 || doctorsQuantity > 100)
				return (true);
			else
			{
				quantityOfTeachers = allQuantity;
				quantityOfCandidates = candidatesQuantity;
				quantityOfDoctors = doctorsQuantity;
				return (false);
			}
		}


		public string GetFacultyName()
		{
			string outputString = new string(facultyName.ToCharArray());
			return (outputString);
		}

		public int GetQuantityOfStudents()
		{return quantityOfStudents;}

		public int GetQuantityOfBachelors()
		{return quantityOfBachelors;}

		public int GetQuantityOfMasters()
		{return quantityOfMasters;}

		public int GetQuantityOfTeachers()
		{return quantityOfTeachers;}

		public int GetQuantityOfCandidates()
		{return quantityOfCandidates;}

		public int GetQuantityOfDoctors()
		{return quantityOfDoctors;}

		public int GetQuantityOfDisciplines()
		{return quantityOfDisciplines;}

		//Processing methods
		public double GetProcentOfMasters()
		{return (((double)quantityOfMasters) / ((double)quantityOfStudents) * 100);}

		public double GetProcentOfDoctors()
		{return (((double)quantityOfDoctors) / ((double)quantityOfTeachers) * 100);}

		public double GetStudToTeachRatio()
		{return ((double)quantityOfStudents) / ((double)quantityOfTeachers);}

		public bool Init(string bufFacultyName, int studentsQuantity, int bachelorsQuantity, int mastersQuantity, int teachersQuantity, int candidatesQuantity, int doctorsQuanity, int discpilinesQuantity)
		{
			Faculty check = new Faculty();

			if (check.SetFacultyName(bufFacultyName) || check.SetQuantityOfStudents(studentsQuantity) ||
				check.SetQuantityOfBachelors(bachelorsQuantity) || check.SetQuantityOfMasters(mastersQuantity) ||
				check.SetQuantityOfTeachers(teachersQuantity) || check.SetQuantityOfCandidates(candidatesQuantity) ||
				check.SetQuantityOfDoctors(doctorsQuanity) || check.SetQuantityOfDisciplines(discpilinesQuantity))
				return (true);
			else
			{
				this.SetFacultyName(bufFacultyName);
				this.SetStudentsInfo(studentsQuantity,bachelorsQuantity, mastersQuantity);
				this.SetTeachersInfo(teachersQuantity, candidatesQuantity, doctorsQuanity);
				this.SetQuantityOfDisciplines(discpilinesQuantity);
				return (false);
			}
		}

		public bool Read()
		{
			Faculty check = new Faculty();
			int bufInt;

			Console.Write("Enter faculty name:\n");
			if (check.SetFacultyName(Console.ReadLine()))
				return (true);


			Console.Write("Enter quantity of students:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
				
			if (check.SetQuantityOfStudents(bufInt))
				return (true);


			Console.Write("Enter quantity of bachelors:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
			if (check.SetQuantityOfBachelors(bufInt))
				return (true);


			Console.Write("Enter quantity of masters:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
			if (check.SetQuantityOfMasters(bufInt))
				return (true);


			Console.Write("Enter quantity of teachers:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
			if (check.SetQuantityOfTeachers(bufInt))
				return (true);


			Console.Write("Enter quantity of candidates:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
			if (check.SetQuantityOfCandidates(bufInt))
				return (true);


			Console.Write("Enter quantity of doctors:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
			if (check.SetQuantityOfDoctors(bufInt))
				return (true);


			Console.Write("Enter quantity of disciplines:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
			if (check.SetQuantityOfDisciplines(bufInt))
				return (true);


			this.SetFacultyName(check.GetFacultyName());
			this.SetQuantityOfStudents(check.GetQuantityOfStudents());
			this.SetQuantityOfBachelors(check.GetQuantityOfBachelors());
			this.SetQuantityOfMasters(check.GetQuantityOfMasters());
			this.SetQuantityOfTeachers(check.GetQuantityOfTeachers());
			this.SetQuantityOfCandidates(check.GetQuantityOfTeachers());
			this.SetQuantityOfDoctors(check.GetQuantityOfDoctors());
			this.SetQuantityOfDisciplines(check.GetQuantityOfDisciplines());
			return (false);
		}

        public void Display()
		{
			Console.Write("faculty name: {0}\n", facultyName);
			Console.Write("quantity of students: {0}\n", quantityOfStudents);
			Console.Write("quantity of bachelors: {0}\n", quantityOfBachelors);
			Console.Write("quantity of masters: {0}\n\n", quantityOfMasters);

			Console.Write("quantity of teachers: {0}\n", quantityOfTeachers);
			Console.Write("quantity of candidates: {0}\n", quantityOfCandidates);
			Console.Write("quantity of doctors: {0}\n\n", quantityOfDoctors);

			Console.Write("quantity of disciplines: {0}\n", quantityOfDisciplines);
		}

		static void Main(string[] args)
		{
			Console.Write("\n--------Faculty class--------\n");
			Console.Write("-------init method-------\n");
			Faculty myFaculty = new Faculty();
			if (myFaculty.Init("FoIT", 180, 145, 35, 40, 20, 5, 70))
				Console.Write("error\n");
			else
				myFaculty.Display();

			Console.Write("\n------Shortcut-set methods-------\n");
			myFaculty.SetStudentsInfo(300, 270, 30);
			myFaculty.SetTeachersInfo(40, 33, 7);
			if (myFaculty.SetFacultyName("Fo****IT"))
				Console.Write("Error\n");
			else
				myFaculty.Display();

			Console.Write("\n------read method-------\n");
			if (myFaculty.Read())
				Console.Write("error\n");
			else
				myFaculty.Display();

			Console.Write("\n----processing by methods----\n");
			Console.Write("Procent of masters on faculty: {0:f2}\n", myFaculty.GetProcentOfMasters());
			Console.Write("Procent of doctors on faculty: {0:f2}\n", myFaculty.GetProcentOfDoctors());
			Console.Write("Students to teachers quantity: {0:f2}\n", myFaculty.GetStudToTeachRatio());
			Console.ReadKey();
		}
	}
}
