using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02
{
    internal class Matrix
    {
        private static int row;
        private static int col;
        private int[,] mat = new int[row, col];
        private int Min { get; set; } = 0;
        private int Max { get; set; } = 0;
        public Matrix()
        {
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mat[i, j] = random.Next(1, 20);
                }
                  
            }             
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Min > mat[i, j])
                    {
                        Min = mat[i, j];
                    }
                       
                    if (Max < mat[i, j])
                    {
                        Max = mat[i, j];
                    }
                        
                }
            }               
        }

        static Matrix()
        {
            Console.WriteLine("Введите количество строк: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            col = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }                
                Console.WriteLine();
            }
            Console.WriteLine($"\nМинимум: {Min}, Максимум: {Max}");
        }
        public override string ToString()
        {
            Print();
            return "";
        }
    }
}
