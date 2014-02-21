using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace SistemaOrdenes
{
    class Vehiculos
    {
        public int id;
        public String noecon;
        public String marca;
        public String linea;
        public String tipo;
        public int modelo;
        public String clase;
        public String usuario;
        public String placas;
        public String numserie;
        public String motor;
        public String llantas;
        public String bajafecha;
        public String color;
        public String departamento;



        public OleDbConnection con;

        public Vehiculos()
        {
            id = 0;
            noecon = "";
            marca = "";
            linea = "";
            tipo = "";
            modelo = 0;
            clase = "";
            usuario = "";
            placas = "";
            numserie = "";
            motor = "";
            llantas = "";
            bajafecha = "";
            color = "";
            departamento = "";
        }

        public int insertVehiculo(Vehiculos vehiculo)
        {
            OleDbCommand comand = new OleDbCommand();
            int ID;
            string query2 = "Select @@Identity";
            //sql de busqueda y realizamos consulta            
            String consulta = "INSERT INTO Vehiculos (noecon, marca, linea, tipo, modelo, clase, usuario, placas, numserie, motor, llantas, color, departamento) VALUES ('" + vehiculo.noecon + "','" + vehiculo.marca + "','" + vehiculo.linea + "','" + vehiculo.tipo + "'," + vehiculo.modelo + ",'" + vehiculo.clase + "','" + vehiculo.usuario + "','" + vehiculo.placas + "','" + vehiculo.numserie + "','" + vehiculo.motor + "','" + vehiculo.llantas + "','" + vehiculo.color + "','" + vehiculo.departamento + "');";

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
            //String consulta = "UPDATE Vehiculos SET noecon = \"" + vehiculo.noecon + "\", marca = \"" + vehiculo.marca + "\", linea = \"" + vehiculo.linea + "\", tipo = \"" + vehiculo.tipo + "\", clase = \"" + vehiculo.clase + "', usuario = \"" + vehiculo.usuario + "\", modelo = \"" + vehiculo.modelo + "\" WHERE Id = " + vehiculo.id + ";";

            String consulta = "UPDATE Vehiculos SET Vehiculos.noecon = @noecon, Vehiculos.marca = @marca, Vehiculos.linea = @linea, Vehiculos.tipo = @tipo, Vehiculos.clase = @clase, Vehiculos.usuario = @usuario, Vehiculos.modelo = @modelo , Vehiculos.placas = @placas, Vehiculos.numserie = @numserie, Vehiculos.motor = @motor, Vehiculos.llantas = @llantas, Vehiculos.bajafecha = @bajafecha , Vehiculos.color = @color , Vehiculos.departamento = @departamento WHERE Vehiculos.[Id] = " + vehiculo.id + ";";
            comand.Parameters.Add("@noecon", OleDbType.VarChar, 50).Value = vehiculo.noecon;
            comand.Parameters.Add("@marca", OleDbType.VarChar, 50).Value = vehiculo.marca;
            comand.Parameters.Add("@linea", OleDbType.VarChar, 50).Value = vehiculo.linea;
            comand.Parameters.Add("@tipo", OleDbType.VarChar, 50).Value = vehiculo.tipo;
            comand.Parameters.Add("@clase", OleDbType.VarChar, 50).Value = vehiculo.clase;
            comand.Parameters.Add("@usuario", OleDbType.VarChar, 50).Value = vehiculo.usuario;
            comand.Parameters.Add("@modelo", OleDbType.Integer, 10).Value = Convert.ToInt32(vehiculo.modelo);
            comand.Parameters.Add("@placas", OleDbType.VarChar, 50).Value = vehiculo.placas;
            comand.Parameters.Add("@numserie", OleDbType.VarChar, 50).Value = vehiculo.numserie;
            comand.Parameters.Add("@motor", OleDbType.VarChar, 50).Value = vehiculo.motor;
            comand.Parameters.Add("@llantas", OleDbType.VarChar, 50).Value = vehiculo.llantas;
            comand.Parameters.Add("@bajafecha", OleDbType.VarChar, 50).Value = vehiculo.bajafecha;
            comand.Parameters.Add("@color", OleDbType.VarChar, 50).Value = vehiculo.color;
            comand.Parameters.Add("@departamento", OleDbType.VarChar, 50).Value = vehiculo.color;
            
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            try
            {
                comand.ExecuteNonQuery();
                //MessageBox.Show("DATA ADDED");
                con.Close();
            }
            catch (OleDbException expe)
            {
                MessageBox.Show(expe.Message);
                con.Close();
            }
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
                this.modelo = Convert.ToInt32(lectura["modelo"].ToString());
                this.clase = lectura["clase"].ToString();
                this.usuario = lectura["usuario"].ToString();
                this.placas = lectura["placas"].ToString();
                this.numserie = lectura["numserie"].ToString();
                this.motor = lectura["motor"].ToString();
                this.llantas = lectura["llantas"].ToString();
                this.bajafecha = lectura["bajafecha"].ToString();
                this.color = lectura["color"].ToString();
                this.color = lectura["departamento"].ToString();
            }

            con.Close();
        }

        public DataTable getVehiculosDG()
        {
            con.Open();

            String consulta = "SELECT Id as ID, noecon as NoEconomico, marca as Marca, tipo as Tipo, modelo as Modelo, departamento as Departamento, bajafecha as BajaFecha FROM Vehiculos";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        public DataTable getVehiculosByNameDG(String Nombre)
        {
            con.Open();

            String consulta = "SELECT Id as ID, noecon as NoEconomico, marca as Marca, tipo as Tipo, modelo as Modelo, departamento as Departamento, bajafecha as BajaFecha FROM Vehiculos Where noecon LIKE '%" + Nombre + "%' or linea LIKE '%" + Nombre + "%' or tipo LIKE '%" + Nombre + "%' or marca LIKE '%" + Nombre + "%';";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        public DataTable getVehiculosByDepartamentoDG(String Nombre)
        {
            con.Open();

            String consulta = "SELECT * FROM Vehiculos Where departamento LIKE '%" + Nombre + "%';";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            con.Close();
            return proveedores;
        }

        public DataTable getVehiculosByClase(String Nombre)
        {
            con.Open();

            String consulta = "SELECT * FROM Vehiculos Where clase LIKE '%" + Nombre + "%';";
            OleDbCommand comand = new OleDbCommand();
            comand.Connection = con;
            comand.CommandText = consulta;

            OleDbDataAdapter da = new OleDbDataAdapter(comand);
            DataTable proveedores = new DataTable();
            da.Fill(proveedores);

            DataRow row = proveedores.NewRow();
            row["noecon"] = ""; //insert a blank row - you can even write something lile  = "Please select bellow...";
            proveedores.Rows.InsertAt(row, 0);

            con.Close();
            return proveedores;
        }

        public void deletevehiculo(int id)
        {
            OleDbCommand comand = new OleDbCommand();

            //sql de busqueda y realizamos consulta
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");
            String consulta = "UPDATE Vehiculos SET Vehiculos.bajafecha = '" + fecha_actual + "' Where Id = "+id+";";
            comand.Connection = con;
            comand.CommandText = consulta;
            con.Open();
            comand.ExecuteNonQuery();
            con.Close();
        }

    }
}
