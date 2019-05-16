using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> shawnList = new CustomList<string>();
            CustomList<string> shawnList2 = new CustomList<string>();
            shawnList.Add("4");
            shawnList2.Add("8");
            shawnList.Add("12");
            shawnList2.Add("16");
            shawnList.Add("20");
            shawnList2.Add("10");
            CustomList<string> shawnList3 = shawnList + shawnList2;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
