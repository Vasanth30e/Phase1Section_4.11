using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }

        public static void runApp()
        {
            Queue Q = new Queue(10);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);
            Q.insert(60);
            Q.insert(70);
            Q.insert(80);
            Q.insert(90);
            Q.insert(100);

            Console.WriteLine(Q.printQueue());

            Q.delete();
            Q.delete();

            Console.WriteLine(Q.printQueue());
        }

    }
}
