using Microsoft.Data.Sqlite;

var builder = WebApplication.CreateBuilder(args);

#region Создание БД, таблиц
//using (var connection = new SqliteConnection("Data Source=TestDB.db"))
//{
//    connection.Open();
//    SqliteCommand command = new SqliteCommand();
//    command.Connection = connection;
//    command.CommandText = "DROP TABLE Employees";
//    command.CommandText = "CREATE TABLE Employees(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, FirstName TEXT NULL, MiddleName TEXT NULL, LastName TEXT NOT NULL, PositionCode TEXT NOT NULL, DepartmentCode TEXT NOT NULL, BirthDate DATE NULL, Email TEXT NULL, WorkPhone TEXT NULL, Gender INTEGER NOT NULL, IsHidden BLOB NOT NULL, LastModified DATE NOT NULL)";
//    command.CommandText = "CREATE TABLE ClosureTable(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, ParentId INTEGER NOT NULL, ChildId INTEGER NOT NULL, Depth INTEGER NOT NULL)";
//    command.ExecuteNonQuery();

//    Console.WriteLine("Таблицы созданы");
//}
#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
