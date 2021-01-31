using System;

namespace DictionaryCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Ege");
            myDictionary.Add(2, "Engin");
            myDictionary.Add(3, "Ahmet");
            myDictionary.Add(4, "Kaan");

            for (int i = 0; i < myDictionary.Keys.Length; i++)
            {
                Console.WriteLine(myDictionary.Keys[i] + "- " + myDictionary.Values[i]);
            }
        }
    }
}
