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
    public partial class Form_ConexionesRegistradas : Form
    {

        private List<Instancia> listaInstancias;
        Instancia instanciaB = new Instancia();


        public Form_ConexionesRegistradas(List<Instancia> listaInstancias)
        {
            this.listaInstancias = listaInstancias;
            InitializeComponent();
        }

        private void Form_ConexionesRegistradas_Load(object sender, EventArgs e)
        {
            CargarGridConexiones();
        }

        private void CargarGridConexiones()
        {
            dataGridView_conexionesRegistradas.DataSource = listaInstancias;

        }

        private void dataGridView_conexionesRegistradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // Obtener el índice de la fila seleccionada
            int rowIndex = e.RowIndex;

            // Obtener los valores de las celdas de la fila seleccionada
            DataGridViewRow selectedRow = dataGridView_conexionesRegistradas.Rows[rowIndex];

            string servidor = selectedRow.Cells[0].Value.ToString();
            string baseDatos = selectedRow.Cells[1].Value.ToString();
            string usuario = selectedRow.Cells[2].Value.ToString();
            string contrasenia = selectedRow.Cells[4].Value.ToString();
            string puerto = selectedRow.Cells[3].Value.ToString();

            // Asignar los valores a la intancia

            instanciaB.servidor = servidor;
            instanciaB.baseDatos = baseDatos;
            instanciaB.usuario = usuario;
            instanciaB.contrasenia = contrasenia;
            instanciaB.puerto = puerto;
            
        }

        private void button_usar_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            //form_Login.ShowDialog();
            form_Login.ConectarDesdeConexiones(instanciaB);
        }
    }
}
