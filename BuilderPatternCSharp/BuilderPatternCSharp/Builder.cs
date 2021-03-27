using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternCSharp
{
    public interface Builder
    {
        public Builder SetId(int id);
        public Builder SetName(String name);
        public Builder SetAge(int age);
        public Student Build();
    }
}
