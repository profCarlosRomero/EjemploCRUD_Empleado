using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCRUD_Empleado.Datos
{
    class EmpleadoEjemplo
    {
        // NOMBREP	APELLIDO	NSS	FECHAN	DIRECCIÓN	SEXO	SALARIO	NSSSUPER	ND
        private string nss;
        private string nombrep;
        private string apellido;
        private DateTime fechan;
        private string dir;
        private char sexo;
        private double salario;
        private string nsssuper;
        private int nd;

        public EmpleadoEjemplo(string nss, string nombrep, string apellido, DateTime fechan, string dir, char sexo, double salario, string nsssuper, int nd)
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
        public EmpleadoEjemplo() { }

        public System.Data.DataTable CargarDGV()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            //string sql = "SELECT * FROM empleado";
            string sql = "SELECT nss as NSS, nombrep as Nombre, apellido as Apellido," +
                "fechan as FechaNac, direccion as Dirección, sexo as Sexo, salario as Salario," +
                "nsssuper as Supervisor, nd as Dpto FROM empleado";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt);

            //Conexion.GetInstancia().Desconectar();

            return dt;
        }
        public void Alta()
        {
            string fecha = fechan.ToString("yyyy-MM-dd");

            string sentencia = "INSERT INTO empleado (nss, nombrep, apellido, " +
                "fechan, direccion, sexo, salario, nsssuper, nd) " +
                $"VALUES ('{this.nss}', '{this.nombrep}', '{this.apellido}'," +
                $"'{fecha}', '{this.dir}', '{this.sexo}', {this.salario}, '{this.nsssuper}', {this.nd})";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());
            cmd.ExecuteNonQuery();

            Conexion.GetInstancia().Desconectar();
        }
        public void Modificar()
        {
            string fecha = fechan.ToString("yyyy-MM-dd");

            string sentencia = $"UPDATE empleado SET nombrep = '{nombrep}', " +
                $"apellido = '{apellido}', fechan = '{fecha}', direccion = '{dir}', " +
                $"sexo = '{sexo}', salario = {salario}, nd = {nd} " +
                $"WHERE nss = {nss}";

            MySql.Data.MySqlClient.MySqlCommand cmd = 
                new MySql.Data.MySqlClient.MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

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

        public System.Data.DataTable ListarLBox()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            string sql = $"SELECT nss, nombrep, apellido FROM empleado";
            //string sql = $"SELECT CONCAT(nss, ' - ', nombrep, ' - ', apellido) AS full FROM empleado";
            MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
            //cmd.ExecuteNonQuery();
            

            return dt;
        }

        public System.Data.DataTable ListarDGV_con_CB()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            dt = CargarDGV();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                String[] col = new String[] { };
            }

            return dt;
        }

        //public System.Data.DataTable ListarDGV_con_CB_2()
        public System.Windows.Forms.DataGridView ListarDGV_con_CB_2()
        {
            System.Data.DataTable dt_empleado = new System.Data.DataTable();

            //string sql = "SELECT * FROM empleado";
            string sql = "SELECT nss as NSS, nombrep as Nombre, apellido as Apellido," +
                "fechan as FechaNac, direccion as Dirección, sexo as Sexo, salario as Salario," +
                "nsssuper as Supervisor FROM empleado";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt_empleado); // 0 - 7 columnas

            System.Windows.Forms.DataGridView dgv = new System.Windows.Forms.DataGridView();
            dgv.DataSource = dt_empleado;

            //System.Data.DataColumn dc = dt.Columns.Add("Depto");

            //System.Windows.Forms.DataGridViewComboBoxColumn new System.Windows.Forms.DataGridViewComboBoxColumn();
            System.Windows.Forms.DataGridViewComboBoxColumn cb = new System.Windows.Forms.DataGridViewComboBoxColumn();

            System.Windows.Forms.MessageBox.Show(dt_empleado.Columns.Count.ToString());
            System.Windows.Forms.MessageBox.Show(dgv.Columns.Count.ToString());

            cb.DataSource = (new Departamento()).ListarCBox(); // numerod, nombred cbDepartamento.DataSource = (new Datos.Departamento()).ListarCBox();

            //this.Column1.HeaderText = "Depto";
            //this.Column1.Items.AddRange(new object[] { "hola", "chau"});
            cb.HeaderText = "Depto";
            System.Windows.Forms.MessageBox.Show(cb.Items.Count.ToString());

            //dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cb });
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cb });

            /*
            foreach (System.Data.DataRow row in dt.Rows)
            {
                //this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1});
                row[8] = cb;
            }*/

            return dgv;
        }


        public System.Data.DataTable ListarDGV_con_CB_3(int torneo)
        {
            System.Data.DataTable dt_empleado = new System.Data.DataTable();

            string sql = "SELECT nss as NSS, nombrep as Nombre, apellido as Apellido," +
                "fechan as FechaNac, direccion as Dirección, sexo as Sexo, salario as Salario," +
                "nsssuper as Supervisor FROM empleado";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Conexion.GetInstancia().Conectar());
            MySql.Data.MySqlClient.MySqlDataAdapter adp = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            adp.Fill(dt_empleado); // 0 - 7 columnas

            dt_empleado.Columns.Add($"torneo {torneo}", typeof(bool));

            return dt_empleado;
        }

    }
}
