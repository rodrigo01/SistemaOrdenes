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

        public int insertDepartamento(Departamentos departamento)
        {
            OleDbCommand comand = new OleDbCommand();
            int ID;
            string query2 = "Select @@Identity";
            //sql de busqueda y realizamos consulta            
            String consulta = "INSERT INTO Departamentos (nombre, encargado) VALUES ('" + departamento.nombre + "','" + departamento.encargado + "');";

            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            comand.CommandText = query2;
            ID = (int)comand.ExecuteScalar();
            con.Close();
            return ID;
        }

        public void updateDepartamento(Departamentos departamento)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "UPDATE Departamentos SET nombre = '" + departamento.nombre + "', encargado = '" + departamento.encargado + "'  WHERE Id= " + departamento.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        public void getDepartamento(int _id)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Departamentos Where Id = " + _id + "";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                this.id = Convert.ToInt32(lectura["Id"].ToString());
                this.nombre = lectura["nombre"].ToString();
                this.encargado = lectura["encargado"].ToString();
            }

            con.Close();
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

        public void deleteDepartamento(int id)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "Delete From Departamentos WHERE Id= " + id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

    }
}
