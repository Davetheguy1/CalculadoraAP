using System.Diagnostics.Metrics;

namespace APCalculadora
{
    internal class Program
    {
       

       
    
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Declare o Primeiro Número\n");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Segundo Número");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber + secondNumber;
            Console.WriteLine($"\nResultado = {result.ToString("F2")}\n");
            Console.WriteLine("\n1.Realisar Outra Operação de Soma\n2.Voltar ao Menu Principal\n");
            
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Sum();

            } else if (answer == "2")
            {
                MainProgram();
            } else
            {
                Console.WriteLine("\nOpção Inválida\n");
                answer = Console.ReadLine();
            }
            


        }



        static void Sub()
        {
            Console.Clear();
            Console.WriteLine("Declare o Primeiro Número\n");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Segundo Número");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber - secondNumber;
            Console.WriteLine($"\nResultado = {result.ToString("F2")}");
            Console.WriteLine("1.\nRealisar Outra Operação de Subtração\n2.Voltar ao Menu Principal\n");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Sub();

            }
            else if (answer == "2")
            {
                MainProgram();
            }
            else
            {
                Console.WriteLine("\nOpção Inválida\n");
                answer = Console.ReadLine();
            }


        }

        static void Mul()
        {
            Console.Clear();
            Console.WriteLine("Declare o Primeiro Número\n");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Segundo Número");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber * secondNumber;
            Console.WriteLine($"\nResultado = {result.ToString("F2")}");
            Console.WriteLine("\n1.Realisar Outra Operação de Multipliação\n2.Voltar ao Menu Principal\n");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Mul();

            }
            else if (answer == "2")
            {
                MainProgram();
            }
            else
            {
                Console.WriteLine("\nOpção Inválida\n");
                answer = Console.ReadLine();
            }


        }

        static void Div()
        {
            Console.Clear();
            Console.WriteLine("Declare o Primeiro Número\n");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Segundo Número");
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber == 0 || secondNumber == 0)
            {
                Console.WriteLine("Impossivel Dividir por Zero, pressione Enter para continuar");
                Console.ReadLine();
                Div();
            }

            double result = firstNumber / secondNumber;
            Console.WriteLine($"\nResultado = {result.ToString("F2")}\n");
            Console.WriteLine("1.\nRealisar Outra Operação de Divisão\n2.Voltar ao Menu Principal\n");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Div();

            }
            else if (answer == "2")
            {
                MainProgram();
            }
            else
            {
                Console.WriteLine("\nOpção Inválida\n");
                answer = Console.ReadLine();
            }


        }


        static void Tab()
        {
            Console.Clear();
            Console.WriteLine("Digite um Número\n");
            int tabNumber = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= 10; counter++)
            {
                int tabResult = tabNumber * counter;
                string tabLine = $"{tabNumber} x {counter} = {tabResult}";
                Console.WriteLine(tabLine);
            }
            Console.WriteLine("\nPressione Enter para Voltar ao Menu Principal");
            Console.ReadLine();
            MainProgram();


        }


        
        static void MainProgram()
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Calculadora");
            Console.WriteLine("------------------\n\n");
            Console.WriteLine("1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Tabuada\n6.Histórico\n7.Sair");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Sum();
            }
            else if (answer == "2")
            {
                Sub();
            }
            else if (answer == "3")
            {
                Mul();
            }
            else if (answer == "4")
            {
                Div();
            }
            else if (answer == "5")
            {
                Tab(); 
            }
            else if (answer == "6")
            {
                Console.WriteLine("Not Implemented Yet");
            }
            else if (answer == "7")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nOpção Inválida\n");
                MainProgram();
            }
        }




        static void Main(string[] args)
        {
            MainProgram();
            

            


        }
    }
}
