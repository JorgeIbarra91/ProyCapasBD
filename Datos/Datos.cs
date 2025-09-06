using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Datos
    {

        public class CD_Conexion
        {


            private SqlConnection Conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=EjercicioDB;Integrated Security=True;TrustServerCertificate=True;");

            public SqlConnection AbrirConexion()
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }

            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
        }

    }
}
