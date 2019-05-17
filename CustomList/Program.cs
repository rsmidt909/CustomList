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
            shawnList.Add("2");
            shawnList.Add("4");
            shawnList.Add("6");
            shawnList.Add("8");
            shawnList.Add("10");
            shawnList.Remove("2");
            shawnList.Remove("4");
            shawnList.Remove("6");
            shawnList.Remove("8");
            shawnList2.Add("9");
            shawnList.Zip(shawnList2);
            shawnList.Add("4");
            Console.WriteLine(shawnList);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
