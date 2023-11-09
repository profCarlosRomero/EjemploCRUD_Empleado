
namespace EjemploCRUD_Empleado.Vista
{
    partial class FrmDepartamento
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpListar = new System.Windows.Forms.TabPage();
            this.gboxBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvDepartemento = new System.Windows.Forms.DataGridView();
            this.tpFormulario = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechInicGte = new System.Windows.Forms.DateTimePicker();
            this.cbGteDpto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomDpto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumDpto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tpListar.SuspendLayout();
            this.gboxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartemento)).BeginInit();
            this.tpFormulario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpListar);
            this.tabControl1.Controls.Add(this.tpFormulario);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tpListar
            // 
            this.tpListar.Controls.Add(this.gboxBuscar);
            this.tpListar.Controls.Add(this.dgvDepartemento);
            this.tpListar.Location = new System.Drawing.Point(4, 22);
            this.tpListar.Name = "tpListar";
            this.tpListar.Padding = new System.Windows.Forms.Padding(3);
            this.tpListar.Size = new System.Drawing.Size(450, 285);
            this.tpListar.TabIndex = 0;
            this.tpListar.Text = "Listar";
            this.tpListar.UseVisualStyleBackColor = true;
            // 
            // gboxBuscar
            // 
            this.gboxBuscar.Controls.Add(this.btnBuscar);
            this.gboxBuscar.Controls.Add(this.txtBuscar);
            this.gboxBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxBuscar.Location = new System.Drawing.Point(3, 3);
            this.gboxBuscar.Name = "gboxBuscar";
            this.gboxBuscar.Size = new System.Drawing.Size(444, 42);
            this.gboxBuscar.TabIndex = 3;
            this.gboxBuscar.TabStop = false;
            this.gboxBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.Location = new System.Drawing.Point(377, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBuscar.Location = new System.Drawing.Point(3, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(368, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // dgvDepartemento
            // 
            this.dgvDepartemento.AllowUserToAddRows = false;
            this.dgvDepartemento.AllowUserToDeleteRows = false;
            this.dgvDepartemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartemento.Location = new System.Drawing.Point(5, 48);
            this.dgvDepartemento.Name = "dgvDepartemento";
            this.dgvDepartemento.ReadOnly = true;
            this.dgvDepartemento.RowTemplate.Height = 25;
            this.dgvDepartemento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartemento.Size = new System.Drawing.Size(439, 231);
            this.dgvDepartemento.TabIndex = 2;
            this.dgvDepartemento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartemento_CellClick);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Controls.Add(this.btnGuardar);
            this.tpFormulario.Controls.Add(this.dtpFechInicGte);
            this.tpFormulario.Controls.Add(this.cbGteDpto);
            this.tpFormulario.Controls.Add(this.label4);
            this.tpFormulario.Controls.Add(this.label3);
            this.tpFormulario.Controls.Add(this.txtNomDpto);
            this.tpFormulario.Controls.Add(this.label2);
            this.tpFormulario.Controls.Add(this.txtNumDpto);
            this.tpFormulario.Controls.Add(this.label1);
            this.tpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tpFormulario.Name = "tpFormulario";
            this.tpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormulario.Size = new System.Drawing.Size(450, 285);
            this.tpFormulario.TabIndex = 1;
            this.tpFormulario.Text = "Alta";
            this.tpFormulario.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(18, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechInicGte
            // 
            this.dtpFechInicGte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechInicGte.Location = new System.Drawing.Point(18, 185);
            this.dtpFechInicGte.Name = "dtpFechInicGte";
            this.dtpFechInicGte.Size = new System.Drawing.Size(121, 20);
            this.dtpFechInicGte.TabIndex = 5;
            this.dtpFechInicGte.Value = new System.DateTime(2023, 8, 29, 0, 0, 0, 0);
            // 
            // cbGteDpto
            // 
            this.cbGteDpto.FormattingEnabled = true;
            this.cbGteDpto.Location = new System.Drawing.Point(18, 133);
            this.cbGteDpto.Name = "cbGteDpto";
            this.cbGteDpto.Size = new System.Drawing.Size(153, 21);
            this.cbGteDpto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Inicio Gerente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gerente";
            // 
            // txtNomDpto
            // 
            this.txtNomDpto.Location = new System.Drawing.Point(18, 81);
            this.txtNomDpto.Name = "txtNomDpto";
            this.txtNomDpto.Size = new System.Drawing.Size(153, 20);
            this.txtNomDpto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtNumDpto
            // 
            this.txtNumDpto.Location = new System.Drawing.Point(18, 31);
            this.txtNumDpto.Name = "txtNumDpto";
            this.txtNumDpto.Size = new System.Drawing.Size(100, 20);
            this.txtNumDpto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaja);
            this.panel1.Controls.Add(this.btnModif);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(476, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 335);
            this.panel1.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaja.Location = new System.Drawing.Point(0, 108);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(67, 35);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModif
            // 
            this.btnModif.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModif.Location = new System.Drawing.Point(0, 73);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(67, 35);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlta.Location = new System.Drawing.Point(0, 38);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(67, 35);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 38);
            this.panel2.TabIndex = 0;
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDepartamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpListar.ResumeLayout(false);
            this.gboxBuscar.ResumeLayout(false);
            this.gboxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartemento)).EndInit();
            this.tpFormulario.ResumeLayout(false);
            this.tpFormulario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpListar;
        private System.Windows.Forms.TabPage tpFormulario;
        private System.Windows.Forms.DateTimePicker dtpFechInicGte;
        private System.Windows.Forms.ComboBox cbGteDpto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomDpto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumDpto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvDepartemento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnGuardar;
    }
}