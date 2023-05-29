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
    public partial class Form_CrearColumna : Form
    {
        private Instancia instanciaBase;
        public Form_CrearColumna(Instancia instanciaBase)
        {
            this.instanciaBase = instanciaBase;
            InitializeComponent();
        }

        private void Form_CrearColumna_Load(object sender, EventArgs e)
        {
            CargarComboBox_tablas();
            CargarComboBox_columnas();

        }

        

        private void CargarComboBox_tablas()
        {
            string baseSeleccionada = instanciaBase.baseDatos;

            string str = $"server=localhost; port=5432; database={baseSeleccionada}; user id=postgres; password=sa123;";
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



        private void CargarComboBox_columnas()
        {
            string baseSeleccionada = instanciaBase.baseDatos;
            string tablaSeleccionada = comboBox_tablas.Text;

            string str = $"server=localhost; port=5432; database={baseSeleccionada}; user id=postgres; password=sa123;";
            //string consulta = $"SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_catalog = '{baseSeleccionada}'; ";
            string query = $"SELECT column_name FROM information_schema.columns WHERE table_name = '{tablaSeleccionada}'";

            using (NpgsqlConnection connection = new NpgsqlConnection(str))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {

                        comboBox_columnas.Items.Clear();

                        while (reader.Read())
                        {
                            string nombreColumna = reader.GetString(0);
                            comboBox_columnas.Items.Add(nombreColumna);
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
