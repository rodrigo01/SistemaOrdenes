using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace SistemaOrdenes
{
    class Departamentos
    {
        public int id;
        public String nombre;
        public String encargado;
        public OleDbConnection con;

        public Departamentos()
        {
            id = 0;
            nombre = "";
            encargado = "";
            
        }

        public DataTable getDepartamentosDG()
        {
            con.Open();

            String consulta = "SELECT Id as ID, nombre as Nombre, encargado as Encargado FROM Departamentos";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

    }
}
