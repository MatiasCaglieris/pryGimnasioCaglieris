using System;

namespace pryGimnasioCaglieris
{
    partial class frminscripcion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminscripcion));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.rdbTarjeta = new System.Windows.Forms.RadioButton();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.gpbPlanyTurno = new System.Windows.Forms.GroupBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.gpbPago = new System.Windows.Forms.GroupBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbDatosPersonales.SuspendLayout();
            this.gpbPlanyTurno.SuspendLayout();
            this.gpbPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(9, 61);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 20);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad: ";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(233, 26);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(97, 24);
            this.chkEstudiante.TabIndex = 4;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            this.chkEstudiante.CheckedChanged += new System.EventHandler(this.chkEstudiante_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 26);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 27);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(83, 61);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(35, 27);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloDigitos_KeyPress);
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Musculacion",
            "Funcional",
            "Natacion"});
            this.cboPlan.Location = new System.Drawing.Point(69, 58);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(114, 28);
            this.cboPlan.TabIndex = 3;
            this.cboPlan.SelectedIndexChanged += new System.EventHandler(this.cboPlan_SelectedIndexChanged);
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cboTurno.Location = new System.Drawing.Point(69, 29);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(114, 28);
            this.cboTurno.TabIndex = 1;
            this.cboTurno.SelectedIndexChanged += new System.EventHandler(this.cboTurno_SelectedIndexChanged);
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(69, 88);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(35, 27);
            this.txtMeses.TabIndex = 5;
            this.txtMeses.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloDigitos_KeyPress);
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gpbDatosPersonales.Controls.Add(this.txtEdad);
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Controls.Add(this.lblEdad);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre);
            this.gpbDatosPersonales.Controls.Add(this.chkEstudiante);
            this.gpbDatosPersonales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosPersonales.ForeColor = System.Drawing.Color.Black;
            this.gpbDatosPersonales.Location = new System.Drawing.Point(209, 55);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(330, 110);
            this.gpbDatosPersonales.TabIndex = 1;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "DATOS PERSONALES";
            this.gpbDatosPersonales.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(9, 58);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(37, 20);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(9, 29);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(47, 20);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(24, 71);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(80, 24);
            this.rdbEfectivo.TabIndex = 3;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Location = new System.Drawing.Point(24, 33);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(71, 24);
            this.rdbTarjeta.TabIndex = 2;
            this.rdbTarjeta.TabStop = true;
            this.rdbTarjeta.Text = "Tarjeta";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            this.rdbTarjeta.CheckedChanged += new System.EventHandler(this.rdbTarjeta_CheckedChanged);
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Location = new System.Drawing.Point(168, 29);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(42, 28);
            this.cboCuotas.TabIndex = 0;
            this.cboCuotas.SelectedIndexChanged += new System.EventHandler(this.cboCuotas_SelectedIndexChanged);
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(12, 127);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(179, 24);
            this.chkCasillero.TabIndex = 6;
            this.chkCasillero.Text = "Casillero ($ 3.000/mes)";
            this.chkCasillero.UseVisualStyleBackColor = true;
            this.chkCasillero.CheckedChanged += new System.EventHandler(this.chkCasillero_CheckedChanged);
            // 
            // gpbPlanyTurno
            // 
            this.gpbPlanyTurno.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gpbPlanyTurno.Controls.Add(this.lblMeses);
            this.gpbPlanyTurno.Controls.Add(this.lblTurno);
            this.gpbPlanyTurno.Controls.Add(this.lblPlan);
            this.gpbPlanyTurno.Controls.Add(this.txtMeses);
            this.gpbPlanyTurno.Controls.Add(this.cboTurno);
            this.gpbPlanyTurno.Controls.Add(this.chkCasillero);
            this.gpbPlanyTurno.Controls.Add(this.cboPlan);
            this.gpbPlanyTurno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPlanyTurno.ForeColor = System.Drawing.Color.Black;
            this.gpbPlanyTurno.Location = new System.Drawing.Point(209, 191);
            this.gpbPlanyTurno.Name = "gpbPlanyTurno";
            this.gpbPlanyTurno.Size = new System.Drawing.Size(330, 162);
            this.gpbPlanyTurno.TabIndex = 2;
            this.gpbPlanyTurno.TabStop = false;
            this.gpbPlanyTurno.Text = "PLAN - TURNO";
            this.gpbPlanyTurno.Enter += new System.EventHandler(this.gpbPlanyTurno_Enter);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(9, 91);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(50, 20);
            this.lblMeses.TabIndex = 4;
            this.lblMeses.Text = "Meses";
            // 
            // gpbPago
            // 
            this.gpbPago.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gpbPago.Controls.Add(this.lblCuotas);
            this.gpbPago.Controls.Add(this.rdbEfectivo);
            this.gpbPago.Controls.Add(this.rdbTarjeta);
            this.gpbPago.Controls.Add(this.cboCuotas);
            this.gpbPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPago.ForeColor = System.Drawing.Color.Black;
            this.gpbPago.Location = new System.Drawing.Point(209, 372);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Size = new System.Drawing.Size(330, 114);
            this.gpbPago.TabIndex = 3;
            this.gpbPago.TabStop = false;
            this.gpbPago.Text = "FORMA DE PAGO";
            this.gpbPago.Enter += new System.EventHandler(this.gpbPago_Enter);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(108, 35);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(61, 20);
            this.lblCuotas.TabIndex = 4;
            this.lblCuotas.Text = "Cuotas: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(380, 508);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 32);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(245, 508);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblTitulo.Location = new System.Drawing.Point(250, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GIMNASIO SIGLO";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(613, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 148);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frminscripcion
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnLimpiar;
            this.ClientSize = new System.Drawing.Size(749, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbPago);
            this.Controls.Add(this.gpbPlanyTurno);
            this.Controls.Add(this.gpbDatosPersonales);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frminscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo — Inscripción";
            this.Load += new System.EventHandler(this.frminscripcion_Load);
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.gpbPlanyTurno.ResumeLayout(false);
            this.gpbPlanyTurno.PerformLayout();
            this.gpbPago.ResumeLayout(false);
            this.gpbPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.GroupBox gpbPlanyTurno;
        private System.Windows.Forms.GroupBox gpbPago;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.PictureBox pictureBox1;

        public EventHandler btnCalcular_Click { get; private set; }
    }
}

