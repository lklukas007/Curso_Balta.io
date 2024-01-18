using Blog.Repositories;
using Blog.Screens.PostScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using System;

namespace Blog.Screens.UserScreens
{
    public static class LinkPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular post a uma tag");
            ListTagScreen.Load(voltarMenu: false);
            ListPostScreen.Load(voltarMenu: false);
            Console.WriteLine("Digite o Id do post:");
            Console.WriteLine();
            var postId = short.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Id da tag:");
            Console.WriteLine();
            var tagId = short.Parse(Console.ReadLine());

            PostRepository userRepository = new(Database.Connection);
            userRepository.VincularPostTag(postId, tagId);

        }
    }
}