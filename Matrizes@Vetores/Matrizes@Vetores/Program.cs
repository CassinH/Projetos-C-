using System;

namespace Matrizes_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3, 5];
            /*
             10 20 30 40 50
             60 70 80 90 15
             25 35 45 55 65
             */

            n[0,0] = 10;
            n[0,1] = 20;
            n[0,2] = 30;
            n[0,3] = 40;
            n[0, 4] = 50;

            n[1, 0] = 60;
            n[1, 1] = 70;
            n[1, 2] = 80;
            n[1, 3] = 90;
            n[1, 4] = 15;

            n[2, 0] = 60;
            n[2, 1] = 70;
            n[2, 2] = 80;
            n[2, 3] = 90;
            n[2, 4] = 15;

            Console.WriteLine(n[1,5]);



        }
    }
}
