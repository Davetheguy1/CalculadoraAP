using System.Diagnostics.Metrics;

namespace APCalculadora
{
    internal class Program
    {

        static List<string> opHis = new List<string>();
       
    
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Declare o Primeiro Número\n");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Segundo Número");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber + secondNumber;
            string operation = $"{firstNumber} + {secondNumber} = {result:F2}";
            opHis.Add(operation);
            Console.WriteLine($"\nResultado = {result.ToString("F2")}\n");
            Console.WriteLine("\n1.Realizar Outra Operação de Soma\n2.Voltar ao Menu Principal\n");
            
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
            string operation = $"{firstNumber} + {secondNumber} = {result:F2}";
            opHis.Add(operation);
            Console.WriteLine($"\nResultado = {result.ToString("F2")}");
            Console.WriteLine("1.\nRealizar Outra Operação de Subtração\n2.Voltar ao Menu Principal\n");
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
            string operation = $"{firstNumber} + {secondNumber} = {result:F2}";
            opHis.Add(operation);
            Console.WriteLine($"\nResultado = {result.ToString("F2")}");
            Console.WriteLine("\n1.Realizar Outra Operação de Multipliação\n2.Voltar ao Menu Principal\n");
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
            string operation = $"{firstNumber} + {secondNumber} = {result:F2}";
            opHis.Add(operation);
            Console.WriteLine($"\nResultado = {result.ToString("F2")}\n");
            Console.WriteLine("1.\nRealizar Outra Operação de Divisão\n2.Voltar ao Menu Principal\n");
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

        static void ShowHis()
        {
            Console.Clear();
            Console.WriteLine("Histórico de Operações:\n");

            if (opHis.Count == 0)
            {
                Console.WriteLine("Nenhuma Operação Registrada.");
            }
            else
            {
                foreach (string operation in opHis)
                {
                    Console.WriteLine(operation);
                }
            }

            Console.WriteLine("\nPressione Enter para voltar ao Menu Principal");
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
                ShowHis();
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
