using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
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