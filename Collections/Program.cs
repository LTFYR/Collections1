using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
     class Program
    {
        static void Main(string[] args)
        {
            SortedList prog = new SortedList();
            prog.Add("C#", 2000);
            prog.Add("JAVA", 1995);
            prog.Add("Python", 1991);
            prog.Add("C++", 1985);

            foreach (DictionaryEntry item in prog)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
