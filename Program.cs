using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Stack<int> nums = new Stack<int>();
            for(int i = 0; i < 10; i++)
            {
                int num = rnd.Next(0, 1000);
                nums.Push(num);
                Console.WriteLine(i.ToString() + " " + num);
            }
            Console.WriteLine();
            for(int i=0; i < 10; i++)
            {
                int num = nums.Pop();
                Console.WriteLine(i.ToString() + " " + num);
            }

            Console.WriteLine("Press Enter to continue.....");
            Console.ReadLine();

        }
    }
}
