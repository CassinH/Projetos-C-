using System;

namespace Loop_FOR_Estruturas_de_iteração
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++){
                num[i] = i;
            }
            for (int i = 0; i < num.Length; i++){
                Console.WriteLine("Valor de num na pos{0}:{1}", i, num[i]);
            }
        }
    }
}
