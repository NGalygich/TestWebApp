using Microsoft.Data.Sqlite;
using SQLitePCL;

var builder = WebApplication.CreateBuilder(args);

//неправильно заполнил таблицу (ПЕРЕДЕЛАТЬ!)

#region Создание БД, таблиц
//using (var connection = new SqliteConnection("Data Source=TestDB.db"))
//{
//    connection.Open();
//    SqliteCommand command = new SqliteCommand();
//    command.Connection = connection;
//    //command.CommandText = "DROP TABLE Employees";
//    //command.CommandText = "CREATE TABLE Employees(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, FirstName TEXT NOT NULL, MiddleName TEXT NOT NULL, LastName TEXT NOT NULL, PositionCode TEXT NOT NULL, DepartmentCode TEXT NOT NULL, BirthDate DATE NULL, Email TEXT NULL, WorkPhone TEXT NULL, Gender INTEGER NOT NULL, IsHidden BLOB NOT NULL, LastModified DATE NOT NULL)";
//    //command.CommandText = "insert into Employees values ('1','Иванов', 'Иван', 'Иванович', '1', '0', '1990.01.01', 'ivanov@mail.com', '98887776655', '2', '0', date('now', '-5 months', '-3 days'))";
//    //command.CommandText = "CREATE TABLE ClosureTable(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, ParentId INTEGER NOT NULL, ChildId INTEGER NOT NULL, Depth INTEGER NOT NULL)";
//    command.CommandText = "insert into Employees values ('2', 'Петров', 'Владимир', 'Петрович', '10', '1', '1991.01.01', 'petrov@mail.com', NULL, '2', '0', date('now', '-4 months', '-3 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('3','Сидоров', 'Петр', 'Дмитриевич', '101', '1', '1992.01.01', 'sidorov@mail.com', '98881112233', '2', '0', date('now', '-4 months', '-4 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('4','Смирнов', 'Дмитрий', 'Иванов', '102', '1', '1993.01.01', 'smirnov@mail.com', '98886668844', '2', '0', date('now', '-4 months', '-4 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('5','Соколов', 'Иван', 'Михайлович', '103', '1', '1994.01.01', 'sokolov@mail.com', '98881115533', '2', '0', date('now', '-5 months', '-4 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('6','Кузнецов', 'Михаил', 'Владимирович', '1031', '1', '1995.01.01', 'k_ov@mail.com', NULL, '2', '0', date('now', '-5 months', '-4 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('7','Попова', 'Мария', 'Александровна', '1032', '1', '1996.01.01', 'popova_ma@mail.com', '98883632514', '1', '0', date('now', '-5 months', '-5 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('8','Новикова', 'Анна', 'Олеговна', '11', '2', '1997.01.01', NULL, '98887779874', '1', '0', date('now', '-5 months', '-5 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('9','Морозов', 'Сергей', 'Александрович', '111', '2', '1998.01.01', NULL, NULL, '2', '0', date('now', '-4 months', '-5 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('10','Зайцев', 'Александр', 'Дмитриевич', '112', '2', '1999.01.01', 'ivanov@mail.com', '98887771234', '2', '0', date('now', '-4 months', '-5 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('11','Виноградов', 'Дмитрий', 'Евгеньевич', '113', '2', '1991.01.01', 'VD@mail.com', '98887774321', '2', '0', date('now', '-4 months', '-5 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('12','Казаков', 'Олег', 'Петрович', '1111', '2', '1992.01.01', 'K_ov@mail.com', '98887770011', '2', '0', date('now', '-4 months', '-7 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('13','Суханов', 'Даниил', 'Иванович', '12', '3', '1993.01.01', 'Sh@mail.com', '98887771100', '2', '0', date('now', '-4 months', '-7 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('14','Воробьёва', 'Алиса', 'Владимировна', '121', '3', '1994.01.01', 'Vb@mail.com', '98886663300', '1', '0', date('now', '-4 months', '-7 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('15','Богданова', 'Евгения', 'Михайловна', '122', '3', '1995.01.01', 'B_em@mail.com', '98883330011', '1', '0', date('now', '-4 months', '-7 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('16','Тихонов', 'Денис', 'Петрович', '123', '3', '1996.01.01', 'T_ov@mail.com', '98881234568', '2', '0', date('now', '-5 months', '-8 days'))";
//    command.ExecuteNonQuery(); command.CommandText = "insert into Employees values ('17','Муравьёв', 'Григорий', 'Михайлович', '1211', '3', '1997.01.01', 'M_ev@mail.com', '98883241523', '2', '0', date('now', '-5 months', '-8 days'))";


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
