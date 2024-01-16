using Blog.Helpers;
using System;

namespace Blog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de posts");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar posts");
            Console.WriteLine("2 - Cadastrar posts");
            Console.WriteLine("3 - Atualizar posts");
            Console.WriteLine("4 - Excluir posts");
            Console.WriteLine();
            Console.WriteLine();
            short opcaoUsuarioValidada = ValidadorDeTexto.ValidarValorEntradaUsuario(Console.ReadLine());

            switch (opcaoUsuarioValidada)
            {
                case 1:
                    ListPostScreen.Load();
                    break;
                case 2:
                    CreatePostScreen.Load();
                    break;
                case 3:
                    UpdatePostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}