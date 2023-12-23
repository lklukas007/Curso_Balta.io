using Dapper;
using System.Data;
using System.Data.SqlClient;

internal class Program
{
    private const string connection_string = "Server=localhost,1433;Database=balta;User ID=sa;Password=inovafarmaI";

    private static void Main(string[] args)
    {
        using (var connection = new SqlConnection(connection_string))
        {
            //UpdateCategory(connection);
            //CreateManyCategories(connection);
            //ListCategories(connection);
            //ExecuteProcedure(connection);
            ExecuteReadProcedure(connection);

        }

    }

    static void ListCategories(SqlConnection connection)
    {
        try
        {

            var items = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} - {item.Title}");
            }
            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao listar categorias! - Erro: {ex.Message}");
        }

    }

    static void CreateCategory(SqlConnection connection)
    {
        try
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Amazon AWS";
            category.Url = "amazon";
            category.Summary = "AWS Cloud";
            category.Order = 8;
            category.Description = "Categoria para serviços do AWS";
            category.Featured = false;

            var insertSql = @"INSERT INTO [Category] VALUES(@Id,@Title,@Url,@Description,@Order,@Summary,@Featured)";

            var linhas = connection.Execute(insertSql, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Order,
                category.Summary,
                category.Description,
                category.Featured

            });
            Console.WriteLine($"{linhas} linhas inseridas");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao criar categoria! - Erro: {ex.Message}");
        }
    }

    static void CreateManyCategories(SqlConnection connection)
    {
        try
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Amazon AWS";
            category.Url = "amazon";
            category.Summary = "AWS Cloud";
            category.Order = 8;
            category.Description = "Categoria para serviços do AWS";
            category.Featured = false;

            var category2 = new Category();
            category2.Id = Guid.NewGuid();
            category2.Title = "Nova";
            category2.Url = "nova";
            category2.Summary = "Categoria Nova de Teste";
            category2.Order = 9;
            category2.Description = "Categoria para Teste";
            category2.Featured = false;

            var insertSql = @"INSERT INTO [Category] VALUES(@Id,@Title,@Url,@Description,@Order,@Summary,@Featured)";

            var linhas = connection.Execute(insertSql, new[]{
            new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Order,
                category.Summary,
                category.Description,
                category.Featured

            },
            new
            {
                category2.Id,
                category2.Title,
                category2.Url,
                category2.Order,
                category2.Summary,
                category2.Description,
                category2.Featured

            }
            });
            Console.WriteLine($"{linhas} linhas inseridas");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao criar categoria! - Erro: {ex.Message}");
        }
    }

    static void UpdateCategory(SqlConnection connection)
    {
        var updateQuery = "UPDATE [Category] SET [Title] = @Title WHERE [Id]=@Id";
        var linhas = connection.Execute(updateQuery,
                                        new { Id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"), Title = "Frontend 2023" });

        Console.WriteLine($"{linhas} registros atualizados");
    }

    static void ExecuteProcedure(SqlConnection connection)
    {
        var procedure = "spDeleteStudent";
        var parametros = new { StudentId = "4020f2ef-e685-4a6a-a157-61fdea9e15e6" };
        var linhas = connection.Execute(procedure, parametros, commandType: CommandType.StoredProcedure);
        Console.WriteLine($"{linhas} linhas afetadas");

    }

    static void ExecuteReadProcedure(SqlConnection connection)
    {
        var procedure = "spListCourse";
        var parametros = new { CategoryId = "09ce0b7b-cfca-497b-92c0-3290ad9d5142" };
        var cursos = connection.Query(procedure, parametros, commandType: CommandType.StoredProcedure);
        foreach (var curso in cursos)
        {
            Console.WriteLine($"Nome do curso:{curso.Title} - Id do curso: {curso.Id}");
        }
        Console.ReadKey();  
    }

}