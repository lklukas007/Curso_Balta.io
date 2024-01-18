using Blog.Repositories;
using Blog.Screens.CategoryScreens;
using System;

namespace Blog.Screens.RelatorioScreens
{
    public static class ListRelatorio
    {
        public static void Load()
        {

            Console.WriteLine("Relatório");
            Console.WriteLine("-------------");
            Console.WriteLine("Lista de categorias:");
            ListCategoryScreen.Load();
            Console.WriteLine("Insira um id de uma categoria:");
            var idCategory = short.Parse(Console.ReadLine());
        }
        public static void ListarPostsPorCategoria()
        {
            CategoryRepository repository = new(Database.Connection);
            var postsPerCategory = repository.ObterListaPostPorCategoria();

            foreach (var postPerCategory in postsPerCategory)
            {
                Console.WriteLine(postPerCategory);
            }
        }


    }
}
