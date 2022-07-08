using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.MatematicaBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numero = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"\n{exercicio8_(numero)}");
            
        }

        private static void exercicio3()
        {
            int num1, num2, soma;

            Console.WriteLine("Jovem, jovem, digite o dois número.");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine(soma);            
        }

        private static void mediaaritmetica()
        {
            String name, resultado;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Qual o nome do aluno?");
            name = Console.ReadLine();

            Console.WriteLine("notas do 1, 2 e 3 bimestre:");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3)/3;

            Console.WriteLine($"Sua média: {media}");

            //if and else inline. "?"- se; ":" - se então
            //resultado = media >= 7 ? "aprovado" : "reprovado";
            
            if (media >= 7)
            {
                resultado = "aprovado";
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Parabéns, você foi {resultado}, {name}!! Sua nota: {media}");
            }
            else if(media >=3 && media <= 7)
            {
                resultado = "recuperação";
                //Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Você está de {resultado}, {name}. Sua nota {media}");
            }
            else
            {
                resultado = "reprovado";
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você está {resultado}, {name}. Nota: {media}");
            }
                        
        }

        private static void exercicio6()
        {
            int contador = 1;
            
            do
            {                
                
                if(contador%2==0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(contador);
                    
                }
                contador++;
            } while (contador <= 1);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Acabou!!!!!!!");
           
        }

        private static void exerceio7()
        {
            int contador = 100;

            do
            {
                Console.WriteLine(contador);
                contador--;
            } while (contador >= 0);
        }

        private static void exercicio8()
        {
            long num;
            long contador = 1;
            long fatorial;

            Console.WriteLine("Fatorial de qual número?");
            num = long.Parse(Console.ReadLine());

            fatorial = num;

            do
            {
                fatorial = fatorial * contador;                                
                contador++;
                                
            } while (contador < num);

            Console.WriteLine(fatorial);
            
        }
        private static long exercicio8_(long numero) 
        {
            //long numero = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine($"\n{exercicio8_(numero)}");

            if (numero == 0)
            {
                return 1;
            }
            else 
            {
                return numero * exercicio8_(numero -1);
            }
        }

    }
}
