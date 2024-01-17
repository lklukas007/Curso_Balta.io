using Blog.Repositories;
using System;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load(bool voltarMenu)
        {
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-------------");
            List();
            if (voltarMenu)
            {
                Console.ReadKey();
                MenuUserScreen.Load();
            }
            else
            {
                Console.WriteLine("-------------");
            }
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