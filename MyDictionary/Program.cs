using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "C#");
            myDictionary.Add(2, "Python");
            myDictionary.Add(3, "C");
            myDictionary.Add(4, "Java");
            myDictionary.Add(5, "C++");

            Console.WriteLine("\n -----My Dictionary-----");
            myDictionary.ListTheDictionary();

            myDictionary.Add(2, "PHP");
            myDictionary.Add(6, "HTML");

            Console.WriteLine("\n -----My Dictionary-----");
            myDictionary.ListTheDictionary();
        }
    }
}