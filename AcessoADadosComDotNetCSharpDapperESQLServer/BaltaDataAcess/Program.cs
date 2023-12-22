using Dapper;
using System.Data.SqlClient;

internal class Program
{
    private const string connection_string = "Server=localhost,1433;Database=balta;User ID=sa;Password=inovafarmaI";

    private static void Main(string[] args)
    {
        try
        {
            using (var connection = new SqlConnection(connection_string))
            {
                var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.Id} - {category.Title}");
                }
                Console.ReadKey();

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao se conectar! - Erro: {ex.Message}");
        }
    }
}