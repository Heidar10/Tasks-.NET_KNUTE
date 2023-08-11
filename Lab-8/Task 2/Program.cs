﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project8
{
    class Mymatrix
    {
        private int a, b, c, d;
        public Mymatrix(int a, int b)
        {
            Random r = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Matrix[i, j] = r.Next(-100, 100);
        }
        public int[,] Matrix = new int[100, 100];

        public void Vivod(int c, int d) 
        {
            
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                    Console.Write(Matrix[i, j] + "\t");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    class podmatrix
    {
        public podmatrix(ref int[,] matr, int a, int b)
        { 
            A = a; B = b;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Array[i, j] = matr[i, j]; 
        }

        private int A, B; 
        private int[,] Array = new int[300, 300]; 

        public void showArray() 
        {
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                    Console.Write(Array[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }
    class mainlaba8
    {
        public static void Main()
        {
            int a, b, c, d;
            Console.WriteLine("Дана матрица: Martix[a, b]");
            Console.Write("Введите количество строк a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов b = ");
            b = Int32.Parse(Console.ReadLine());
            Mymatrix rev = new Mymatrix(a, b);
            rev.Vivod(a, b);
            

            Console.WriteLine("Выводим на экран подматрицу:");
            Console.WriteLine("Дана матрица: PodMatr[c, d]");
            Console.Write("Введите количество строк подматрицы c = ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов подматрицы d = ");
            d = Int32.Parse(Console.ReadLine());

            podmatrix A = new podmatrix(ref rev.Matrix, c, d);
            A.showArray();
            Console.ReadKey();

        }
    }
}