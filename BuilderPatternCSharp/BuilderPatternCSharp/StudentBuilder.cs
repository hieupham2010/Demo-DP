using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternCSharp
{
    public class StudentBuilder : Builder
    {
        private int id;
        private string name;
        private int age;
        public Student Build()
        {
            return new Student(id, name, age);
        }

        public Builder SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public Builder SetId(int id)
        {
            this.id = id;
            return this;
        }

        public Builder SetName(string name)
        {
            this.name = name;
            return this;
        }
    }
}
