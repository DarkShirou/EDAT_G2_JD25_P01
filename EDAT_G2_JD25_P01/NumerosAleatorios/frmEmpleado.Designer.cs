namespace NumerosAleatorios
{
    partial class frmEmpleado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            cmbGrupo = new ComboBox();
            txtSueldo = new TextBox();
            chkSeguroMedico = new CheckBox();
            btnGenerar = new Button();
            lblNumero = new Label();
            lblNombre = new Label();
            lblFechaNacimiento = new Label();
            lblGrupo = new Label();
            lblSueldo = new Label();
            SuspendLayout();
           
            txtNumero.Location = new Point(279, 31);
            txtNumero.Margin = new Padding(4, 5, 4, 5);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(284, 31);
            txtNumero.TabIndex = 0;
            txtNumero.TextChanged += txtNumero_TextChanged;
            
            txtNombre.Location = new Point(279, 106);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 31);
            txtNombre.TabIndex = 1;
            
            dtpFechaNacimiento.Location = new Point(279, 186);
            dtpFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(284, 31);
            dtpFechaNacimiento.TabIndex = 2;
           
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(279, 265);
            rbMasculino.Margin = new Padding(4, 5, 4, 5);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(117, 29);
            rbMasculino.TabIndex = 3;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
           
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(422, 265);
            rbFemenino.Margin = new Padding(4, 5, 4, 5);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(115, 29);
            rbFemenino.TabIndex = 4;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
           
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(279, 332);
            cmbGrupo.Margin = new Padding(4, 5, 4, 5);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(171, 33);
            cmbGrupo.TabIndex = 5;
            
            txtSueldo.Location = new Point(279, 398);
            txtSueldo.Margin = new Padding(4, 5, 4, 5);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(284, 31);
            txtSueldo.TabIndex = 6;
            
            chkSeguroMedico.AutoSize = true;
            chkSeguroMedico.Location = new Point(279, 465);
            chkSeguroMedico.Margin = new Padding(4, 5, 4, 5);
            chkSeguroMedico.Name = "chkSeguroMedico";
            chkSeguroMedico.Size = new Size(159, 29);
            chkSeguroMedico.TabIndex = 7;
            chkSeguroMedico.Text = "Seguro médico";
            chkSeguroMedico.UseVisualStyleBackColor = true;
           
            btnGenerar.Location = new Point(279, 532);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(286, 50);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar Datos Aleatorios";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(173, 31);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(77, 25);
            lblNumero.TabIndex = 9;
            lblNumero.Text = "Número";
            
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(173, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(74, 192);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(177, 25);
            lblFechaNacimiento.TabIndex = 11;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
           
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(173, 332);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(62, 25);
            lblGrupo.TabIndex = 12;
            lblGrupo.Text = "Grupo";
           
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(173, 401);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(67, 25);
            lblSueldo.TabIndex = 13;
            lblSueldo.Text = "Sueldo";
            
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 617);
            Controls.Add(lblSueldo);
            Controls.Add(lblGrupo);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(lblNumero);
            Controls.Add(btnGenerar);
            Controls.Add(chkSeguroMedico);
            Controls.Add(txtSueldo);
            Controls.Add(cmbGrupo);
            Controls.Add(rbFemenino);
            Controls.Add(rbMasculino);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEmpleado";
            Text = "Empleado";
            Load += frmEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.CheckBox chkSeguroMedico;
        private System.Windows.Forms.Button btnGenerar;
        private Label lblNumero;
        private Label lblNombre;
        private Label lblFechaNacimiento;
        private Label lblGrupo;
        private Label lblSueldo;
    }
}