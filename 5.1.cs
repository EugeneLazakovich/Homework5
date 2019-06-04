using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] month = new int[12];
            for(int i = 0; i < month.Length; i++)
            {
                switch (i)
                {
                    case 3:
                    case 5:
                    case 8:
                    case 10:
                        month[i]=30;
                        break;
                    case 1:
                        month[i] = 28;
                        break;
                    default:
                        month[i] = 31;
                        break;
                }
            }
            for(int i = 0; i < month.Length; i++)
            {
                Console.WriteLine("month[" + (i+1) + "]: " + month[i]);
            }
        }
    }
}
