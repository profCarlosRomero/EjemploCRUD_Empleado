using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCRUD_Empleado.Datos
{
    class Conexion
    {
        private static MySql.Data.MySqlClient.MySqlConnection conexion;
        /* SINGLETON */
        private static Conexion instancia;
        private Conexion()
        {
            conexion = null;
        }
        public static Conexion GetInstancia()
        {
            if (instancia == null)
                instancia = new Conexion();
            return instancia;
        }
        /* SINGLETON - FIN*/

        public MySql.Data.MySqlClient.MySqlConnection Conectar()
        {
            try
            {
                if (conexion == null)
                {
                    string conexion_string = System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
                    conexion = new MySql.Data.MySqlClient.MySqlConnection(conexion_string);
                    conexion.Open();

                    return conexion;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de conectar a la BD", ex);
            }

            return conexion;
        }
        public void Desconectar()
        {
            if (conexion != null)
            {
                conexion.Close();
                conexion = null; // Es necesario porque al cerrar la conexión no queda en null
                // y cuando se quiere volver a conectar, conexión no es null (está cerrada) y
                // entonces se retorna la conexión cerrada
            }
        }
    }
}
