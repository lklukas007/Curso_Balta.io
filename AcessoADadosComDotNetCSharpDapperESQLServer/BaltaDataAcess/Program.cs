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
                connection.Open();
                Console.WriteLine("Conectado com sucesso!");
                Console.ReadKey();

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao se conectar! - Erro: {ex.Message}");
        }
    }
}