using System;

namespace BuilderPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder studentBuilder = 
                new StudentBuilder()
                .SetId(1)
                .SetAge(20)
                .SetName("Nguyen Van A");

            Console.WriteLine(studentBuilder.Build().ToString());
        }
    }
}
