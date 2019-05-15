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
            CustomList<int> shawnList = new CustomList<int>();
            shawnList.Add(4);
            shawnList.Add(8);
            shawnList.Add(12);
            shawnList.Add(16);
            shawnList.Add(20);
            shawnList.Remove(8);
            shawnList.Add(10);
            Console.ReadLine();
        }
    }
}
