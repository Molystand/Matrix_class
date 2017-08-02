using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matr = new Matrix(2, 3);
            matr[0, 1] = 7;
            matr[1, 2] = 2;

            Console.WriteLine("{0}", matr[1, 2]);
            Console.WriteLine("Matrix:\n{0}", matr);
            Console.ReadLine();
        }
    }
}
