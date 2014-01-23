using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data;

namespace SistemaOrdenes
{
    class Proveedores
    {
        public int id;
        public String nombre;
        public String direccion;
        public String rfc;
        public String telefono;

        public Proveedores()
        {
            id = 0;
            nombre = "";
            direccion = "";
            rfc = "";
            telefono = "";
        }


        public void getProveedor(int _id, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Proveedores Where Id = "+_id+"";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                this.id = Convert.ToInt32(lectura["Id"].ToString());
                this.nombre = lectura["nombre"].ToString();
                this.direccion = lectura["direccion"].ToString();
                this.rfc = lectura["rfc"].ToString();
                this.telefono = lectura["telefono"].ToString();
            }
            
            con.Close();
        }

        public DataTable getProveedoresDG(OleDbConnection con)
        {
            con.Open();
            
            String consulta = "SELECT * FROM Proveedores";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        public DataTable getProveedoresByNameDG(String Nombre,OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT * FROM Proveedores Where nombre LIKE '%" + Nombre + "%'";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        public void updateProveedor(Proveedores updProveedor, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            

            //sql de busqueda y realizamos consulta            
            String consulta = "UPDATE Proveedores SET nombre = '" + updProveedor.nombre + "', direccion = '" + updProveedor.direccion + "', rfc = '" + updProveedor.rfc + "', telefono = '" + updProveedor.telefono + "' WHERE Id= " + updProveedor.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        

    }
}

