using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Usuário");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Console.Write("E-mail: ");
            var email = Console.ReadLine();

            Console.Write("Senha: ");
            var senha = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = senha,
                Bio = bio,
                Slug = slug

            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o Usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
