using System;

namespace Prog_lab6
{
	public class Student
	{
		//Attributes
		private int course;
		private string eduProg;
		private string group;
		private string facultyName;
		public Human humanField = new Human();

		//Methods
		public bool SetCourse(int buf)
		{
			if (buf < 0 || buf > 6)
				return (true);
			else
			{
				course = buf;
				return (false);
			}
		}

		public bool SetEduProg(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				return (true);

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					return (true);
			}

			eduProg = new string (bufString.ToCharArray());
			return (false);
		}

		public bool SetGroup(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				return (true);

			string invalidSymbStr = "!@#$%^&*()_+=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					return (true);
			}

			group = new string (bufString.ToCharArray());
			return (false);
		}

		public bool SetFacultyName(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				return (true);

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

		public int GetCourse()
		{ return (course); }

		public string GetEduProg()
		{
			string outputString = new string(eduProg.ToCharArray());
			return (outputString);
		}

		public string GetGroup()
		{
			string outputString = new string (group.ToCharArray());
			return (outputString);
		}

		public string GetFacultyName()
		{
			string outputString = new string (facultyName.ToCharArray());
			return (outputString);
		}


		public bool Init(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
		{
			Student check = new Student();

			if (check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) || check.SetGroup(bufGroup) ||
				check.SetFacultyName(bufFacultyName))
				return (true);
			else
			{
				this.SetCourse(bufCourse);
				this.SetEduProg(bufEduProg);
				this.SetGroup(bufGroup);
				this.SetFacultyName(bufFacultyName);
				this.humanField.Init(bufHuman.GetId(), bufHuman.GetAge(),
				bufHuman.GetHeight(), bufHuman.GetWeight(), bufHuman.GetGender(), bufHuman.fioField);
				return (false);
			}
		}

		public bool Read()
		{
			Student check = new Student();
			int bufInt;

			Console.Write("Enter education programm:\n");
			if (check.SetEduProg(Console.ReadLine()))
				return (true);


			Console.Write("Enter group:\n");
			if (check.SetGroup(Console.ReadLine()))
				return (true);


			Console.Write("Enter faculty name:\n");
			if (check.SetFacultyName(Console.ReadLine()))
				return (true);


			Console.Write("Enter course:\n");
			if (!int.TryParse(Console.ReadLine(), out bufInt))
				return (true);
			if (check.SetCourse(bufInt))
				return (true);


			if (check.humanField.Read())
				return (true);
			

			this.Init(check.GetCourse(), check.GetEduProg(), check.GetGroup(),
			check.GetFacultyName(), check.humanField);
			return (false);
		}

		void Display()
		{
			Console.Write("course: {0}\n", course);
			Console.Write("direction of preparation: {0}\n", eduProg);
			Console.Write("group: {0}\n", group);
			Console.Write("faculty name: {0}\n", facultyName);
			humanField.Display();
		}

		static void Main(string[] args)
		{
			Fio myFio = new Fio();                          //mentioned thing
			myFio.Init("Sidenko", "Matvey", "Evgenievich"); //mentioned thing
			Human myHuman = new Human();                    //mentioned thing
			myHuman.Init(1984, 45, 193, 90.87, 'M', myFio); //mentioned thing


			Console.Write("\n--------Student class--------\n");
			Console.Write("-------init method-------\n");
			Student myStudent = new Student();
			if (myStudent.Init(2, "Bachelor", "PI-03", "FoIT", myHuman))
				Console.Write("error\n");
			else
				myStudent.Display();

			Console.Write("\n------read method------\n");
			if (myStudent.Read())
				Console.Write("error\n");
			else
				myStudent.Display();

			Console.Write("\n------Set methods-------\n");
			if (myStudent.SetCourse(4) || myStudent.SetEduProg("Master") ||
				myStudent.SetGroup("CS-91") ||
				myStudent.SetFacultyName("FoIT"))
				Console.Write("error\n");
			else
				myStudent.Display();
			Console.ReadKey();
		}
    }
}

