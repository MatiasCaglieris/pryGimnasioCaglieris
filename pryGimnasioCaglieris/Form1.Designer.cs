namespace pryGimnasioCaglieris
{
    partial class frmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
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
            this.lblFormadePago = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.gpbPlanyTurno = new System.Windows.Forms.GroupBox();
            this.gpbPago = new System.Windows.Forms.GroupBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbDatosPersonales.SuspendLayout();
            this.gpbPlanyTurno.SuspendLayout();
            this.gpbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(9, 61);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "Edad: ";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(15, 130);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(76, 17);
            this.chkEstudiante.TabIndex = 3;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 24);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(105, 54);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(114, 55);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 21);
            this.cboPlan.TabIndex = 6;
            this.cboPlan.SelectedIndexChanged += new System.EventHandler(this.cboPlan_SelectedIndexChanged);
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(114, 26);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(121, 21);
            this.cboTurno.TabIndex = 7;
            this.cboTurno.SelectedIndexChanged += new System.EventHandler(this.cboTurno_SelectedIndexChanged);
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(114, 88);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 8;
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Controls.Add(this.txtEdad);
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Controls.Add(this.lblEdad);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre);
            this.gpbDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(330, 135);
            this.gpbDatosPersonales.TabIndex = 9;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "DATOS PERSONALES";
            this.gpbDatosPersonales.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(12, 63);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 7;
            this.lblPlan.Text = "Plan";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(12, 29);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "Turno";
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(105, 76);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 9;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Location = new System.Drawing.Point(105, 31);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rdbTarjeta.TabIndex = 10;
            this.rdbTarjeta.TabStop = true;
            this.rdbTarjeta.Text = "Tarjeta";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblFormadePago
            // 
            this.lblFormadePago.AutoSize = true;
            this.lblFormadePago.Location = new System.Drawing.Point(12, 33);
            this.lblFormadePago.Name = "lblFormadePago";
            this.lblFormadePago.Size = new System.Drawing.Size(32, 13);
            this.lblFormadePago.TabIndex = 11;
            this.lblFormadePago.Text = "Pago";
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Location = new System.Drawing.Point(191, 27);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(35, 21);
            this.cboCuotas.TabIndex = 12;
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(114, 130);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(134, 17);
            this.chkCasillero.TabIndex = 13;
            this.chkCasillero.Text = "Casillero ($ 3.000/mes)";
            this.chkCasillero.UseVisualStyleBackColor = true;
            // 
            // gpbPlanyTurno
            // 
            this.gpbPlanyTurno.Controls.Add(this.lblMeses);
            this.gpbPlanyTurno.Controls.Add(this.lblTurno);
            this.gpbPlanyTurno.Controls.Add(this.lblPlan);
            this.gpbPlanyTurno.Controls.Add(this.txtMeses);
            this.gpbPlanyTurno.Controls.Add(this.cboTurno);
            this.gpbPlanyTurno.Controls.Add(this.chkCasillero);
            this.gpbPlanyTurno.Controls.Add(this.cboPlan);
            this.gpbPlanyTurno.Controls.Add(this.chkEstudiante);
            this.gpbPlanyTurno.Location = new System.Drawing.Point(12, 153);
            this.gpbPlanyTurno.Name = "gpbPlanyTurno";
            this.gpbPlanyTurno.Size = new System.Drawing.Size(330, 162);
            this.gpbPlanyTurno.TabIndex = 14;
            this.gpbPlanyTurno.TabStop = false;
            this.gpbPlanyTurno.Text = "PLAN - TURNO";
            // 
            // gpbPago
            // 
            this.gpbPago.Controls.Add(this.rdbEfectivo);
            this.gpbPago.Controls.Add(this.rdbTarjeta);
            this.gpbPago.Controls.Add(this.cboCuotas);
            this.gpbPago.Controls.Add(this.lblFormadePago);
            this.gpbPago.Location = new System.Drawing.Point(12, 324);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Size = new System.Drawing.Size(330, 114);
            this.gpbPago.TabIndex = 15;
            this.gpbPago.TabStop = false;
            this.gpbPago.Text = "FORMA DE PAGO";
            this.gpbPago.Enter += new System.EventHandler(this.gpbPago_Enter);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(15, 91);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 14;
            this.lblMeses.Text = "Meses";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(55, 459);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(183, 458);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 520);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbPago);
            this.Controls.Add(this.gpbPlanyTurno);
            this.Controls.Add(this.gpbDatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo — Inscripción";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.gpbPlanyTurno.ResumeLayout(false);
            this.gpbPlanyTurno.PerformLayout();
            this.gpbPago.ResumeLayout(false);
            this.gpbPago.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblFormadePago;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.GroupBox gpbPlanyTurno;
        private System.Windows.Forms.GroupBox gpbPago;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

