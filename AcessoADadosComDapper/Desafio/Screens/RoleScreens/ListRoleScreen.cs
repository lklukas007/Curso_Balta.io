using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreens;

namespace Blog.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load(bool voltarMenu)
        {
            Console.WriteLine("Lista de perfis de usuários");
            Console.WriteLine("-------------");
            List();
            if (voltarMenu)
            {
                Console.ReadKey();
                MenuRoleScreen.Load();
            }
            else
            {
                Console.WriteLine("-------------");
            }
        }

        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();
            foreach (var role in roles)
                Console.WriteLine($"{role.Id} - {role.Name} - ({role.Slug})");
        }
    }
}