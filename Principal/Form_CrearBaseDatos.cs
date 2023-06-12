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
    public partial class Form_CrearBaseDatos : Form
    {
        private Instancia instanciaBase;
        public Form_CrearBaseDatos(Instancia instanciaBase)
        {
            this.instanciaBase = instanciaBase;
            InitializeComponent();
        }

        private void Form_CrearBaseDatos_Load(object sender, EventArgs e)
        {

        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            CrearNuevaBaseDatos();
        }

        private void CrearNuevaBaseDatos()
        {
            string nombreBase = textBox_nombreBaseDatos.Text;

            bool comprobarBase = ComprobarBase(nombreBase);
            bool baseSinNombre = BaseSinNombre();

            if (comprobarBase == true)
            {
                MessageBox.Show($"La base {nombreBase} ya existe");

            }
            if (baseSinNombre == true)
            {
                MessageBox.Show("No es posible crear una base sin nombre");
            }
            else
            {
                try
                {
                    string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                    //string str = "server=localhost; port=5432; database=postgres; user id=postgres; password=sa123;";

                    using (NpgsqlConnection connection = new NpgsqlConnection(str))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = $"CREATE DATABASE {nombreBase}";

                            command.ExecuteNonQuery();

                        }
                        connection.Close();
                    }
                    MessageBox.Show($"La base de datos {nombreBase} a sido creada exitosamente");
 
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }


        private bool ComprobarBase(string _nombreBase)
        {
            string str = "server=localhost; port=5432; database=postgres; user id=postgres; password=sa123;";

            using (NpgsqlConnection connection = new NpgsqlConnection(str))
            {
                connection.Open();

                // Consulta SQL para verificar la existencia de la base de datos
                string consulta = "SELECT COUNT(*) FROM pg_database WHERE datname = @nombreBase;";

                using (NpgsqlCommand command = new NpgsqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("nombreBase", _nombreBase);

                    // Ejecutar la consulta y obtener el resultado
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si count es mayor a 0, significa que la base de datos existe
                    bool existe = count > 0;

                    return existe; //true

                }

            }
        }


        private bool BaseSinNombre()
        {
            if (textBox_nombreBaseDatos == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
