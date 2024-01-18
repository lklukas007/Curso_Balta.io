using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.PostScreens;

namespace Blog.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load(bool voltarMenu)
        {
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            List();
            if (voltarMenu)
            {
                Console.ReadKey();
                MenuTagScreen.Load();
            }
            else
            {
                Console.WriteLine("-------------");
            }
        }

        private static void List()
        {
            TagRepository repository = new (Database.Connection);
            var tags = repository.GetAmountTagPost();
            foreach (var tag in tags)
                Console.WriteLine($"{tag.Id} - {tag.Name} - {tag.QtdePosts}");
        }
    }
}