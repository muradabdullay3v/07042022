using System;
using System.Collections;

namespace Home06042022
{
    class Program
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> List = new SortedList<int, string>();
            List.Add(2001, "C#");
            List.Add(2014, "Swift");
            List.Add(1990, "Python");
            List.Add(1995, "JavaScript");
            List.Add(1980, "C++");

            foreach (var item in List)
            {
                Console.WriteLine($"Yaranma tarixi : {item.Key}\nProgramlashdirma dili : {item.Value}\n");
            }

        }
    }
}