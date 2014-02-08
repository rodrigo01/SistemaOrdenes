using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace SistemaOrdenes
{
    class Vehiculos
    {
        public int id;
        public String noecon;
        public String marca;
        public String linea;
        public String tipo;
        public String modelo;
        public String clase;
        public String usuario;
        public OleDbConnection con;

        public Vehiculos()
        {
            id = 0;
            noecon = "";
            marca = "";
            linea = "";
            tipo = "";
            modelo = "";
            clase = "";
            usuario = "";
        }

        public
    }
}
