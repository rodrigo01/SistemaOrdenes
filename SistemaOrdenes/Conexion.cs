using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace SistemaOrdenes
{
    class Conexion
    {
        public OleDbConnection con;
        public Conexion()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\irtec\\BD_Sistema.mdb");
        }
    }
}
