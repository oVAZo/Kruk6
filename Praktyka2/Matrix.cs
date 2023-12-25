using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktyka2
{
    internal class Matrix
    {
        private int[,] matrix;

        // Конструктор для ініціалізації матриці
        public Matrix()
        {
            matrix = new int[3, 3];
        }

        // Метод для присвоєння значень матриці з переданих змінних
        public void SetMatrixValues(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
        {
            matrix[0, 0] = a11;
            matrix[0, 1] = a12;
            matrix[0, 2] = a13;
            matrix[1, 0] = a21;
            matrix[1, 1] = a22;
            matrix[1, 2] = a23;
            matrix[2, 0] = a31;
            matrix[2, 1] = a32;
            matrix[2, 2] = a33;
        }
        public int CalculateSumColumn1()
        {
            return matrix[0, 0] + matrix[1, 0] + matrix[2, 0];
        }

        public int CalculateSumColumn2()
        {
            return matrix[0, 1] + matrix[1, 1] + matrix[2, 1];
        }

        public int CalculateSumColumn3()
        {
            return matrix[0, 2] + matrix[1, 2] + matrix[2, 2];
        }

    }
}
