using System;
using System.Linq;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            UserRepository userRepository = new(Database.Connection);

            var users = userRepository.GetWithRoles();

            foreach (var user in users)
            {
                Console.Write($"ID: {user.Id} , NOME: {user.Name} , EMAIL: {user.Email}");

                foreach (var role in user.Roles)
                {
                    Console.WriteLine($", PERFIL: {role.Name}");
                }
            }

        }
    }
}