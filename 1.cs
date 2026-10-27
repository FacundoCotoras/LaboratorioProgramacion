namespace ConexionMySQL1
{
    using System;
    using MySqlConnector;

    class Program
    {
        static string connectionString = "Server=127.0.0.1;Database=testdb;User Id=root;Password=;";

        static void ListarProductos(MySqlConnection connection)
        {



            string query = "SELECT id, nombre, precio, stock FROM productos"; 

            using MySqlCommand command = new MySqlCommand(query, connection); 

            command.Parameters.AddWithValue("@activo", 1);

            
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                int id = reader.GetInt32("id"); 
                string nombre = reader.GetString("nombre");
                double correo = reader.GetDouble("precio");
                int telefono = reader.GetInt32("stock");
                Console.WriteLine($"ID: {id} - Nombre: {nombre} \t- Precio: {correo} \t- Stock: {telefono}");
            }

        }

        static void AgregarProducto(MySqlConnection connection)
        {

            string query = "INSERT INTO Productos (nombre, precio, stock) VALUES (@nombre, @precio, @stock)";
            Console.WriteLine("Ingrese el Nombre del Producto: ");
            string x = Console.ReadLine();
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", x);
            Console.WriteLine("Ingrese el Precio del Producto: ");
            double y = double.Parse(Console.ReadLine());
            command.Parameters.AddWithValue("@precio", y);
            Console.WriteLine("Ingrese el Stock del Producto: ");
            int z = int.Parse(Console.ReadLine());
            command.Parameters.AddWithValue("@stock", z);
            
            // ExecuteNonQuery se usa para INSERT, UPDATE y DELETE
            int filasAfectadas = command.ExecuteNonQuery();


        }

        static void ActualizarStock(MySqlConnection connection)
        {
            string query = "UPDATE productos SET stock = @stock WHERE id = @id";

            using var command = new MySqlCommand(query, connection);
            Console.WriteLine("Ingrese el ID del producto a actualizar: ");
            int x = int.Parse(Console.ReadLine());
            command.Parameters.AddWithValue("@id", x); // ID del usuario que queremos modificar
            Console.WriteLine("Ingrese el Stock del producto a actualizar: ");
            int y = int.Parse(Console.ReadLine());
            command.Parameters.AddWithValue("@stock", y);

            int filasAfectadas = command.ExecuteNonQuery();


        }

        static void EliminarProducto(MySqlConnection connection)
        {
            string query = "DELETE FROM productos WHERE id = @id";

            using var command = new MySqlCommand(query, connection);
            Console.WriteLine("Ingrese el ID del Producto a borrar: ");
            int x = int.Parse(Console.ReadLine());
            command.Parameters.AddWithValue("@id", x); // ID del usuario a eliminar

            int filasAfectadas = command.ExecuteNonQuery();

        }
        static void Main(string[] args)
        {
            
            using MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            int opcion = 0;
            do
            {
                Console.WriteLine("\n--- MENÚ DE INVENTARIO ---");
                Console.WriteLine("1. Listar productos");
                Console.WriteLine("2. Agregar producto");
                Console.WriteLine("3. Actualizar stock");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            ListarProductos(connection);
                            break;
                        case 2:
                            AgregarProducto(connection);
                            break;
                        case 3:
                            ActualizarStock(connection);
                            break;
                        case 4:
                            EliminarProducto(connection);
                            break;
                        case 5:
                            Console.WriteLine("¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            } while (opcion != 5);
        }
    }
}


