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
            TestFunctionality();
        }

        // Тестирование функционала класса
        private static void TestFunctionality()
        {
            Matrix<bool> matr = new Matrix<bool>(2, 3);
            //matr[0, 1] = 7;
            //matr[1, 2] = 2;

            Matrix<double> matr1 = new Matrix<double>(2, 3);

            Matrix<double> matrDouble = (Matrix<double>)matr1.Transposition().Clone();
            matr1[1, 1] = -3;
            for (int i = 0; i < matrDouble.Row; i++)
            {
                for (int j = 0; j < matrDouble.Col; j++)
                {
                    matrDouble[i, j] = i * j;
                }
            }

            //Console.WriteLine("{0}\n", matr1 == matrDouble);
            Console.WriteLine("matr1:\n{0}", matr1);
            //Console.WriteLine("matr:\n{0}", matr);
            Console.WriteLine("matrDouble:\n{0}", matrDouble);
            Console.WriteLine("matr1 + matrDouble:\n{0}", matr1 * matrDouble);
            Console.ReadLine();

            //Console.WriteLine("Complete");
            //Matrix<double> m = matr1 + matrDouble;
        }
    }
}
