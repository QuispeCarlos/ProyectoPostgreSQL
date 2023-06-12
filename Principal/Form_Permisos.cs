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
    public partial class Form_Permisos : Form
    {
        private Instancia instanciaBase;

        public Form_Permisos(Instancia instanciaBase)
        {
            this.instanciaBase = instanciaBase;
            InitializeComponent();
        }

        private void Form_Permisos_Load(object sender, EventArgs e)
        {
            CargarComboBases();
            CargarComboUsuarios();
            CargarComboTablas();
        }

        private void CargarComboBases()
        {
            string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; " +
                        $"user id={instanciaBase.usuario};password={instanciaBase.contrasenia};";

            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = str;
            cn.Open();


            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "SELECT datname FROM pg_database WHERE datistemplate = false;";
            cmd.Connection = cn;

            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_base.Items.Add(dr[0]);
            }
            dr.Close();
        }


        private void CargarComboUsuarios()
        {
            string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";
            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = str;
            cn.Open();


            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "SELECT rolname FROM pg_roles;";
            cmd.Connection = cn;

            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_usuario.Items.Add(dr[0]);
            }
            dr.Close();
        }

 
        private void CargarComboTablas()
        {
            string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";
            
            string consulta = $"SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_catalog = '{instanciaBase.baseDatos}'; ";

            using (NpgsqlConnection connection = new NpgsqlConnection(str))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(consulta, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox_tabla.Items.Clear();

                        while (reader.Read())
                        {
                            string nombreTabla = reader.GetString(0);
                            comboBox_tabla.Items.Add(nombreTabla);
                        }
                    }
                }
                connection.Close();
            }
        }


        // Permiso para Base
        private void button_guardarBase_Click(object sender, EventArgs e)
        {
            PermisosParaBase();
        }

        private void PermisosParaBase()
        {
            string nombreBase = comboBox_base.Text;
            string nombreUsuario = comboBox_usuario.Text;

            bool bAll = checkBox_baseAll.Checked;
            bool bCreate = checkBox_baseCreate.Checked;
            bool bTemporary = checkBox_baseTemporary.Checked;
            bool bConnect = checkBox_baseConnect.Checked;


            if (bAll == true)
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
                            command.CommandText = $"GRANT CREATE ALL ON DATABASE {nombreBase} TO {nombreUsuario}";

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    MessageBox.Show($"El permiso a sido creado exitosamente");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }



            if (bCreate == true)
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
                            command.CommandText = $"GRANT CREATE ON DATABASE {nombreBase} TO {nombreUsuario};";

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    MessageBox.Show($"El permiso a sido creado exitosamente");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (bTemporary == true)
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
                            command.CommandText = $"GRANT TEMPORARY ON DATABASE {nombreBase} TO {nombreUsuario};";

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    MessageBox.Show($"El permiso a sido creado exitosamente");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (bConnect == true)
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
                            command.CommandText = $"GRANT CONNECT ON DATABASE {nombreBase} TO {nombreUsuario};";

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    MessageBox.Show($"El permiso a sido creado exitosamente");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


            }
        }

    }
}
