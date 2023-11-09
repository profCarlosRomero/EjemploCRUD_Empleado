using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCRUD_Empleado.Datos
{
    class Usuario
    {
        private string user;
        private string pass;

        public Usuario(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
        public Usuario()
        {
        }

        public bool Login()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            string sql = $"SELECT usuario, pass FROM usuario WHERE usuario = '{this.user}' " +
                $"AND pass = '{this.pass}'";

            MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
            MySql.Data.MySqlClient.MySqlDataAdapter adp =
                new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
