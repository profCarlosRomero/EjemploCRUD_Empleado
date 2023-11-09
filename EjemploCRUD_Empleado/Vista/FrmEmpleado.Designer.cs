
namespace EjemploCRUD_Empleado.Vista
{
    partial class FrmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBajaEmp = new System.Windows.Forms.Button();
            this.btnModEmp = new System.Windows.Forms.Button();
            this.btnAltaEmp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabListaEmp = new System.Windows.Forms.TabPage();
            this.gboxBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAltaCancelar = new System.Windows.Forms.Button();
            this.btnAltaGuardar = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGerente = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltaDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAltaApe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltaNSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabListaEmp.SuspendLayout();
            this.gboxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBajaEmp);
            this.panel3.Controls.Add(this.btnModEmp);
            this.panel3.Controls.Add(this.btnAltaEmp);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(508, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panel3.Size = new System.Drawing.Size(79, 386);
            this.panel3.TabIndex = 3;
            // 
            // btnBajaEmp
            // 
            this.btnBajaEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBajaEmp.Location = new System.Drawing.Point(4, 95);
            this.btnBajaEmp.Name = "btnBajaEmp";
            this.btnBajaEmp.Size = new System.Drawing.Size(71, 31);
            this.btnBajaEmp.TabIndex = 6;
            this.btnBajaEmp.Text = "Eliminar";
            this.btnBajaEmp.UseVisualStyleBackColor = true;
            this.btnBajaEmp.Click += new System.EventHandler(this.btnBajaEmp_Click);
            // 
            // btnModEmp
            // 
            this.btnModEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModEmp.Location = new System.Drawing.Point(4, 64);
            this.btnModEmp.Name = "btnModEmp";
            this.btnModEmp.Size = new System.Drawing.Size(71, 31);
            this.btnModEmp.TabIndex = 5;
            this.btnModEmp.Text = "Modificar";
            this.btnModEmp.UseVisualStyleBackColor = true;
            this.btnModEmp.Click += new System.EventHandler(this.btnModEmp_Click);
            // 
            // btnAltaEmp
            // 
            this.btnAltaEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaEmp.Location = new System.Drawing.Point(4, 33);
            this.btnAltaEmp.Name = "btnAltaEmp";
            this.btnAltaEmp.Size = new System.Drawing.Size(71, 31);
            this.btnAltaEmp.TabIndex = 4;
            this.btnAltaEmp.Text = "Alta";
            this.btnAltaEmp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 33);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabListaEmp);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 365);
            this.tabControl1.TabIndex = 4;
            // 
            // tabListaEmp
            // 
            this.tabListaEmp.Controls.Add(this.gboxBuscar);
            this.tabListaEmp.Controls.Add(this.dgvEmpleado);
            this.tabListaEmp.Location = new System.Drawing.Point(4, 22);
            this.tabListaEmp.Name = "tabListaEmp";
            this.tabListaEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaEmp.Size = new System.Drawing.Size(485, 339);
            this.tabListaEmp.TabIndex = 0;
            this.tabListaEmp.Text = "Listado";
            this.tabListaEmp.UseVisualStyleBackColor = true;
            // 
            // gboxBuscar
            // 
            this.gboxBuscar.Controls.Add(this.btnBuscar);
            this.gboxBuscar.Controls.Add(this.textBox6);
            this.gboxBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxBuscar.Location = new System.Drawing.Point(3, 3);
            this.gboxBuscar.Name = "gboxBuscar";
            this.gboxBuscar.Size = new System.Drawing.Size(479, 42);
            this.gboxBuscar.TabIndex = 1;
            this.gboxBuscar.TabStop = false;
            this.gboxBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.Location = new System.Drawing.Point(412, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox6.Location = new System.Drawing.Point(3, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(407, 20);
            this.textBox6.TabIndex = 0;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(5, 50);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowTemplate.Height = 25;
            this.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleado.Size = new System.Drawing.Size(476, 244);
            this.dgvEmpleado.TabIndex = 0;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAltaCancelar);
            this.tabPage2.Controls.Add(this.btnAltaGuardar);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtAltaDir);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtAltaApe);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtAltaNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtAltaNSS);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(485, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAltaCancelar
            // 
            this.btnAltaCancelar.Location = new System.Drawing.Point(85, 309);
            this.btnAltaCancelar.Name = "btnAltaCancelar";
            this.btnAltaCancelar.Size = new System.Drawing.Size(64, 20);
            this.btnAltaCancelar.TabIndex = 20;
            this.btnAltaCancelar.Text = "Cancelar";
            this.btnAltaCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAltaGuardar
            // 
            this.btnAltaGuardar.Location = new System.Drawing.Point(15, 309);
            this.btnAltaGuardar.Name = "btnAltaGuardar";
            this.btnAltaGuardar.Size = new System.Drawing.Size(64, 20);
            this.btnAltaGuardar.TabIndex = 19;
            this.btnAltaGuardar.Text = "Guardar";
            this.btnAltaGuardar.UseVisualStyleBackColor = true;
            this.btnAltaGuardar.Click += new System.EventHandler(this.btnAltaGuardar_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(170, 218);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Otro";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 218);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femenino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 218);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(339, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 103);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(5, 19);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(132, 21);
            this.cbDepartamento.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGerente);
            this.groupBox1.Location = new System.Drawing.Point(339, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 146);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerente";
            // 
            // lbGerente
            // 
            this.lbGerente.FormattingEnabled = true;
            this.lbGerente.Location = new System.Drawing.Point(5, 19);
            this.lbGerente.Name = "lbGerente";
            this.lbGerente.Size = new System.Drawing.Size(132, 121);
            this.lbGerente.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(24, 263);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(86, 20);
            this.textBox7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sexo";
            // 
            // txtAltaDir
            // 
            this.txtAltaDir.Location = new System.Drawing.Point(24, 172);
            this.txtAltaDir.Name = "txtAltaDir";
            this.txtAltaDir.Size = new System.Drawing.Size(131, 20);
            this.txtAltaDir.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // txtAltaApe
            // 
            this.txtAltaApe.Location = new System.Drawing.Point(193, 80);
            this.txtAltaApe.Name = "txtAltaApe";
            this.txtAltaApe.Size = new System.Drawing.Size(142, 20);
            this.txtAltaApe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txtAltaNombre
            // 
            this.txtAltaNombre.Location = new System.Drawing.Point(24, 80);
            this.txtAltaNombre.Name = "txtAltaNombre";
            this.txtAltaNombre.Size = new System.Drawing.Size(142, 20);
            this.txtAltaNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtAltaNSS
            // 
            this.txtAltaNSS.Location = new System.Drawing.Point(24, 36);
            this.txtAltaNSS.Name = "txtAltaNSS";
            this.txtAltaNSS.Size = new System.Drawing.Size(109, 20);
            this.txtAltaNSS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NSS";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabListaEmp.ResumeLayout(false);
            this.gboxBuscar.ResumeLayout(false);
            this.gboxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBajaEmp;
        private System.Windows.Forms.Button btnModEmp;
        private System.Windows.Forms.Button btnAltaEmp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabListaEmp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAltaDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltaApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltaNSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ListBox lbGerente;
        private System.Windows.Forms.GroupBox gboxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnAltaCancelar;
        private System.Windows.Forms.Button btnAltaGuardar;
        private System.Windows.Forms.Button button1;
    }
}