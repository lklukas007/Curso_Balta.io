using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreens;

namespace Blog.Screens.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load(bool voltarMenu)
        {
            Console.WriteLine("Lista de posts");
            Console.WriteLine("-------------");
            List();
            List();
            if (voltarMenu)
            {
                Console.ReadKey();
                MenuPostScreen.Load();
            }
            else
            {
                Console.WriteLine("-------------");
            }
        }

        private static void List()
        {
            var repository = new Repository<Post>(Database.Connection);
            var posts = repository.Get();
            foreach (var post in posts)
                Console.WriteLine($"ID: {post.Id} - TÍTULO: {post.Title}");
        }
    }
}