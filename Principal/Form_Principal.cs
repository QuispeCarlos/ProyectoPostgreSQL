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
    public partial class Form_Principal : Form
    {


        private Instancia instanciaBase;

        public Form_Principal(Instancia instanciaBase)
        {
            InitializeComponent();

            this.instanciaBase = instanciaBase;
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            CargarComboBox_databases();
            CargarComboBox_groupRoles();
            CargarComboBox_tablespaces();
            CargarLabelBaseActual();
            CargarLabelUsuarioActual();
            CargarArbolBusqueda();
        }

        

        private void CargarLabelBaseActual()
        {
            label_BD.Text = instanciaBase.baseDatos;
        }

        private void CargarLabelUsuarioActual()
        {
            label_usuario.Text = instanciaBase.usuario;
        }
        private void CargarComboBox_databases()
        {
            //string str = "server=localhost; port=5432; database=postgres; user id=postgres;password=sa123;";
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
                comboBox_databases.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void CargarComboBox_groupRoles()
        {
            string str = "server=localhost; port=5432; database=postgres; user id=postgres;password=sa123;";
            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = str;
            cn.Open();


            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "SELECT rolname FROM pg_roles;";
            cmd.Connection = cn;

            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_groupRoles.Items.Add(dr[0]);
            }
            dr.Close();
        }


        private void CargarComboBox_tablespaces()
        {
            string str = "server=localhost; port=5432; database=postgres; user id=postgres;password=sa123;";
            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = str;
            cn.Open();


            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "SELECT spcname FROM pg_tablespace; ";
            cmd.Connection = cn;

            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_tablespaces.Items.Add(dr[0]);
            }
            dr.Close();
        }


        private void CargarArbolBusqueda()
        {
            /*
            // Crear el nodo raíz
            TreeNode rootNode = treeView_buscador.Nodes.Add("Server");

            // Establecer la cadena de conexión a la base de datos PostgreSQL
            string cadenaConexion = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database= {instanciaBase.baseDatos}; " +
                                $"user id= {instanciaBase.usuario}; password= {instanciaBase.contrasenia};";

            // Crear la conexión
            NpgsqlConnection connection = new NpgsqlConnection(cadenaConexion);

            try
            {
                // Abrir la conexión
                connection.Open();

                // Agregar el nodo "Databases"
                TreeNode databasesNode = rootNode.Nodes.Add("Databases");

                // Obtener la lista de bases de datos
                DataTable databases = connection.GetSchema("Databases");

                // Recorrer las bases de datos
                foreach (DataRow row in databases.Rows)
                {
                    string databaseName = row["database_name"].ToString();
                    TreeNode databaseNode = databasesNode.Nodes.Add(databaseName);

                    try
                    {
                        // Cambiar la base de datos en la cadena de conexión
                        connection.ChangeDatabase(databaseName);

                        // Obtener la lista de tablas de la base de datos actual
                        DataTable tables = connection.GetSchema("Tables");

                        // Agregar el nodo "Tables" para la base de datos actual
                        TreeNode tablesNode = databaseNode.Nodes.Add("Tables");

                        // Recorrer las tablas y agregar nodos al árbol
                        foreach (DataRow tableRow in tables.Rows)
                        {
                            string tableName = tableRow["TABLE_NAME"].ToString();
                            tablesNode.Nodes.Add(tableName);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción al obtener las tablas de la base de datos actual
                        MessageBox.Show($"Error al obtener las tablas de la base de datos {databaseName}: {ex.Message}");
                    }
                }

                // Agregar el nodo "Login/Group Roles"
                rootNode.Nodes.Add("Login/Group Roles");

                // Agregar el nodo "Tablespaces"
                rootNode.Nodes.Add("Tablespaces");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción al obtener las bases de datos
                MessageBox.Show("Error al obtener las bases de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }

            // Expandir el nodo raíz y los nodos "Databases", "Login/Group Roles" y "Tablespaces"
            rootNode.Expand();
            rootNode.Nodes["Databases"].Expand();
            rootNode.Nodes["Login/Group Roles"].Expand();
            rootNode.Nodes["Tablespaces"].Expand();
        
    
        }

        */


            // Establecer la cadena de conexión a la base de datos PostgreSQL
            string cadenaConexion = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database= {instanciaBase.baseDatos}; " +
                                    $"user id= {instanciaBase.usuario}; password= {instanciaBase.contrasenia};";

            // Crear la conexión
            NpgsqlConnection connection = new NpgsqlConnection(cadenaConexion);

            try
            {
                // Abrir la conexión
                connection.Open();

                // Obtener la lista de bases de datos
                DataTable databases = connection.GetSchema("Databases");

                // Recorrer las bases de datos
                foreach (DataRow row in databases.Rows)
                {
                    string databaseName = row["database_name"].ToString();

                    // Omitir las bases de datos "template1" y "template0"
                    if (databaseName != "template1" && databaseName != "template0")
                    {
                        TreeNode databaseNode = treeView_buscador.Nodes.Add(databaseName);

                        try
                        {
                            // Cambiar la base de datos en la cadena de conexión
                            connection.ChangeDatabase(databaseName);

                            // Obtener la lista de tablas de la base de datos actual
                            DataTable tables = connection.GetSchema("Tables");

                            // Recorrer las tablas y agregar nodos al árbol
                            foreach (DataRow tableRow in tables.Rows)
                            {
                                string tableName = tableRow["TABLE_NAME"].ToString();
                                TreeNode tableNode = databaseNode.Nodes.Add(tableName);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Manejar cualquier excepción al obtener las tablas de la base de datos actual
                            MessageBox.Show($"Error al obtener las tablas de la base de datos {databaseName}: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción al obtener las bases de datos
                MessageBox.Show("Error al obtener las bases de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
        }




        private void button_ejecutar_Click(object sender, EventArgs e)
        {
            /*
            Conexion conexion = new Conexion();
            conexion.EstablecerConexion(instanciaBase);
            */

            string cadenaConexion = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; " +
                                     $"user id={instanciaBase.usuario};password={instanciaBase.contrasenia};";
            
            string query = textBox_query.Text;

            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, conexion))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView_DataOutput.DataSource = dataTable;
                        }
                    }
                    textBox_dataOutput.Text = "La ejecución ha sido exitosa";
                }
                catch (Exception ex)
                {
                    textBox_dataOutput.Text = ex.Message;
                }
                finally
                {
                    conexion.Close();
                }
            }


        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            CrearBaseDeDatos();
        }

        private void CrearBaseDeDatos()
        {
            Form_CrearBaseDatos formBaseDatos = new Form_CrearBaseDatos(instanciaBase);
            formBaseDatos.ShowDialog();
        }

        private void button_refrescar_Click(object sender, EventArgs e)
        {
            ActualizarRegistroBases();
            ActualizarRegistroUsuarios();
        }

        

        private void ActualizarRegistroBases()
        {
            try
            {
                string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                using (NpgsqlConnection connection = new NpgsqlConnection(str))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
 
                        comboBox_databases.Items.Clear();
                        CargarComboBox_databases();

                    }
                    connection.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void ActualizarRegistroUsuarios()
        {
            try
            {
                string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                using (NpgsqlConnection connection = new NpgsqlConnection(str))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {

                        comboBox_groupRoles.Items.Clear();
                        CargarComboBox_groupRoles();

                    }
                    connection.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }




        private void button_eliminar_Click(object sender, EventArgs e)
        {
            EliminarBaseDatos();
        }

        private void EliminarBaseDatos()
        {
            string baseAEliminar = comboBox_databases.Text;

            DialogResult dr = MessageBox.Show($"Estas seguro de eliminar las base de datos: {baseAEliminar} ?", "Borrar la base?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {

                    string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; " +
                                $"user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                    using (NpgsqlConnection connection = new NpgsqlConnection(str))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = $"DROP DATABASE {baseAEliminar};";

                            command.ExecuteNonQuery();

                        }
                        connection.Close();
                    }

                    MessageBox.Show($"La base de datos: {baseAEliminar} a sido eliminada exitosamente");
                    ActualizarRegistroBases();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show($"La base de datos: {baseAEliminar} no ha sido eliminada");
            }

        }

        private void tablasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_CrearTabla crearTabla = new Form_CrearTabla(instanciaBase);
            crearTabla.Show();
        }

        private void columnasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_CrearColumna crearColumna = new Form_CrearColumna(instanciaBase);
            crearColumna.Show();
        }

        private void verTodasLasFilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // completar
        }

        private void triggersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cadenaConexion = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; " +
                                     $"user id={instanciaBase.usuario};password={instanciaBase.contrasenia};";

            string query = $"SELECT trigger_name FROM information_schema.triggers WHERE trigger_schema = '{instanciaBase.baseDatos}'; ";

            using (NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, conexion))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView_DataOutput.DataSource = dataTable;
                        }
                    }
                    textBox_dataOutput.Text = "La ejecución ha sido exitosa";
                }
                catch (Exception ex)
                {
                    textBox_dataOutput.Text = ex.Message;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button_crearUsuariosGrupos_Click(object sender, EventArgs e)
        {
            CrarUsuario();
            
        }

        private void CrarUsuario()
        {
            Form_CrearUsuarios formCrearUsuario = new Form_CrearUsuarios(instanciaBase);
            formCrearUsuario.ShowDialog();
        }

        private void button_eliminarUsuariosGrupos_Click(object sender, EventArgs e)
        {
            EliminarUsusrio();
        }

        private void EliminarUsusrio()
        {
            string nombreUsuario = comboBox_groupRoles.Text;

            try
            {
                string str = $"server={instanciaBase.servidor}; port={instanciaBase.puerto}; database={instanciaBase.baseDatos}; user id={instanciaBase.usuario}; password={instanciaBase.contrasenia};";

                using (NpgsqlConnection connection = new NpgsqlConnection(str))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"DROP ROLE {nombreUsuario};";

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    ActualizarRegistroUsuarios();
                }
                MessageBox.Show($"El usuario: {nombreUsuario} a sido eliminado exitosamente");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button_permisos_Click(object sender, EventArgs e)
        {
            OtorgarPermisos();
        }

        private void OtorgarPermisos()
        {
            Form_Permisos formPermisos = new Form_Permisos(instanciaBase);
            formPermisos.ShowDialog();
        }
    }
}
