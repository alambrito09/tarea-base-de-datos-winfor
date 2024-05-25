using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tarea_base_alan.Data.data_acces
{
    internal class personajesdb
    {
        // Información de conexión a la base de datos
        private string connectionString = "Server=localhost;Database=universidad;Uid=root;Pwd=root;";
        //constructor
        public personajesdb(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=universidad;Uid=" + usur + ";Pwd=" + pwd + ";";
        }
        //prueba de conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        //metodo para leer personajes
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }
        // Método para crear un nuevo personaje
        public int CrearPersonaje(string nombre, string raza, int nivelPoder, DateTime fechaCreacion, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, fecha_creacion, historia) VALUES(@nombre, @raza, @nivelPoder, @fechaCreacion, @historia)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@fechaCreacion", fechaCreacion);
                    command.Parameters.AddWithValue("@historia", historia);

                    return command.ExecuteNonQuery();
                }
            }
        }

        //Busca un personaje por su ID
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }
        // Método para actualizar un personaje
        
        // Método para eliminar un personaje
        public void EliminarPersonaje(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        //si da tiempo:
        // Función para ejecutar consultas SQL genéricas
        public DataTable EjecutarConsulta(string consultaSQL)
        {
            DataTable resultado = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(consultaSQL, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(resultado);
                    }
                }
            }

            return resultado;
        }
        public void ActualizarPersonaje(int id, string nombre, string raza, int nivelPoder,  string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE personajes_dragon_ball SET nombre = @nombre, raza = @raza, nivel_poder = @nivelPoder, historia = @historia WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@historia", historia);

                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable Buscar(string historia)
        {
            DataTable personaje = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE historia like @historia";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@historia", "%" + historia + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }
            return personaje;
        }

        public DataTable Buscarfecha(DateTime fechacreacion)
        {
            DataTable personaje = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Utiliza la función DATE para comparar solo la parte de la fecha
                string sql = "SELECT * FROM personajes_dragon_ball WHERE DATE(fecha_creacion) = @fechacreacion";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@fechacreacion", fechacreacion.Date);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }
            return personaje;
        }

    }
}


