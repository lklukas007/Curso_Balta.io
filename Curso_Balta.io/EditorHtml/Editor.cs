using System;
using System.IO;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Iniciar();
        }

        static void Iniciar()
        {
            var arquivo = new StringBuilder();

            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("----------------------------------");
            SalvarArquivo(arquivo.ToString());
            Visualizador.Show(arquivo.ToString());
        }

        static void SalvarArquivo(string arquivo)
        {
            var opcaoUsuario = short.Parse(Console.ReadLine());
            var caminhoPadraoArquivo = @"C:\Temp";
            var nomePadraoArquivo = "index.html";
            var caminhoCompletoArquivo = caminhoPadraoArquivo + nomePadraoArquivo;
            if (!Directory.Exists(caminhoPadraoArquivo))
            {
                Directory.CreateDirectory(caminhoPadraoArquivo);
            }

            Console.WriteLine("----------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("Digite a opção desejada: 1 PARA SALVAR ou 0 PARA NÃO SALVAR");

            switch (opcaoUsuario)
            {
                case 1: File.WriteAllText(caminhoCompletoArquivo, arquivo); break;
                case 0: Show(); break;
                default: Show(); break;
            }
        }
    }
}