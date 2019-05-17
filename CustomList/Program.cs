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
            shawnList.Add("8");
            shawnList.Add("12");
            shawnList.Add("16");
            shawnList.Add("20");
            shawnList.Add("10");
            shawnList2.Add("4");
            shawnList.Add("16");
            shawnList.Remove("4");
            shawnList.Remove("8");
            shawnList.Remove("16");
            shawnList.Remove("10");         
            CustomList<string> shawnList3 = shawnList - shawnList2;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
