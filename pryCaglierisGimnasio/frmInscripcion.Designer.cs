namespace pryCaglierisGimnasio
{
    partial class frmInscripcion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.GroupBox gpbPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.GroupBox gpbPago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.gpbPlan = new System.Windows.Forms.GroupBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.gpbPago = new System.Windows.Forms.GroupBox();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbDatosPersonales.SuspendLayout();
            this.gpbPlan.SuspendLayout();
            this.gpbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(22, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gimnasio Siglo — Inscripción";
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre);
            this.gpbDatosPersonales.Controls.Add(this.lblEdad);
            this.gpbDatosPersonales.Controls.Add(this.txtEdad);
            this.gpbDatosPersonales.Controls.Add(this.chkEstudiante);
            this.gpbDatosPersonales.Location = new System.Drawing.Point(24, 60);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(350, 142);
            this.gpbDatosPersonales.TabIndex = 1;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 28);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(17, 68);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(37, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(93, 65);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(55, 23);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloDigitos_KeyPress);
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(181, 66);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(80, 19);
            this.chkEstudiante.TabIndex = 4;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // gpbPlan
            // 
            this.gpbPlan.Controls.Add(this.lblPlan);
            this.gpbPlan.Controls.Add(this.cboPlan);
            this.gpbPlan.Controls.Add(this.lblTurno);
            this.gpbPlan.Controls.Add(this.cboTurno);
            this.gpbPlan.Controls.Add(this.lblMeses);
            this.gpbPlan.Controls.Add(this.txtMeses);
            this.gpbPlan.Controls.Add(this.chkCasillero);
            this.gpbPlan.Location = new System.Drawing.Point(24, 218);
            this.gpbPlan.Name = "gpbPlan";
            this.gpbPlan.Size = new System.Drawing.Size(350, 183);
            this.gpbPlan.TabIndex = 2;
            this.gpbPlan.TabStop = false;
            this.gpbPlan.Text = "Plan";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(17, 32);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(33, 15);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Plan:";
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            this.cboPlan.Location = new System.Drawing.Point(93, 29);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(235, 23);
            this.cboPlan.TabIndex = 1;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(17, 68);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(41, 15);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno:";
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            this.cboTurno.Location = new System.Drawing.Point(93, 65);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(145, 23);
            this.cboTurno.TabIndex = 3;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(17, 104);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(42, 15);
            this.lblMeses.TabIndex = 4;
            this.lblMeses.Text = "Meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(93, 101);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(55, 23);
            this.txtMeses.TabIndex = 5;
            this.txtMeses.TextChanged += new System.EventHandler(this.Campos_TextChanged);
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloDigitos_KeyPress);
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(181, 103);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(142, 19);
            this.chkCasillero.TabIndex = 6;
            this.chkCasillero.Text = "Casillero ($ 3.000/mes)";
            this.chkCasillero.UseVisualStyleBackColor = true;
            // 
            // gpbPago
            // 
            this.gpbPago.Controls.Add(this.rbtEfectivo);
            this.gpbPago.Controls.Add(this.rbtTarjeta);
            this.gpbPago.Controls.Add(this.lblCuotas);
            this.gpbPago.Controls.Add(this.cboCuotas);
            this.gpbPago.Location = new System.Drawing.Point(400, 60);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Size = new System.Drawing.Size(285, 180);
            this.gpbPago.TabIndex = 3;
            this.gpbPago.TabStop = false;
            this.gpbPago.Text = "Forma de pago";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(20, 34);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(67, 19);
            this.rbtEfectivo.TabIndex = 0;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Location = new System.Drawing.Point(20, 68);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(59, 19);
            this.rbtTarjeta.TabIndex = 1;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            this.rbtTarjeta.CheckedChanged += new System.EventHandler(this.rbtTarjeta_CheckedChanged);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(20, 108);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(44, 15);
            this.lblCuotas.TabIndex = 2;
            this.lblCuotas.Text = "Cuotas:";
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.Enabled = false;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            this.cboCuotas.Location = new System.Drawing.Point(83, 105);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(150, 23);
            this.cboCuotas.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(400, 267);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 38);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(555, 267);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 38);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 430);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbPago);
            this.Controls.Add(this.gpbPlan);
            this.Controls.Add(this.gpbDatosPersonales);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Siglo — Inscripción";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.gpbPlan.ResumeLayout(false);
            this.gpbPlan.PerformLayout();
            this.gpbPago.ResumeLayout(false);
            this.gpbPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
