using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo perfil de usuário");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role
            {
                Name = name,
                Slug = slug

            }); ;
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                Console.WriteLine("Perfil de usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o perfil de usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
