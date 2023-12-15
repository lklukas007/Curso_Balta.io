using FundamentosDaOrientacaoAObjetos.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FundamentosDaOrientacaoAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre ASP.NET", "aspnet"));

            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}

            var courses = new List<Course>();

            var courseOop = new Course("Curso OOP", "fundamentos-oop");
            var courseCsharp = new Course("Curso C#", "fundamentos-csharp");
            var courseAspNet = new Course("Curso ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOop);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialist .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Comece por aqui", "", null);
            var careerItem = new CareerItem(1, "Aprenda .NET", "", null);
            var careerItem3 = new CareerItem(3, "OOP", "", null);

            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);
            careers.Add(careerDotNet);

            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x=>x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
