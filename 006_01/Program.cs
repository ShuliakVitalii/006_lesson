using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_01
{
    public class MyMatrix
    {
        public static int[] arg = { 5, 6, 10, 12, 13, 15, 85, 65, 2, 54, 63, 2 };

        public static void Char()
        {
            Array.Sort(arg);
            for (int i = 0; i < arg.Length; i++)
            {
                Console.Write($"{arg[i]} ");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyMatrix.Char();
        }
    }
}