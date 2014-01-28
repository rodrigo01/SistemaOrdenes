﻿using System;
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
        public String unidad;

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
                this.unidad = lectura["unidad"].ToString();
                
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

        public DataTable getDetallesOrden(int idorden, OleDbConnection con) 
        {
            con.Open();

            String consulta = "SELECT Detalles_Orden.cantidad as Cantidad, Detalles_Orden.descripcion as Descripcion, Detalles_Orden.punitario as [Precio], [punitario]*[cantidad] AS Costo FROM Detalles_Orden Where id_orden = " + idorden;
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable detallesorden = new DataTable();
            da.Fill(detallesorden);

            con.Close();
            return detallesorden;
        }

        public void insertDetalle(Detalles detalle, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "INSERT INTO Detalles_Orden (id_orden,cantidad,descripcion,punitario) VALUES (" + detalle.id_orden + "," + detalle.cantidad + ",'"+detalle.descripcion+"', "+detalle.punitario+" );";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();

        }

        public void deleteDetalles(int idorden, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "DELETE FROM Detalles_Orden WHERE id_orden = " + idorden + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();

        }

        public void updateOrden(Ordenes updOrden, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "UPDATE Ordenes SET id_proveedor = '" + updOrden.id_proveedor + "', orden = '" + updOrden.orden + "', fecha = '" + updOrden.fecha + "', departamento = '" + updOrden.departamento + "', vehiculo = '" + updOrden.vehiculo + "', almacen = '" + updOrden.almacen + "', parauso = '" + updOrden.parauso + "', maquina = '" + updOrden.maquina + "', obra = '" + updOrden.obra + "', unidad = '" + updOrden.unidad + "' WHERE Id= " + updOrden.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();

        }

        

        
    }
}
