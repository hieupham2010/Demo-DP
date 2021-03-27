using System;
using System.Collections.Generic;
using System.Text;

namespace AccessPatternCSharp
{
    public class StudentDAO : DAO<Student>
    {
        private List<Student> students = new List<Student>();
        public void Create(Student student)
        {
            students.Add(student);
        }

        public void Delete(Student student)
        {
            students.Remove(student);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetId() == id)
                {
                    return students[i];
                }
            }
            return null;
        }

        public void Update(Student student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetId() == student.GetId())
                {
                    students[i].SetName(student.GetName());
                    students[i].SetAge(student.GetAge());
                    break;
                }
            }
        }
    }
}
