using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_class
{
    class Matrix<T> : ICloneable
    {
        private T[,] matrix;
        private int row;        // Количество строк
        private int col;        // Количество столбцов


        public int Row
        {
            get
            {
                return this.row;
            }
        }
        public int Col
        {
            get
            {
                return this.col;
            }
        }

        public Matrix(int row, int col)
        {
            this.row = row;     /// Сменить именование
            this.col = col;

            matrix = new T[Row, Col];
            /*
            matrix = new double[Row][];
            for (int i = 0; i < Row; i++)
            {
                matrix[i] = new double[Col];
            }
            */
        }

        ~Matrix()
        {
            //Console.WriteLine("Destroy");
        }

        // Ввод с клавиатуры
        /*
        public void Read()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());    /// Доделать, чтобы можно было вводить через пробел
                }
            }
        }
        */

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    builder.Append(matrix[i, j]);
                    builder.Append(' ');
                }
                builder.Append('\n');
            }

            return builder.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        // Индексатор
        public T this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }

        // Глубокое копирование
        public object Clone()
        {
            Matrix<T> clone = new Matrix<T>(this.Row, this.Col);

            for (int i = 0; i < clone.Row; i++)
            {
                for (int j = 0; j < clone.Col; j++)
                {
                    clone[i, j] = this[i, j];
                }
            }

            return clone;
        }

        // Операторы эквивалентности
        public static bool operator==(Matrix<T> lMatr, Matrix<T> rMatr)
        {
            return lMatr.Equals(rMatr);
        }
        public static bool operator!=(Matrix<T> lMatr, Matrix<T> rMatr)
        {
            return !lMatr.Equals(rMatr);
        }

        // Транспонирование матрицы
        public Matrix<T> Transposition()
        {
            Matrix<T> resMatr = new Matrix<T>(this.Col, this.Row);

            for (int i = 0; i < resMatr.Row; i++)
            {
                for (int j = 0; j < resMatr.Col; j++)
                {
                    resMatr[i, j] = this[j, i];
                }
            }

            return resMatr;
        }

        /*
        public static Matrix<T> operator+(Matrix<T> lMatr, Matrix<T> rMatr)
        {
            /// Проверка размерностей

            Matrix<T> resMatr = new Matrix<T>(lMatr.Row, lMatr.Col);

            for (int i = 0; i < resMatr.Row; i++)
            {
                for (int j = 0; j < resMatr.Col; j++)
                {
                    resMatr[i, j] = lMatr[i, j] + rMatr[i, j];
                }
            }

            return resMatr;
        }
        */

        /*
        interface IBinAlgOp<T>
        {
            static T operator+(T left, T right);
        }
        */
    }
}
