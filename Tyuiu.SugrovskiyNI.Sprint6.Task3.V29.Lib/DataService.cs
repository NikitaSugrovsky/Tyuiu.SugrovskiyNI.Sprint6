using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int col = 0; col < columns; col++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < rows - i - 1; j++)
                    {
                        if (matrix[j, col] > matrix[j + 1, col])
                        {
                            // Меняем местами только элементы текущего столбца.
                            int temp = matrix[j, col];
                            matrix[j, col] = matrix[j + 1, col];
                            matrix[j + 1, col] = temp;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
