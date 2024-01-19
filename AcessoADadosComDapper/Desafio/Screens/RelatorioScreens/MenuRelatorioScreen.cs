using Blog.Helpers;
using Blog.Screens.CategoryScreens;
using System;

namespace Blog.Screens.RelatorioScreens
{
    public static class RelatorioScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Relatórios");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar os posts de uma categoria");
            Console.WriteLine("2 - Listar todos os posts com sua categoria");
            Console.WriteLine("3 - Listar os posts com sua tags");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite um número para acessar o módulo que deseja:");
            short opcaoUsuarioValidada = ValidadorDeTexto.ValidarValorEntradaUsuario((Console.ReadLine()!));

            switch (opcaoUsuarioValidada)
            {
                case 1:
                    ListPostPerCategoryRelatorio.Load();
                        break;
                default: Load(); break;
            }
        }
    }
}
