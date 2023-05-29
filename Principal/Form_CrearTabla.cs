using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form_CrearTabla : Form
    {

        private Instancia instanciaBase;

        public Form_CrearTabla(Instancia instanciaBase)
        {
            this.instanciaBase = instanciaBase;
            InitializeComponent();
        }

        private void Form_CrearTabla_Load(object sender, EventArgs e)
        {
            CargarComboBox_tablasCreadas();
        }

        private void CargarComboBox_tablasCreadas()
        {
            string baseSeleccionada = instanciaBase.baseDatos;

            string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={baseSeleccionada}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";
            string consulta = $"SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_catalog = '{baseSeleccionada}'; ";


            // crear el comando para ejecutar la consulta
            using (NpgsqlConnection connection = new NpgsqlConnection(str))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando para ejecutar la consulta
                using (NpgsqlCommand command = new NpgsqlCommand(consulta, connection))
                {
                    // Ejecutar la consulta y obtener el lector de datos
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpiar el ComboBox antes de cargar las tablas
                        comboBox_tablas.Items.Clear();

                        // Agregar los nombres de las tablas al ComboBox
                        while (reader.Read())
                        {
                            string nombreTabla = reader.GetString(0);
                            comboBox_tablas.Items.Add(nombreTabla);
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();
            }
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            CrearNuevaTabla();
        }

        private void CrearNuevaTabla()
        {
            string nombreTabla = textBox_nombreTabla.Text;
            string baseSeleccionada = instanciaBase.baseDatos;

            try
            {

                string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={baseSeleccionada}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                using (NpgsqlConnection connection = new NpgsqlConnection(str))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"CREATE TABLE {nombreTabla}();";

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
                MessageBox.Show($"La tabla {nombreTabla} a sido creada exitosamente");
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            this.Close();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            EliminarTabla();
        }

        private void EliminarTabla()
        {
            string tablaAEliminar = comboBox_tablas.Text;

            DialogResult dr = MessageBox.Show($"Estas seguro de eliminar las base de datos: {tablaAEliminar}?", "Borrar la base?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes)
            {
                try
                {
                    string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                    using (NpgsqlConnection connection = new NpgsqlConnection(str))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = $"DROP table {tablaAEliminar}";

                            command.ExecuteNonQuery();

                        }
                        connection.Close();
                    }

                    MessageBox.Show($"La tabla: {tablaAEliminar} a sido eliminada exitosamente");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show($"La tabla: {tablaAEliminar} no ha sido eliminada");
            }



        }
    }
}
