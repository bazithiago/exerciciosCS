using System;

namespace exerciciosCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool validate = true;

            Program program = new Program();

            Console.WriteLine("Exercícios de C#");

            do
            {
                Console.WriteLine("\nQual exercício deseja consultar?");
                Console.WriteLine("(1) IMC");
                Console.WriteLine("(2) Salário");
                Console.WriteLine("(3) Volume da esfera");
                Console.WriteLine("(4) Médias escolares");
                Console.WriteLine("(5) Cadastro de pets");
                Console.WriteLine("(6) Sair");


                Console.WriteLine("\nDigite sua opção: ");
                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                       

                        break;

                    case 2:
                        

                        break;

                    case 3:
                        

                        break;

                    case 4:
                        

                        break;

                    case 5:
                        
                        break;

                    case 6:
                        validate = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");

                        break;
                }


                Console.WriteLine("\nAperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();


            } while (validate);       

        }
    }
}
