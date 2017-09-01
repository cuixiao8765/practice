using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MatrixMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[3, 4];
            int[,] matrixB = new int[4, 3] { { 2, 4, 3 }, { 3, 4, 1 }, { 2, 3, 2 }, { 1, 5, 2 } };
            int[,] matrixC = new int[3, 4];
            //为A矩阵赋值
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrixA[i, j] = (i + 1) * (j + 3);
                }
            }
            //C矩阵等于A*B的值
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            WriteLine("********矩阵A*********");
            outputMatrix(matrixA, 3, 4);
            WriteLine();
            WriteLine("********矩阵B*********");
            outputMatrix(matrixB, 4, 3);
            WriteLine();
            WriteLine("********矩阵C*********");
            outputMatrix(matrixC, 3, 4);
            WriteLine();
            ReadKey();


        }
        private static void outputMatrix(int[,] matrixX, int rowCount, int columnCount)
        {
            if (matrixX.Length != rowCount * columnCount)
            {
                WriteLine("行列数错误！");
            }
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    WriteLine(matrixX[i, j] + "\t");
                }
            }
        }
    }
}
