using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public class Conexion
    {

        public NpgsqlConnection EstablecerConexion(Instancia instanciaBase)
        {

            NpgsqlConnection conexion = new NpgsqlConnection();


            String cadenaConexion = "server=" + instanciaBase.servidor + ";" + "port=" + instanciaBase.puerto + ";" + 
                                    "database=" + instanciaBase.baseDatos + ";" + "user id=" + instanciaBase.usuario + ";" + 
                                    "password=" + instanciaBase.contrasenia + ";";

            //host=localhost port=5432 dbname=postgres user=postgres password=xxxxxxx sslmode=prefer connect_timeout=10
            

            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Conexión exitosa");


                conexion.Close();

            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error: " + e.Message);
            }
            return conexion;
        }

    }
    
}
