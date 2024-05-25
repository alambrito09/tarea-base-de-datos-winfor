using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using tarea_base_alan.Data.data_acces;

namespace tarea_base_alan
{
    public partial class Form1 : Form
    {
        // Lista de razas
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };
        private personajesdb personaje;
        public Form1()
        {
            InitializeComponent();
            personaje = new personajesdb("localhost", "root", "root");

        }

        private void buscarPorId()
        {
            int idPersonajeABuscar = int.Parse(textBoxid.Text);

            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeABuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {
                // El personaje fue encontrado
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime fechaCreacion = DateTime.Parse(personajeEncontrado.Rows[0]["fecha_creacion"].ToString());
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();

                textBoxnombre.Text = nombre;
                textBoxraza.Text = raza;
                comboBoxraza.Text = raza;
                numericUpDownnivelpoder.Value = nivelPoder;
                dateTimePickerfechacreacion.Value = fechaCreacion;
                textBoxhistoria.Text = historia;
            }
            else
            {
                // El personaje no fue encontrado
                Console.WriteLine("No se encontró el personaje con ID: " + idPersonajeABuscar);
            }



        }

        private void probar_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Conexión exitosa");
            }
            else
            {
                MessageBox.Show("Error en la conexión");
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            buscarPorId();
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            dataGridViewpersonajes.DataSource = personaje.LeerPersonajes();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxraza.Items.AddRange(razasDragonBall);
        }

        private void comboBoxraza_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxraza.Text = comboBoxraza.SelectedItem.ToString();
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            string raza = textBoxraza.Text;
            int nivelPoder = (int)numericUpDownnivelpoder.Value;
            DateTime fechaCreacion = dateTimePickerfechacreacion.Value;
            string historia = textBoxhistoria.Text;

            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder, fechaCreacion, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje creado correctamente");
                dataGridViewpersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Error al crear el personaje");
            }
        }
        private int ObtenerIdSeleccionado()
        {
            // Obtener el ID del personaje seleccionado en el DataGridView
            if (dataGridViewpersonajes.SelectedRows.Count > 0)
            {
                // Suponiendo que el ID está en la primera celda de la fila seleccionada
                return Convert.ToInt32(dataGridViewpersonajes.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                throw new Exception("Por favor, seleccione un personaje para actualizar.");
            }
        }
        private void actualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            string raza = textBoxraza.Text;
            string historia = textBoxhistoria.Text;
            int nivelPoder = (int)numericUpDownnivelpoder.Value;
            if (!string.IsNullOrWhiteSpace(textBoxid.Text))
            {
                int id = int.Parse(textBoxid.Text);
                MessageBox.Show("Actualizo Correctamente");
                personaje.ActualizarPersonaje(id, nombre, raza, nivelPoder, historia);
                dataGridViewpersonajes.DataSource = personaje.LeerPersonajes();
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Ingrese la ID del personaje");
                textBoxid.Focus(); // Devolver el foco al TextBox
            }
        }
        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPersonajeAEliminar = int.Parse(textBoxid.Text);

                // Llamar a la función EliminarPersonaje con el ID del personaje
                personaje.EliminarPersonaje(idPersonajeAEliminar);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Personaje eliminado correctamente.");

                // Limpiar los controles después de la eliminación si es necesario
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir
                MessageBox.Show($"Error al eliminar el personaje: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            // Limpiar los controles después de la eliminación si es necesario
            textBoxid.Clear();
            textBoxhistoria.Clear();
            textBoxnombre.Clear();
            textBoxraza.Clear();
            numericUpDownnivelpoder.ResetText();
            comboBoxraza.ResetText();
            dataGridViewpersonajes.DataSource = null;
           
        }

        private void historia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxhistoria.Text))
            {
                string historia = textBoxhistoria.Text;
                dataGridViewpersonajes.DataSource = personaje.Buscar(historia);
                textBoxhistoria.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de historia.");
                textBoxhistoria.Focus(); // Devolver el foco al TextBox
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void dateTimePickerfechacreacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechacreacion_Click(object sender, EventArgs e)
        {
            DateTime fechacreacion = dateTimePickerfechacreacion.Value;

            dataGridViewpersonajes.DataSource = personaje.Buscarfecha(fechacreacion);
        }

        private void dataGridViewpersonajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

