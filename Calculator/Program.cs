using System;

namespace Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("o que deseja fazer:");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");
            Console.WriteLine("5 - sair");

            Console.WriteLine("--------");
            Console.WriteLine("selecione uma opção:");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("digite primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("o resultado da soma é " + resultado);
            Console.ReadKey();
            Menu();
            

        }
     
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("digite primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine("o resultado da subtração é " + resultado);
            Console.ReadKey();
            Menu();


        }
    
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("digite primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine("o resultado da divisão é: " + resultado);
            Console.ReadKey();
            Menu();
        } 
        
        static void Multiplicacao()
        {
            Console.WriteLine("clear");

            Console.WriteLine("digite primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine("o resultado da multiplicação é: " + resultado);
            Console.ReadKey();
            Menu();
        }
    }

    

    

}