using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SortOpgaverClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du skal køre de lavede unit test for at kontrollere resultat");
            Console.WriteLine("- tjekker dog ikke om du har valgt rigtig algoritme");
            Console.WriteLine("Kør test fra Test List Editor windue");
            Console.WriteLine("Find icon eller under menu-punkt Test->Windows");

            //// Mulig test fra Console program
            //int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };
            //SortOpgaver opgaver = new SortOpgaver();
            //opgaver.FillList(data);
            //Console.WriteLine("Før sorteringen:"+Environment.NewLine+opgaver.GetListElementsAsSting());
            //opgaver.BubbleSort_Primitive();
            //Console.WriteLine("EfterBubbleSort_Primitive:" + Environment.NewLine + opgaver.GetListElementsAsSting());
            //Console.WriteLine("------------------------------------------------");

            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.InsertionSort();
            List<int> sortedData = opgaver.GetIntListCopy();

            Console.WriteLine("Unsorted data:");
            for (int i = 0; i < data.Length-1; i++)
            {
                Console.Write(data[i] + ", ");
            }
            Console.WriteLine("\nSorted data:");
            for (int i = 0; i < data.Length - 1; i++)
            {
                Console.Write(sortedData[i] + ", ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
