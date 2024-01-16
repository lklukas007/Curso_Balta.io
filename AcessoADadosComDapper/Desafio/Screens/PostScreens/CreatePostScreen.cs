using System;
using System.Diagnostics.CodeAnalysis;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Post");
            Console.WriteLine("-------------");

            Console.Write("ID da categoria do post: ");
            var categoryId = Console.ReadLine();

            Console.Write("ID do autor do post: ");
            var authorId = Console.ReadLine();

            Console.Write("Título do post: ");
            var title = Console.ReadLine();

            Console.Write("Resumo do post: ");
            var summary = Console.ReadLine();

            Console.Write("Texto do post: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var createDate = DateTime.Now;

            Create(new Post
            {
                CategoryId = int.Parse(categoryId),
                AuthorId = int.Parse(authorId),
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = createDate,
                LastUpdateDate = createDate

            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Post cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}