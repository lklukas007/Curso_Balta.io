using FundamentosDaOrientacaoAObjetos.ContentContext;
using System;

namespace FundamentosDaOrientacaoAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course();

            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            foreach (var item in course.Modules)
            {

            }

        }
    }
}
