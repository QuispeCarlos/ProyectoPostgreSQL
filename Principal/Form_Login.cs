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
    
    public partial class Form_Login : Form
    {

        Instancia instanciaBase = new Instancia();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button_ingresar_Click(object sender, EventArgs e)
        {
            Conectar();
            
        }


        private void Conectar()
        {
            instanciaBase.servidor = textBox_servidor.Text;
            instanciaBase.baseDatos = textBox_baseDatos.Text;
            instanciaBase.usuario = textBox_uasuario.Text;
            instanciaBase.contrasenia = textBox_contrasenia.Text;
            instanciaBase.puerto = textBox_puerto.Text;


            Conexion conexion = new Conexion();
            /*
           conexion.EstablecerConexion(instanciaBase.servidor, instanciaBase.baseDatos, instanciaBase.usuario, 
               instanciaBase.contrasenia, instanciaBase.puerto);
            */

            conexion.EstablecerConexion(instanciaBase);

            if (conexion != null)
            {

                DialogResult resultado = MessageBox.Show("¿Deseas guardar la conexión?", "Guardar conexión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string baseUsuarios = "Usuarios";
                    string nombreUsuario = textBox_uasuario.Text;
                    string contraseniaUsuario = textBox_contrasenia.Text;


                    try
                    {

                        string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={baseUsuarios}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                        using (NpgsqlConnection connection = new NpgsqlConnection(str))
                        {
                            connection.Open();

                            using (NpgsqlCommand command = new NpgsqlCommand())
                            {
                                command.Connection = connection;
                                command.CommandText = $"insert into usuario values('{nombreUsuario}', '{contraseniaUsuario}');";

                                command.ExecuteNonQuery();

                            }
                            connection.Close();
                        }

                        MessageBox.Show($"El usuario '{nombreUsuario}' a sido guardado exitosamente");


                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }


                Form_Principal formPrincipal = new Form_Principal(instanciaBase);
                formPrincipal.ShowDialog();
            }

        }


       





        private void button_cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void CerrarVentana()
        {
            this.Close();
        }



    }
}
