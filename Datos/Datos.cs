using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Conexion
    {
        // Cadena de conexión ajustada a tu base de datos local
        SqlConnection Conexion = new SqlConnection(
    "Server=DESKTOP-DC7072T;Database=EjercicioDB;Integrated Security=True;TrustServerCertificate=True;"
         );

        // Método para abrir la conexión
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        // Método para cerrar la conexión
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}