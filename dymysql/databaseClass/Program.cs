//On Terminal write dotnet add package MySql.Data
//Now the database connection will be included in obj>databaseclass.csproj as
//  <ItemGroup>
//     <PackageReference Include="MySql.Data" Version="8.3.0" />
//   </ItemGroup>
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DatabaseNamespace {
    class Program {
        static void Main(string[] args) {
            MySqlConnection conn;
            MySqlCommand command;

            // Query to connect with database 

            string constr="Server=localhost; DATABASE=database_dotnet; UID=root; PASSWORD=;";
            conn = new MySqlConnection(constr);
            conn.Open();

            // Query to upload product to the database 
            string sql="insert into product values ('2','Wheat','2000','White','Basmati')";
            command = new MySqlCommand(sql,conn);
            command.ExecuteNonQuery();
            Console.WriteLine


        }
    }
}