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
    public partial class Form_CrearUsuarios : Form
    {

        private Instancia instanciaBase;
        public Form_CrearUsuarios(Instancia instanciaBase)
        {
            this.instanciaBase = instanciaBase;
            InitializeComponent();
        }
        

        private void Form_CrearUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            CrearUsuario(); 
        }

        private void CrearUsuario()
        {
            string nombreUsuario = textBox_nombre.Text;
            //string comentario = textBox_comentario.Text;
            string contrasenia = textBox_contrasenia.Text;

            bool logeo = checkBox_logueo.Checked;
            bool superusuario = checkBox_superusuario.Checked;


            if (logeo == true )
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
                            command.CommandText = $"CREATE ROLE {nombreUsuario} WITH LOGIN NOSUPERUSER INHERIT NOCREATEDB  NOCREATEROLE  NOREPLICATION  PASSWORD '{contrasenia}';";

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    MessageBox.Show($"El usuario: {nombreUsuario} a sido creado exitosamente");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else if  (logeo == true && superusuario == true ) 
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
                            command.CommandText = $"CREATE ROLE {nombreUsuario} WITH LOGIN SUPERUSER INHERIT CREATEDB  CREATEROLE  REPLICATION  PASSWORD '{contrasenia}';";

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    MessageBox.Show($"El usuario: {nombreUsuario} a sido creado exitosamente");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }


        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
