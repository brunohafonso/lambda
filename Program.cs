using System;
using System.Collections.Generic;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            //funções com retorno
            /*Func<int, int, int> res = soma;
            System.Console.WriteLine(res(10, 35));

            Func<int, int, double> rs = Atividade.subtrair;
            System.Console.WriteLine(rs(5, 4));

            Func<int, int, double> resa = Atividade.multiplicar;
            System.Console.WriteLine(resa(5, 5));


            //funções sem retorno
            Action<int, int> teste = somar;
            teste(1, 5);

            //funções com retorno bool
            Predicate<int> par_impar = ParImpar;
            System.Console.WriteLine("digite um numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (par_impar(num))
            {
                System.Console.WriteLine("o numero e par.");
            }
            else
            {
                System.Console.WriteLine("o numero e impar.");
            }

            Data dt = delegate(string msg)
            {
                return msg + "hoje é " + DateTime.Now.ToShortDateString(); 
            };
            System.Console.WriteLine(dt("Ola Neymar, desce o litrao porque "));*/
            /*int[] num = { 1, 5, 6, 7, 8, 10, 11, 35, 36, 48, 50 };
            foreach (var n in num)
            {
                if(n % 2 == 0) {
                    System.Console.WriteLine(n);
                }
            }*/

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Func<int, bool> rs = i => i % 2 == 0;

            foreach (int i in num)
            {
                if (rs(i))
                    System.Console.WriteLine(i);
            }

            Func<double,double,double> calculo = (x,y) => x/y;
            System.Console.WriteLine(calculo(25,2));

            List<string> cidades = new List<string>();
            
        }



        static bool Par(int valor)
        {
            return valor % 2 == 0;
        }

        static int soma(int v1, int v2)
        {
            return v1 + v2;
        }

        static void somar(int v1, int v2)
        {
            System.Console.WriteLine(v1 + v2);
        }

        static bool ParImpar(int valor)
        {
            return valor % 2 == 0;
        }

        delegate string Data(string mensagem);
    }
}
