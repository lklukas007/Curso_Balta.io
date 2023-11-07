using Calculadora;
using Cronometro;
using EditorDeTexto;
using MenuHtml;

namespace MenuInicial
{
    public class MenuInicialMain
    {
        public static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("1 = Calculadora");
            Console.WriteLine("2 = Cronometro");
            Console.WriteLine("3 = Edito de Texto");
            Console.WriteLine("4 = Editor de HTML");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Selecione uma opção:");

            short entradaUsuario = short.Parse(Console.ReadLine());
            ValidarOpcaoUsuario(entradaUsuario);

        }

        private static void ValidarOpcaoUsuario(short entradaUsuario)
        {
            switch (entradaUsuario)
            {
                case 1: CalculadoraMain.Menu() ; break;
                case 2: CronometroMain.Menu() ; break;
                case 3: EditorTextoMain.Menu() ; break;
                case 4: EditorHtmlMain.Menu() ; break;
                default: Sair(); break;
            }
        }

        private static void Sair()
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