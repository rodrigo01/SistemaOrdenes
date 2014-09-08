using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaOrdenes
{
    class Ordenes
    {
        public int id;
        public String fecha;
        public int id_proveedor;
        public int orden = 0;
        public String departamento;
        public String vehiculo = "";
        public String almacen;
        public String solicito;
        public String reviso;
        public String autorizo;
        public String parauso;
        public String maquina = "";
        public String obra;
        public String unidad;
        public int iva;
        
        public Ordenes()
        {

        }

        public int insertOrden(Ordenes orden, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();
            int ID;
            string query2 = "Select @@Identity";
            //sql de busqueda y realizamos consulta            
            String consulta = "INSERT INTO Ordenes (id_proveedor,fecha,orden,departamento,vehiculo,almacen,parauso,maquina,obra,unidad,iva) VALUES ('" + orden.id_proveedor + "','" + orden.fecha + "', '" + orden.orden + "',  '" + orden.departamento + "', '" + orden.vehiculo + "', '" + orden.almacen + "', '" + orden.parauso + "', '" + orden.maquina + "', '" + orden.obra + "', '" + orden.unidad + "', " + orden.iva + ");";
            
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            comand.CommandText = query2;
            ID = (int)comand.ExecuteScalar();
            con.Close();
            return ID;
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
                this.iva = Convert.ToInt32(lectura["iva"].ToString());
                
            }

            con.Close();
        }

        //Obtener Ordenes y regresar en DataGrind
        public DataTable getOrdenesDG(OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT Ordenes.Id as [ID], Ordenes.orden as Orden,Proveedores.nombre as Nombre, Sum((([punitario]*[cantidad])*([Ordenes.iva]/100)) + ([punitario]*[cantidad]) ) AS Total, Ordenes.fecha as Fecha, Ordenes.solicito as Estado, Ordenes.departamento as Departamento, Ordenes.vehiculo as Vehiculo, Ordenes.maquina as Maquina FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Proveedores.nombre, Ordenes.orden, Ordenes.fecha, Ordenes.solicito, Ordenes.departamento, Ordenes.vehiculo, Ordenes.maquina;";
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

        public DataTable getDetallesOrdenRep(int idorden, OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT * FROM Detalles_Orden Where id_orden = " + idorden;
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable detallesorden = new DataTable();
            da.Fill(detallesorden);

            con.Close();
            return detallesorden;
        }

        public String getDetallesMoneda(int _id, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT * FROM Detalles_Orden Where id_orden = " + _id;
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            String monedaD = "";
            while (lectura.Read())
            {
                
                monedaD = lectura["moneda"].ToString();
                
            }

            con.Close();
            return monedaD;
        }

        public DataTable getOrdenRep(int idorden, OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT * FROM Ordenes Where Id = " + idorden;
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable detallesorden = new DataTable();
            da.Fill(detallesorden);

            con.Close();
            return detallesorden;
        }

        public DataTable getProveedoresRep(int idorden, OleDbConnection con)
        {
            con.Open();

            String consulta = "SELECT * FROM Proveedores Where Id = " + idorden;
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable detallesorden = new DataTable();
            da.Fill(detallesorden);

            con.Close();
            return detallesorden;
        }

        public static string replace(String input)
        {
            return Regex.Replace(input, "('|\")", "\\'");
        }

        public void insertDetalle(Detalles detalle, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta


            //detalle.descripcion = replace(detalle.descripcion);
            //String consulta = "INSERT INTO Detalles_Orden (id_orden,cantidad,descripcion,punitario) VALUES (" + detalle.id_orden + "," + detalle.cantidad + ",'"+detalle.descripcion+"', "+detalle.punitario+" );";
            String consulta = "INSERT INTO Detalles_Orden (id_orden,cantidad,descripcion,punitario,iva,moneda) VALUES (" + detalle.id_orden + "," + detalle.cantidad + ",@desco, " + detalle.punitario + ",16,@moneda);";
            comand.Parameters.AddWithValue("@desco", detalle.descripcion);
            comand.Parameters.AddWithValue("@moneda", detalle.moneda);
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
            String consulta = "UPDATE Ordenes SET id_proveedor = '" + updOrden.id_proveedor + "', orden = '" + updOrden.orden + "', fecha = '" + updOrden.fecha + "', departamento = '" + updOrden.departamento + "', vehiculo = '" + updOrden.vehiculo + "', almacen = '" + updOrden.almacen + "', parauso = '" + updOrden.parauso + "', maquina = '" + updOrden.maquina + "', obra = '" + updOrden.obra + "', unidad = '" + updOrden.unidad + "' , iva = '" + updOrden.iva + "' WHERE Id= " + updOrden.id + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();

        }

        public void setCancel(int idcancel, OleDbConnection con)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta            
            String consulta = "UPDATE Ordenes SET solicito = 'cancelado' WHERE Id= " + idcancel + ";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }


        // Busqueda de ordenes por datos

        public DataTable getOrdenesDGCampo(String campo, String valor, OleDbConnection con)
        {
            con.Open();

            String whereclause = "";
            String consulta = "";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            
            // Para Ordenes
            if (campo.CompareTo("Orden") == 0) 
            {
                if (valor.CompareTo("") == 0){}
                else{whereclause = "HAVING (((Ordenes.orden) = "+valor+"))";
                consulta = "SELECT Ordenes.Id as [ID], Ordenes.orden as Orden,Proveedores.nombre as Nombre, Sum([punitario]*[cantidad]) AS Total, Ordenes.fecha as Fecha, Ordenes.solicito as Estado, Ordenes.departamento as Departamento, Ordenes.vehiculo as Vehiculo, Ordenes.maquina as Maquina FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Proveedores.nombre, Ordenes.orden, Ordenes.fecha, Ordenes.solicito, Ordenes.departamento, Ordenes.vehiculo, Ordenes.maquina " + whereclause + ";";
                comand.CommandText = consulta;
                } 
            }

            // Proveedor
            if (campo.CompareTo("Proveedor") == 0)
            {
                if (valor.CompareTo("") == 0) { }
                else { whereclause = "HAVING (((Proveedores.nombre) Like \"*"+valor+"*\")) ";
                consulta = "SELECT Ordenes.Id AS ID, Ordenes.orden AS Orden, Proveedores.nombre AS Nombre, Sum([punitario]*[cantidad]) AS Total, Ordenes.fecha AS Fecha, Ordenes.solicito as Estado, Ordenes.departamento as Departamento, Ordenes.vehiculo as Vehiculo, Ordenes.maquina as Maquina FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Ordenes.orden, Proveedores.nombre, Ordenes.fecha, Ordenes.solicito, Ordenes.departamento, Ordenes.vehiculo, Ordenes.maquina HAVING (((Proveedores.nombre) like \"%" + valor + "%\"));";
                comand.CommandText = consulta;
                }
            }

            // 
            if (campo.CompareTo("Departamento") == 0)
            {
                if (valor.CompareTo("") == 0) { }
                else
                {
                    //whereclause = "HAVING (((Proveedores.nombre) Like \"*" + valor + "*\")) ";
                    consulta = "SELECT Ordenes.Id AS ID, Ordenes.orden AS Orden, Proveedores.nombre AS Nombre, Sum([punitario]*[cantidad]) AS Total, Ordenes.fecha AS Fecha, Ordenes.solicito as Estado, Ordenes.departamento as Departamento, Ordenes.vehiculo as Vehiculo, Ordenes.maquina as Maquina FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Ordenes.orden, Proveedores.nombre, Ordenes.fecha, Ordenes.solicito, Ordenes.departamento, Ordenes.vehiculo, Ordenes.maquina HAVING (((Proveedores.nombre) like \"%" + valor + "%\"));";
                    comand.CommandText = consulta;
                }
            }

            if (campo.CompareTo("Vehiculo") == 0)
            {
                if (valor.CompareTo("") == 0) { }
                else
                {
                    //whereclause = "HAVING (((Proveedores.nombre) Like \"*" + valor + "*\")) ";
                    consulta = "SELECT Ordenes.Id AS ID, Ordenes.orden AS Orden, Proveedores.nombre AS Nombre, Sum([punitario]*[cantidad]) AS Total, Ordenes.fecha AS Fecha, Ordenes.solicito as Estado, Ordenes.departamento as Departamento, Ordenes.vehiculo as Vehiculo, Ordenes.maquina as Maquina FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Ordenes.orden, Proveedores.nombre, Ordenes.fecha, Ordenes.vehiculo, Ordenes.solicito, Ordenes.departamento, Ordenes.vehiculo, Ordenes.maquina HAVING (((Ordenes.vehiculo) like \"%" + valor + "%\");";
                    comand.CommandText = consulta;
                }
            }

            if (campo.CompareTo("Almacen") == 0)
            {
                if (valor.CompareTo("") == 0) { }
                else
                {
                    //whereclause = "HAVING (((Proveedores.nombre) Like \"*" + valor + "*\")) ";
                    consulta = "SELECT Ordenes.Id AS ID, Ordenes.orden AS Orden, Proveedores.nombre AS Nombre, Sum([punitario]*[cantidad]) AS Total, Ordenes.fecha AS Fecha, Ordenes.solicito as Estado, Ordenes.departamento as Departamento, Ordenes.vehiculo as Vehiculo, Ordenes.maquina as Maquina FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Ordenes.orden, Proveedores.nombre, Ordenes.fecha, Ordenes.almacen, Ordenes.solicito, Ordenes.departamento, Ordenes.vehiculo, Ordenes.maquina HAVING (((Ordenes.almacen) like \"%" + valor + "%\"));";
                    comand.CommandText = consulta;
                }
            }

            if (campo.CompareTo("Maquina") == 0)
            {
                if (valor.CompareTo("") == 0) { }
                else
                {
                    //whereclause = "HAVING (((Proveedores.nombre) Like \"*" + valor + "*\")) ";
                    consulta = "SELECT Ordenes.Id AS ID, Ordenes.orden AS Orden, Proveedores.nombre AS Nombre, Sum([punitario]*[cantidad]) AS Total, Ordenes.fecha AS Fecha, Ordenes.solicito as Estado, Ordenes.departamento as Departamento, Ordenes.vehiculo as Vehiculo, Ordenes.maquina as Maquina FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.Id, Ordenes.orden, Proveedores.nombre, Ordenes.fecha, Ordenes.maquina, Ordenes.solicito, Ordenes.departamento, Ordenes.vehiculo, Ordenes.maquina HAVING (((Ordenes.maquina) like \"%" + valor + "%\"));";
                    comand.CommandText = consulta;
                }
            }

            
            
            //MessageBox.Show("SQL: "+consulta);
            
            

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        public DataTable getOrdenesDetallesProveedorDG(int idprov, OleDbConnection con)
        {
            

            con.Open();

            String consulta = "SELECT Ordenes.orden AS Orden, Ordenes.fecha, Ordenes.departamento, Ordenes.parauso, Ordenes.vehiculo, Ordenes.maquina, Sum((([punitario]*[cantidad])*([Ordenes.iva]/100))+([punitario]*[cantidad])) AS Total, Ordenes.fecha AS Fecha FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Proveedores.Id, Ordenes.Id, Ordenes.orden, Ordenes.fecha, Ordenes.departamento, Ordenes.parauso, Ordenes.vehiculo, Ordenes.maquina, Proveedores.nombre, Ordenes.fecha HAVING (((Proveedores.Id)=" + idprov + "));";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;

        }

        public DataTable getOrdenesDetallesProveedorVehiculo(int idprov,String vehiculo, OleDbConnection con)
        {


            con.Open();
             String consulta = "" ;
             if (idprov == 0)
             {
                 consulta = "SELECT Proveedores.nombre as Proveedor, Ordenes.orden AS Orden, Ordenes.fecha, Ordenes.departamento, Ordenes.parauso, Ordenes.vehiculo, Ordenes.maquina, Sum((([punitario]*[cantidad])*([Ordenes.iva]/100))+([punitario]*[cantidad])) AS Total, Ordenes.fecha AS Fecha FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.orden, Ordenes.fecha, Ordenes.departamento, Ordenes.parauso, Ordenes.vehiculo, Ordenes.maquina, Ordenes.fecha, Proveedores.Id, Ordenes.Id, Proveedores.nombre HAVING (((Ordenes.vehiculo)=\"" + vehiculo + "\"));";

             }
             else
             {
                 consulta = "SELECT Ordenes.orden AS Orden, Ordenes.fecha, Ordenes.departamento, Ordenes.parauso, Ordenes.vehiculo, Ordenes.maquina, Sum((([punitario]*[cantidad])*([Ordenes.iva]/100))+([punitario]*[cantidad])) AS Total, Ordenes.fecha AS Fecha FROM Proveedores INNER JOIN (Ordenes INNER JOIN Detalles_Orden ON Ordenes.Id = Detalles_Orden.id_orden) ON Proveedores.Id = Ordenes.id_proveedor GROUP BY Ordenes.orden, Ordenes.fecha, Ordenes.departamento, Ordenes.parauso, Ordenes.vehiculo, Ordenes.maquina, Ordenes.fecha, Proveedores.Id, Ordenes.Id, Proveedores.nombre HAVING (((Ordenes.vehiculo)=\"" + vehiculo + "\") AND ((Proveedores.Id)=" + idprov + "));";
             }
             OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;

        }

        public int getLastNoOrden(OleDbConnection con){
            

            OleDbCommand comand = new OleDbCommand();
            OleDbDataReader lectura; //lecto de datos
            comand.Connection = con; //conectamos
            con.Open();

            //sql de busqueda y realizamos consulta            
            String consulta = "SELECT TOP 1 Ordenes.Id, Ordenes.orden FROM Ordenes ORDER BY Ordenes.Id DESC;";
            comand.CommandText = consulta;
            lectura = comand.ExecuteReader();

            while (lectura.Read())
            {
                this.id = Convert.ToInt32(lectura["Id"].ToString());    
                this.orden = Convert.ToInt32(lectura["orden"].ToString());          
            }

            con.Close();
            return this.orden;
        }

        

        
    }
}
