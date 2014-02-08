using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

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

        public int insertVehiculo(Vehiculos vehiculo)
        {
            OleDbCommand comand = new OleDbCommand();
            int ID;
            string query2 = "Select @@Identity";
            //sql de busqueda y realizamos consulta            
            String consulta = "INSERT INTO Vehiculos (noecon, marca, linea, tipo, modelo, clase, usuario) VALUES ('" + vehiculo.noecon + "','" + vehiculo.marca + "','" + vehiculo.linea + "','" + vehiculo.tipo + "','" + vehiculo.modelo + "','" + vehiculo.clase + "','" + vehiculo.usuario + "');";

            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            comand.CommandText = query2;
            ID = (int)comand.ExecuteScalar();
            con.Close();
            return ID;
        }

        public void updateVehiculo(Vehiculos vehiculo)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "UPDATE Vehiculos SET noecon = '" + vehiculo.noecon + "', marca = '" + vehiculo.marca + "', linea = '" + vehiculo.linea + "', tipo = '" + vehiculo.tipo + "', modelo = '" + vehiculo.modelo + "', clase = '" + vehiculo.clase + "', usuario = '" + vehiculo.usuario + "'  WHERE Id= " + vehiculo.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        public void getVehiculo(int _id)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Vehiculos Where Id = " + _id + "";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                this.id = Convert.ToInt32(lectura["Id"].ToString());
                this.noecon = lectura["noecon"].ToString();
                this.marca = lectura["marca"].ToString();
                this.linea = lectura["linea"].ToString();
                this.tipo = lectura["tipo"].ToString();
                this.modelo = lectura["modelo"].ToString();
                this.clase = lectura["clase"].ToString();
                this.usuario = lectura["usuario"].ToString();
            }

            con.Close();
        }

        public DataTable getVehiculosDG()
        {
            con.Open();

            String consulta = "SELECT Id as ID, noecon as NoEconomico, marca as Marca, tipo as Tipo FROM Vehiculos";
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
