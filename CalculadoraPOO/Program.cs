using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bem vindo a Calculadora de 2 números! ");

                Console.Write("Digite o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                Calculadora calculadora = new Calculadora(numero1, numero2);

                Console.WriteLine("Digite uma Operação: (+, -, *, /)");
                string operacao = Console.ReadLine() ?? throw new ArgumentNullException("A operação não pode ser nula");

                double resultado = operacao switch
                {
                    "+" => calculadora.Soma(),
                    "-" => calculadora.Subtracao(),
                    "*" => calculadora.Multiplicacao(),
                    "/" => calculadora.Divisao(),
                    _ => throw new ArgumentException("Operação inválida."),
                };

                Console.WriteLine($"O resultado de {numero1} {operacao} {numero2} é: {resultado}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

        }
    }
}

    
