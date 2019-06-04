using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            char[][] array= new char[n][];
            for(int i = 0; i < array.Length; i++)
            {
                char[] temp = new char[n];
                for(int j = 0; j < temp.Length; j++)
                {
                    if (i == 0 || i == array.Length - 1 || j == 0 || j == temp.Length - 1 || (i==array.Length/2 && (j==temp.Length/2-1||j==temp.Length/2||j==temp.Length/2+1)) || (j==temp.Length/2 && (i==array.Length/2-1||i==array.Length/2+1)))
                    {
                        temp[j] = '*';
                    }
                    else
                    {
                        temp[j] = ' ';
                    }
                }
                array[i] = temp;
            }
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
