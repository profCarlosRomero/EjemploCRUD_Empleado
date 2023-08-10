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
            if(conexion == null)
            {
                string conexion_string = System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
                conexion = new MySql.Data.MySqlClient.MySqlConnection(conexion_string);
                conexion.Open();
            }

            return conexion;
        }
        public void Desconectar()
        {
            if (conexion != null)
                conexion.Close();
        }
    }
}
