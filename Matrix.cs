using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_class
{
    class Matrix
    {
        private double[, ] matrix;
        private int row_;        // Количество строк
        private int col_;        // Количество столбцов


        public int Row
        {
            get
            {
                return row_;
            }
        }
        public int Col
        {
            get
            {
                return col_;
            }
        }


        public Matrix(int row, int col)
        {
            row_ = row;     /// Сменить именование
            col_ = col;

            matrix = new double[Row, Col];
            /*
            matrix = new double[Row][];
            for (int i = 0; i < Row; i++)
            {
                matrix[i] = new double[Col];
            }
            */
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

        public double this[int row, int col]
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
    }
}
