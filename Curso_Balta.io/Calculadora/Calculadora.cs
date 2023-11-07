using System;

namespace Calculadora
{
    public static class CalculadoraMain
    {
        public static class Menu
        {
            public static void Show()
            {
                Console.Clear();

                Console.WriteLine("Selecione uma operação matématica para prosseguir.");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("---------------------");
                Console.WriteLine("Digite sua opção:");

                var opcaoUsuario = short.Parse(Console.ReadLine());
                switch (opcaoUsuario)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 5: System.Environment.Exit(0); break;
                    default: Menu.Show(); break;

                }
            }

        }

        private static void Soma()
        {
            float valor1 = 0;
            float valor2 = 0;

            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("Pressione a tecla ENTER para voltar ao Menu.");
            Console.ReadKey();
            Menu.Show();

        }

        private static void Subtracao()
        {
            float valor1 = 0;
            float valor2 = 0;

            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine("Pressione a tecla ENTER para voltar ao Menu.");
            Console.ReadKey();
            Menu.Show();
        }

        private static void Divisao()
        {
            float valor1 = 0;
            float valor2 = 0;

            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão de {valor1} divido por {valor2} é: {resultado}");
            Console.WriteLine("Pressione a tecla ENTER para voltar ao Menu.");
            Console.ReadKey();
            Menu.Show();
        }

        private static void Multiplicacao()
        {
            float valor1 = 0;
            float valor2 = 0;

            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.WriteLine("Pressione a tecla ENTER para voltar ao Menu.");
            Console.ReadKey();
            Menu.Show();
        }

    }
}