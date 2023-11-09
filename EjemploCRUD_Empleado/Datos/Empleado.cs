using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCRUD_Empleado.Datos
{
    class Empleado
    {
        
        private string nss;
        private string nombrep;
        private string apellido;
        private DateTime fechan;
        private string dir;
        private char sexo;
        private double salario;
        private string nsssuper;
        private int nd;

        public Empleado(string nss, string nombrep, string apellido, DateTime fechan, string dir, char sexo, double salario, string nsssuper, int nd)
        {
            this.nss = nss;
            this.nombrep = nombrep;
            this.apellido = apellido;
            this.fechan = fechan;
            this.dir = dir;
            this.sexo = sexo;
            this.salario = salario;
            this.nsssuper = nsssuper;
            this.nd = nd;
        }
        public Empleado()
        { }

        public System.Data.DataTable ListarDGV()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = "SELECT nss as NSS, nombrep as Nombre," +
                "apellido as Apellido, fechan as FechaNac," +
                "direccion as Dirección, sexo as Sexo," +
                "salario as Salario, nsssuper as NSSSuper," +
                "nd as Dpto FROM empleado";
            try
            {
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
                MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                adp.Fill(dt);
            }
            catch (Exception ex)
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                Conexion.GetInstancia().Desconectar();
            }

            return dt;
        }

        public void Alta()
        {
            string fecha = this.fechan.ToString("yyyy-MM-dd");

            //-------------------- ¡¡¡FALTA darle valor a la columna sexo!!!

            //string sentencia = "INSERT INTO empleado (nss, nombrep, apellido, " +
            //    "fechan, direccion, sexo, salario, nsssuper, nd) " +
            //    $"VALUES ('{this.nss}', '{this.nombrep}', '{this.apellido}'," +
            //    $"'{fecha}', '{this.dir}', {this.salario}, '{this.nsssuper}', {this.nd})";
            /*string sentencia = "INSERT INTO empleado (nss, nombrep, apellido, " +
                "fechan, direccion, sexo, salario, nsssuper, nd) " +
                $"VALUES ('{this.nss}', '{this.nombrep}', '{this.apellido}'," +
                $"'{fecha}', '{this.dir}', '{THISSSS.sexo}', {this.salario}, '{this.nsssuper}', {this.nd})";*/

            string sentencia = "INSERT INTO empleado (nss, nombrep, apellido, " +
                "fechan, direccion, sexo, salario, nd) " +
                $"VALUES ('{this.nss}', '{this.nombrep}', '{this.apellido}'," +
                $"'{fecha}', '{this.dir}', '{this.sexo}', {this.salario}, {this.nd})";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());
            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

        public void Baja(string nss)
        {
            string sentencia = $"DELETE FROM empleado WHERE nss = '{nss}'";
            MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

        public void Modif()
        {
            /*
             (nss, nombrep, apellido, fechan, direccion, sexo, salario, nd)
             */
            string sentencia = $"UPDATE empleado SET nss = '{nss}', " +
                $"nombrep = '{nombrep}', " +
                $"apellido = '{apellido}', " +
                $"fechan = '{fechan.ToString("yyyy-MM-dd")}', " +
                $"direccion = '{dir}', " +
                $"sexo = '{sexo}', " +
                $"salario = {salario} " +
                $"WHERE nss = '{nss}'";
            MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }
    }
}
