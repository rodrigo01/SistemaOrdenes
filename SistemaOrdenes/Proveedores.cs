using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace SistemaOrdenes
{
    class Proveedores
    {
        public int id;
        public String nombre;
        public String direccion;
        public String rfc;
        public String telefono;
        public String contacto;
        public String correo;
        public String extension;

        public Proveedores()
        {
            id = 0;
            nombre = "";
            direccion = "";
            rfc = "";
            telefono = "";
            contacto = "";
            correo = "";
            extension = "";
        }


        public void getProveedor(int _id, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Proveedores Where Id = " + _id + " ORDER BY nombre ASC;";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                this.id = Convert.ToInt32(lectura["Id"].ToString());
                this.nombre = lectura["nombre"].ToString();
                this.direccion = lectura["direccion"].ToString();
                this.rfc = lectura["rfc"].ToString();
                this.telefono = lectura["telefono"].ToString();
                this.contacto = lectura["contacto"].ToString();
                this.correo = lectura["correo"].ToString();
                this.extension = lectura["extension"].ToString();
            }
            
            con.Close();
        }

        public void getProveedorByName(string name, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Proveedores Where nombre LIKE '" + name + "'";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                this.id = Convert.ToInt32(lectura["Id"].ToString());
                this.nombre = lectura["nombre"].ToString();
                this.direccion = lectura["direccion"].ToString();
                this.rfc = lectura["rfc"].ToString();
                this.telefono = lectura["telefono"].ToString();
                this.contacto = lectura["contacto"].ToString();
                this.correo = lectura["correo"].ToString();
                this.extension = lectura["extension"].ToString();
            }

            con.Close();
        }

        public DataTable getProveedoresDG(OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT * FROM Proveedores ORDER BY nombre ASC;";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();    
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        public AutoCompleteStringCollection getProveedoresAutoComplete(OleDbConnection con)
        {
            
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection(); // listado de nombres
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Proveedores ORDER BY nombre ASC;";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                namesCollection.Add(lectura["nombre"].ToString());
            }

            con.Close();
            return namesCollection;
        }

        public DataTable getProveedoresByNameDG(String Nombre,OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT * FROM Proveedores Where nombre LIKE '%" + Nombre + "%'" + " ORDER BY nombre ASC;";
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
            
            //sql de busqueda y realizamos consulta            
            String consulta = "UPDATE Proveedores SET nombre = '" + updProveedor.nombre + "', direccion = '" + updProveedor.direccion + "', rfc = '" + updProveedor.rfc + "', telefono = '" + updProveedor.telefono + "', contacto = '" + updProveedor.contacto + "', correo = '" + updProveedor.correo + "', extension = '" + updProveedor.extension + "' WHERE Id= " + updProveedor.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        public void deleteProveedor(int id, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "Delete From Proveedores WHERE Id= " + id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        

    }
}

