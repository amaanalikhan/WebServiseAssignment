using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathService obj = new localhost.MathService();
            //int value1 = Convert.ToInt32(Console.ReadLine());
            //int value2 = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            ////List<int> tmp = new List<int> { 1, 2, 3, 4, 5 };
            ////Object o = tmp;

            //int    r = obj.Add(value1, value2);

            //string r = obj.Hello(s);
            //double ans=obj.Hello(s);
            Console.WriteLine(obj.AddNNumbers(s));
            Console.ReadKey();
        }
    }
}
