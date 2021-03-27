using System;

namespace AccessPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Student s1 = new Student(1, "Student A", 20);
			Student s2 = new Student(2, "Student B", 20);
			Student s3 = new Student(3, "Student C", 20);
			StudentDAO studentDao = new StudentDAO();
			studentDao.Create(s1);
			studentDao.Create(s2);
			studentDao.Create(s3);
			Console.WriteLine("--------------------------------------------");
			foreach (Student student in studentDao.GetAll())
			{
				Console.WriteLine(student.ToString());
			}
			studentDao.Delete(s1);
			Console.WriteLine("--------------------------------------------");
			foreach (Student student in studentDao.GetAll())
			{
				Console.WriteLine(student.ToString());
			}

			studentDao.Update(new Student(2, "Student E", 21));
			Console.WriteLine("--------------------------------------------");
			foreach (Student student in studentDao.GetAll())
			{
				Console.WriteLine(student.ToString());
			}
		}
    }
}
