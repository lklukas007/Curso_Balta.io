using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreens;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Screens.RelatorioScreens
{
    public static class ListPostPerCategoryRelatorio
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Relatório de lista de posts por categoria");
            Console.WriteLine("-------------");
            ListCategoryScreen.Load(voltarMenu: false);
            Console.WriteLine("Insira um id de uma categoria:");
            var idCategory = short.Parse(Console.ReadLine());
            ListarPostsPorCategoria(idCategory);
            Console.ReadKey();
            Load();
        }
        public static void ListarPostsPorCategoria(int idCategory)
        {
            PostRepository repository = new(Database.Connection);
            List<Post> postsPerCategory = repository.ObterListaPostPorCategoria(idCategory);

            string nomeCategoria = postsPerCategory.FirstOrDefault()?.NomeCategoria;

            if (!string.IsNullOrEmpty(nomeCategoria))
            {
                Console.WriteLine($"Lista de posts da categoria: {nomeCategoria}");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
                return;
            }

            foreach (var postPerCategory in postsPerCategory)
            {
                Console.WriteLine($"ID: {postPerCategory.Id} - TÍTULO: {postPerCategory.Title} - NOME CATEGORIA: {postPerCategory.NomeCategoria}");
            }
        }



    }
}
