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


            Console.Write("E-mail: ");
            var email = Console.ReadLine();

            Console.Write("Senha: ");
            var senha = ObterSenhaDigitadoPeloUsuario();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();
            
            Console.Write("Url da Imagem do usuário: ");
            var image = Console.ReadLine();
            
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = senha,
                Bio = bio,
                Image = image,
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

        public static string ObterSenhaDigitadoPeloUsuario()
        {
            string senha = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (!char.IsControl(key.KeyChar))
                {
                    senha += key.KeyChar;
                    Console.Write("*");
                }

                else if (key.Key == ConsoleKey.Backspace && senha.Length > 0)
                {
                    senha = senha.Substring(0, senha.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return senha;
        }
    }
}
