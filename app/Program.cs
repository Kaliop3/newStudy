// See https://aka.ms/new-console-template for more information

using System;

namespace CSharpSort
{
    class Program
    {

        // stdin: integers delimited by newline, finished with an empty line
        // stdout: integers sorted, delimited by ", "

        public static void Main(string[] args)
        {
            var list = new List<int>();

            Console.WriteLine("Please write some number");
            var getNumber = Console.ReadLine();


            while(getNumber!=""){
                int addNumber= int.Parse(getNumber);
                list.Add(addNumber);
                getNumber=Console.ReadLine();
            }
            list = Sort(list);
            DisplayList(list);
        }
        public static void DisplayList(List<int> list)
        {
            foreach (int s in list)
            {
                Console.Write("\t{0}", s);
            }
        }
        public static List<int> Sort(List<int> list)
        {
            int n = list.Count;
            int change;

            while (n > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        change = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = change;
                    }
                }
                n--;
            }

            return list;
        }
    }
}

// https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections
// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.append?view=net-6.0#system-linq-enumerable-append-1(system-collections-generic-ienumerable((-0))-0)
// https://docs.microsoft.com/en-us/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-string)