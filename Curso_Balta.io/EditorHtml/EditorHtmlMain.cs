using System;
using System.Threading;

namespace EditorHtml
{
    public static class EditorHtmlMain
    {

        public static class Menu
        { 

        public static void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            DesenhaTela();
            EscreveOpcoesUsuario();

            var opcaoUsuario = short.Parse(Console.ReadLine());
            ManipularOpcaoMenu(opcaoUsuario);
        }

        static void DesenhaTela()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        static void EscreveOpcoesUsuario()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Seleciona uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção:");
        }

        static void ManipularOpcaoMenu(short opcaoUsuario)
        {
            switch (opcaoUsuario)
            {
                case 1: Editor.Show(); break;
                case 2: Show(); break;
                case 0: Sair(); break;
                default: Show(); break;
            }
        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Tchau!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }

        }
    }
}