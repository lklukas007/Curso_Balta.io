using MenuHtml;

namespace VisualizadorHtml
{
    public class Visualizador
    {
        public static void Show(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------");
            Substituir(texto);
            Console.WriteLine("-----------");
            Console.ReadKey();
            EditorHtmlMain.Show();
        }

        public static void Substituir(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            for (var i = 0; i <= palavras.Lenght; i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        palavras[i].SubString(
                            palavras[i].IndexOf('>') + 1,
                            (
                            (palavras[i].LastIndexOf('<') - 1)
                            - palavras[i].LastIndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}