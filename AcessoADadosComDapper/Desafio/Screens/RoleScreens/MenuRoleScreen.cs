using Blog.Screens.UserScreens;
using Blog.Helpers;
using System;

namespace Blog.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de perfis de usuários");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar perfis de usuários");
            Console.WriteLine("2 - Cadastrar perfis de usuários");
            Console.WriteLine("3 - Atualizar perfis de usuários");
            Console.WriteLine("4 - Excluir perfis de usuários");
            Console.WriteLine();
            Console.WriteLine();
            short opcaoUsuarioValidada = ValidadorDeTexto.ValidarValorEntradaUsuario(Console.ReadLine());

            switch (opcaoUsuarioValidada)
            {
                case 1:
                    ListRoleScreen.Load(voltarMenu: true);
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}