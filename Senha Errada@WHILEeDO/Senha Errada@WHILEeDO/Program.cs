using System;

namespace Senha_Errada_WHILEeDO
{
    class Program
    {
        static void Main(string[] args)
        {
            String senha = "1010";
            String senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha");
                senhauser = Console.ReadLine();
                tentativas++;
            } while (senha != senhauser);
           
            Console.Clear();
            Console.WriteLine("Senha Correta,tentativas:{0}", tentativas);
        }
    }
}
