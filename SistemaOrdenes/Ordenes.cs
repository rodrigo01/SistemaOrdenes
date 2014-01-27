using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace SistemaOrdenes
{
    class Ordenes
    {
        public int id;
        public String fecha;
        public int id_proveedor;
        public int orden;
        public String departamento;
        public String vehiculo;
        public String almacen;
        public String solicito;
        public String reviso;
        public String autorizo;
        public String parauso;
        public String maquina;
        public String obra;

        public Ordenes()
        {

        }


        // obtener ordeb por id
        public void getOrden(int _id, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Ordenes Where Id = " + _id + "";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                this.id = Convert.ToInt32(lectura["Id"].ToString());
                this.fecha = lectura["fecha"].ToString();
                this.id_proveedor = Convert.ToInt32(lectura["id_proveedor"].ToString());
                this.orden = Convert.ToInt32(lectura["orden"].ToString());
                this.departamento = lectura["departamento"].ToString();
                this.vehiculo = lectura["vehiculo"].ToString();
                this.almacen = lectura["almacen"].ToString();
                this.solicito = lectura["solicito"].ToString();
                this.reviso = lectura["reviso"].ToString();
                this.autorizo = lectura["autorizo"].ToString();
                this.parauso= lectura["parauso"].ToString();
                this.maquina = lectura["maquina"].ToString();
                this.obra = lectura["obra"].ToString();
                
            }

            con.Close();
        }

        //Obtener Ordenes y regresar en DataGrind
        public DataTable getOrdenesDG(OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT Ordenes.Id as [ID], Ordenes.orden as Orden,Proveedores.nombre as Nombre, Sum([punitario]*[cantidad]) AS Total, Ordenes.fecha as Fecha FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Proveedores.nombre, Ordenes.orden, Ordenes.fecha;";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        //Obtener Ordenes por Nombre en 
        /*
        public DataTable getProveedoresByNameDG(String Nombre, OleDbConnection con)
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
        }*/

        //Actualizar Orden
        public void updateOrden(Proveedores updProveedor, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "UPDATE Proveedores SET nombre = '" + updProveedor.nombre + "', direccion = '" + updProveedor.direccion + "', rfc = '" + updProveedor.rfc + "', telefono = '" + updProveedor.telefono + "' WHERE Id= " + updProveedor.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

        public void insertOrden(Proveedores updProveedor, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de insertar y realizamos consulta            
            String consulta = "UPDATE Proveedores SET nombre = '" + updProveedor.nombre + "', direccion = '" + updProveedor.direccion + "', rfc = '" + updProveedor.rfc + "', telefono = '" + updProveedor.telefono + "' WHERE Id= " + updProveedor.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }
    }
}
