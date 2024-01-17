using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias de posts");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            CategoryRepository repository = new (Database.Connection);
            var categories = repository.GetAmountCategoriesPost();
            foreach (var category in categories)
                Console.WriteLine($"ID: {category.Id} - NOME: {category.Name} - QTDE DE POSTS: {category.QtdePosts}");
        }
    }
}