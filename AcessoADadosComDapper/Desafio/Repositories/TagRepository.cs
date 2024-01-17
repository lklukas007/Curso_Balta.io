using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class TagRepository : Repository<Category>
    {
        private readonly SqlConnection _connection;

        public TagRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;

        public List<Category> GetAmountTagPost()
        {
            var query = @"
                            SELECT T.Id, T.Name, COUNT(P.Id) AS Qtde_Posts 
                            FROM [Tag] T 
                            LEFT JOIN [Post] P ON T.[Id] = P.[CategoryId] 
                            GROUP BY T.Name,T.Id
                         ";

            var categories = _connection.Query<Category>(query).ToList();

            return categories;
        }
    }
}