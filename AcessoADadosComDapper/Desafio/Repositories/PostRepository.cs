using Blog.Models;
using Blog.Screens.UserScreens;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;

        public void VincularPostTag(int postId, int tagId)
        {
            var query = "INSERT INTO [PostTag] (PostId,TagId) VALUES (@PostId,@TagId)";

            try
            {
                _connection.Query(query, new { PostId = postId, TagId = tagId });
                Console.WriteLine("Vínculo realizado com sucesso.");
                Console.ReadKey();
                LinkPostScreen.Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível víncular o post a tag - {ex.Message}");
                Console.ReadKey();
                LinkPostScreen.Load();
            }
        }
        public List<Post> ObterListaPostPorCategoria(int idCategory)
        {
            var query = @"
                            SELECT 
                                P.[Id]
                                ,P.[CategoryId]
                                ,P.[AuthorId]
                                ,P.[Title]
                                ,P.[Summary]
                                ,P.[Body]
                                ,P.[Slug]
                                ,P.[CreateDate]
                                ,P.[LastUpdateDate]
                                ,C.[Name] AS NomeCategoria
                            FROM [Post] P
                            INNER JOIN [Category] C ON C.Id = P.CategoryId
                            WHERE CategoryId = @CategoryId
                         ";

            var posts = _connection.Query<Post>(query, new { CategoryId = idCategory }).ToList();

            return posts;
        }
    }
}
