using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    public  class Instancia
    {
        
        public string servidor { get; set; }
        public string baseDatos { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string puerto { get; set; }

        public Instancia(string servidor, string baseDatos, string usuario, string contrasenia, string puerto)
        {
            this.servidor = servidor;
            this.baseDatos = baseDatos;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.puerto = puerto;
        }
        public Instancia()
        {

        }


    }
}
