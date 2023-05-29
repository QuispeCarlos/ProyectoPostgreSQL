﻿using System;
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
                Form_Principal formPrincipal = new Form_Principal(instanciaBase);
                //formPrincipal.CargarArbol(instanciaBase);
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
