using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load(bool voltarMenu)
        {
            Console.WriteLine("Lista de categorias de posts");
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
            CategoryRepository repository = new (Database.Connection);
            var categories = repository.GetAmountCategoriesPost();
            foreach (var category in categories)
                Console.WriteLine($"ID: {category.Id} - NOME: {category.Name} - QTDE DE POSTS: {category.QtdePosts}");
        }
    }
}