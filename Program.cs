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
                        int weight; 
                        double height;
                        double imc;

                        Console.WriteLine("Qual o seu peso(kg)? Digite apenas números, exemplo: 60");
                        weight = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Qual o sua altura(m)? Digite apenas números, exemplo: 1.75");
                        height = Convert.ToDouble(Console.ReadLine());    
                       
                        imc = Math.Round(weight / (height * height), 2); 
                        
                        Console.WriteLine($"Seu é IMC é igual a {imc}, portanto:");                       
                        
                        if(imc < 20) {
                            Console.WriteLine($"Você está abaixo do peso ideal");
                            return;
                        } else if (imc >= 20 && imc < 25) {
                            Console.WriteLine($"Você está dentro no peso ideal");
                            return;
                        } else {
                            Console.WriteLine($"Você está acima no peso ideal");
                            return;
                        };

                    case 2:
                        double salary;
                        double minSalary = 1192.4;
                        double result;

                        Console.WriteLine("Qual o seu salário mensal? Digite apenas números, ex: 3500.25");
                        salary = Convert.ToDouble(Console.ReadLine());

                        result = Math.Round(salary / minSalary, 2);
                        Console.WriteLine($"Você recebe {result} vezes um salário mínimo");                        

                        break;

                    case 3:
                        double radius;
                        double volume; 

                        Console.WriteLine("Vamos calcular o volume de uma esfera.\nQual o raio (em metros) da sua esfera? Digite apenas números, ex: 0.75");
                        radius = Convert.ToDouble(Console.ReadLine());

                        volume = Math.Round((4 * 3.1416 * (radius * radius * radius)/3), 2);
                        Console.WriteLine($"O volume da sua esfera é de {volume} metros cúbicos");
    
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
