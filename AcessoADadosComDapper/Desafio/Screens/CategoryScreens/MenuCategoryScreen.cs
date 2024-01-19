using Blog.Screens.UserScreens;
using Blog.Helpers;
using System;

namespace Blog.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias de posts");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias de posts");
            Console.WriteLine("2 - Cadastrar categorias de posts");
            Console.WriteLine("3 - Atualizar categorias de posts");
            Console.WriteLine("4 - Excluir categorias de posts");
            Console.WriteLine();
            Console.WriteLine();
            short opcaoUsuarioValidada = ValidadorDeTexto.ValidarValorEntradaUsuario(Console.ReadLine());

            switch (opcaoUsuarioValidada)
            {
                case 1:
                    ListCategoryScreen.Load(voltarMenu: true);
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}