using System;
using System.Collections.Generic;
using System.Text;

namespace AccessPatternCSharp
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        public Student(int id , string name, int age) {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public override string ToString()
        {
            return "Student [id=" + id + ", name=" + name + ", age=" + age + "]";
        }
    }
}
