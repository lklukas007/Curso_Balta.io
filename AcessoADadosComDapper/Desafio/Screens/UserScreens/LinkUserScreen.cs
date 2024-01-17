using Blog.Repositories;
using Blog.Screens.RoleScreens;
using System;

namespace Blog.Screens.UserScreens
{
    public static class LinkUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular perfil/usuário");
            ListUserScreen.Load(voltarMenu: false);
            ListRoleScreen.Load(voltarMenu: false);
            Console.WriteLine("Digite o Id do perfil:");
            Console.WriteLine();
            var roleId = short.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Id do usuário:");
            Console.WriteLine();
            var userId = short.Parse(Console.ReadLine());

            UserRepository userRepository = new(Database.Connection);
            userRepository.VincularUsuarioPerfil(roleId, userId);

        }
    }
}