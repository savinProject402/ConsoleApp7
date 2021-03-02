using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public class Starter
    {
        public static void Run()
        {


            var a_List = new ClassList<string>();
            Console.WriteLine("void Add");
            a_List.Add("Homer");
            a_List.Add("Marge");
            foreach (var item in a_List)
            { Console.Write(item); }


            Console.WriteLine();
            Console.WriteLine("void AddRange");

            var b_List = new List<string>();
            b_List.Add("Meggie");
            a_List.AddRange(b_List);
            foreach (var item in a_List)
            { Console.Write(item); }

            Console.WriteLine();
            Console.WriteLine("int IndexOf(T item)");
            Console.WriteLine(a_List.IndexOf("Meggie"));

            a_List.Remove("o");
            foreach (var item in a_List)
            { Console.Write(item); }
            Console.WriteLine();
            Console.WriteLine("void Sort()");
            a_List.Sort();
            foreach (var item in a_List)
            { Console.Write(item); }

            Console.WriteLine();
            Console.WriteLine("void RemoveAt(int index):");
            a_List.RemoveAt(1);
            foreach (var item in a_List)
            { Console.Write(item); }
            Console.WriteLine();
            Console.WriteLine("void Insert(int index, T item):");
            a_List.Insert(2, "Gralsburg");
            foreach (var item in a_List)
            { Console.Write(item); }

        }
    }
}
