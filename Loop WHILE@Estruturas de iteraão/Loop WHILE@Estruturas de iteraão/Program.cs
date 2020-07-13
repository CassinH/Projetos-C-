using System;

namespace Loop_WHILE_Estruturas_de_iteraão
{
    class Program
    {
        static void Main(string[] args){
            
            int[] num = new int[10];
            int i = num.Length - 1;
            while (i > 0){
                num[i] = 0;
                Console.WriteLine(num[i]);
                i--;
            }

            Console.WriteLine("FIM");

        }
    }
}
