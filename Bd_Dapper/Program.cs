using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cadena de conexión a la base de datos MySQL
            string connectionString = "Server=localhost;Database=extrados;Uid=root;Pwd=alanMandy94$;";

            // Crear una conexión a la base de datos
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            try
            {
                // Abrir la conexión
                dbConnection.Open();
                // Aquí puedes realizar operaciones de lectura o escritura en la base de datos utilizando Dapper o cualquier otra biblioteca de acceso a datos.
                // Por ejemplo, podrías ejecutar consultas SQL con Dapper.
                // IDbCommand command = dbConnection.CreateCommand();
                // command.CommandText = "SELECT * FROM MiTabla";
                // IDbDataReader reader = command.ExecuteReader();

                // ... Realizar operaciones de base de datos ...


                ListarTodosLosUsuarios(dbConnection); // Llama a la función para listar todos los usuarios
                Console.WriteLine("");
                Console.WriteLine("Mostrar informacion de usuario por Id:");
                ObtenerInformacionDeUsuarioPorId(dbConnection, 3); // Llama a la función para obtener información de un usuario por su ID

                // asegúrate de cerrar la conexión.
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        
        static void ListarTodosLosUsuarios(IDbConnection connection)
        {
            string consulta = "SELECT User_Id, User_Nombre, User_Edad FROM usuarios";
            List<Usuario> usuarios = connection.Query<Usuario>(consulta).AsList();

            Console.WriteLine("Listado de todos los usuarios:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.User_Id}, Nombre: {usuario.User_Nombre}, Edad: {usuario.User_Edad}");
            }
        }

        static void ObtenerInformacionDeUsuarioPorId(IDbConnection connection, int userId)
        {
            string consulta = "SELECT User_Id, User_Nombre, User_Edad FROM usuarios WHERE User_Id = @UserId";
            Usuario usuario = connection.QueryFirstOrDefault<Usuario>(consulta, new { UserId = userId });

            if (usuario != null)
            {
                Console.WriteLine($"Información del usuario con ID {userId}:");
                Console.WriteLine($"ID: {usuario.User_Id}, Nombre: {usuario.User_Nombre}, Edad: {usuario.User_Edad}");
            }
            else
            {
                Console.WriteLine($"No se encontró un usuario con ID {userId}.");
            }
        }
    }

    // Definición de la clase Usuario para mapear los resultados de la base de datos
    class Usuario
    {
        public int User_Id { get; set; }
        public string User_Nombre { get; set; }
        public int User_Edad { get; set; }
    }
}

