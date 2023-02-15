using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02
{
    class Matrix
    {
        private static int rows;
        private static int cols;
        private int[,] mat = new int[rows, cols];
        private int Min { get; set; } = 0;
        private int Max { get; set; } = 0;
        public Matrix()
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    mat[i, j] = random.Next(1, 20);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    if (Min > mat[i, j])
                        Min = mat[i, j];
                    if (Max < mat[i, j])
                        Max = mat[i, j];
                }
        }

        static Matrix()
        {
            Console.WriteLine("Введите кол-во строк: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов: ");
            cols = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine($"Min: {Min}, Max: {Max}");
        }

        public override string ToString()
        {
            Print();
            return "";
        }
    }
}
