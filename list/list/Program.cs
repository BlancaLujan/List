using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>();

            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            myList.Add(60);
            myList.Add(70);
            myList.Add(80);
            myList.Add(90);
            myList.Add(100);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
