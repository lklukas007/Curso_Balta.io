using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        private readonly SqlConnection _connection;

        public CategoryRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;

        public List<Category> GetAmountCategoriesPost()
        {
            var query = @"
                        SELECT
                               C.Name,
                               COUNT(P.Id) AS Qtde_Posts
                        FROM [Category] C
                        LEFT JOIN [Post] P ON C.[Id] = P.[CategoryId]
                        GROUP BY C.Name";

            var categories = new List<Category>();

            categories = _connection.Query<Category>(query).ToList();

            return categories;
        }
    }
}