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
            //matr[0, 1] = 7;
            //matr[1, 2] = 2;

            Matrix matr1 = new Matrix(2, 3);
            matr1[1, 1] = -3;

            Console.WriteLine("{0}", Equals(matr1, matr));

            Console.WriteLine("{0}", matr1);
            Console.WriteLine("Matrix:\n{0}", matr);
            Console.ReadLine();
        }
    }
}
