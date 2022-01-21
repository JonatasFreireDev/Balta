// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Dapper;
using Model;

const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

using (var connection = new SqlConnection(connectionString))
{

}

public class Teste
{
  static void ListCategories(SqlConnection connection)
  {
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
    foreach (var item in categories)
    {
      Console.WriteLine($"{item.Id} - {item.Title}");
    }
  }

  static void CreateCategory(SqlConnection connection)
  {
    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon";
    category.Url = "amazon";
    category.Description = "Categoria destinada a serviços do AWS";
    category.Order = 8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    var insertSql = @"INSERT INTO
                    [Category]
                    VALUES(
                      @Id, @Title, @Url, @Summary, @Order, @Description, @Featured)";

    var rows = connection.Execute(insertSql, new
    {
      category.Id,
      category.Title,
      category.Url,
      category.Summary,
      category.Order,
      category.Description,
      category.Featured
    });

    Console.WriteLine($"{rows} linhas inseridas");
  }
}


// connection.Open();

// using (var coomand = new SqlCommand())
// {
//   coomand.Connection = connection;
//   coomand.CommandType = System.Data.CommandType.Text;
//   coomand.CommandText = "SELECT [Id], [Title] FROM [Category]";

//   var reader = coomand.ExecuteReader();

//   while(reader.Read()){
//     Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
//   }
