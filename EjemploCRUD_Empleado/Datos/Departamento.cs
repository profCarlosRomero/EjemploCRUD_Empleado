using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCRUD_Empleado.Datos
{
    class Departamento
    {
        private int numerod;
        private string nombred;
        private string nssgte;
        private DateTime fechaInicGte;
        public Departamento(int numerod, string nombred, string nssgte, DateTime fechaInicGte)
        {
            this.numerod = numerod;
            this.nombred = nombred;
            this.nssgte = nssgte;
            this.fechaInicGte = fechaInicGte;
        }
        public Departamento()
        { }
        public int Numerod { get { return this.numerod; } }
        public string Nombred { get { return this.nombred; } set { this.nombred = value; } }
        public string Nssgte { get { return this.nssgte; } set { this.nssgte = value; } }
        public DateTime FechaInicGte { get { return this.fechaInicGte; } set { this.fechaInicGte = value; } }

        /// <summary>
        /// Método <c>FechaInicGteToBD</c> Se utiliza para el INSERT en BD.
        /// </summary>
        /// <returns>Un string con el formato de MySQL</returns>
        public string FechaInicGteToBD()
        {
            return this.fechaInicGte.ToString("yyyy-MM-dd");
        }

        public System.Data.DataTable ListarCBox()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = $"SELECT numerod, nombred FROM departamento";

            //try
            //{
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
                MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                adp.Fill(dt);
            //}
            //catch (Exception ex)
            ////catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    throw new Exception(ex.Message, ex);
            //}

            Conexion.GetInstancia().Desconectar();

            return dt;
        }
        public System.Data.DataTable ListarDGV()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = $"SELECT numerod as NumDpto, nombred as NombreDpto, nssgte as Gerente, fechainicgte as InicioGte FROM departamento";
            try
            {
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
                MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch(Exception ex)
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
            string sentencia = $"INSERT INTO departamento(numerod, nombred, nssgte, fechainicgte)" +
                $"VALUES({numerod}, '{nombred}', '{nssgte}', '{this.FechaInicGteToBD()}')";
            MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());
            cmd.ExecuteNonQuery();
            Conexion.GetInstancia().Desconectar();
        }

        public void Modificar(int numd)
        {
            string sentencia = $"UPDATE departamento " +
                $"SET nombred = '{this.nombred}', " +
                $"nssgte = '{this.nssgte}', " +
                $"fechainicgte = '{this.FechaInicGteToBD()}' " +
                $"WHERE numerod = {numd}";

            MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());
            cmd.ExecuteNonQuery();
            Conexion.GetInstancia().Desconectar();
        }

        public void Baja(int numd)
        {
            string sentencia = $"DELETE FROM departamento WHERE numerod = '{numd}'";

            MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }

        /*
         *  Métodos pendientes: Modificar y Baja
         *  Falta agregar un método en Datos/Empleado para cargar el cbox para seleccionar gerente.
         * 
         */

    }
}
