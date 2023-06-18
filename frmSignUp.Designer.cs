namespace pryGestion
{
    partial class frmSignUp
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
            this.txtNewUsuario = new System.Windows.Forms.TextBox();
            this.txtNewContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.lblUserError = new System.Windows.Forms.Label();
            this.lblErrorNewContra = new System.Windows.Forms.Label();
            this.lblErrorRepetir = new System.Windows.Forms.Label();
            this.lblUsuarioExiste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewUsuario
            // 
            this.txtNewUsuario.Location = new System.Drawing.Point(70, 37);
            this.txtNewUsuario.Name = "txtNewUsuario";
            this.txtNewUsuario.Size = new System.Drawing.Size(115, 20);
            this.txtNewUsuario.TabIndex = 0;
            // 
            // txtNewContraseña
            // 
            this.txtNewContraseña.Location = new System.Drawing.Point(70, 106);
            this.txtNewContraseña.Name = "txtNewContraseña";
            this.txtNewContraseña.Size = new System.Drawing.Size(115, 20);
            this.txtNewContraseña.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(67, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(67, 87);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(70, 223);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(115, 23);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Location = new System.Drawing.Point(90, 252);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(76, 22);
            this.btnInicioSesion.TabIndex = 5;
            this.btnInicioSesion.Text = "Iniciar sesion";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetir.Location = new System.Drawing.Point(67, 153);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(123, 16);
            this.lblRepetir.TabIndex = 6;
            this.lblRepetir.Text = "Repetir Contraseña";
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(70, 172);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.Size = new System.Drawing.Size(115, 20);
            this.txtRepetir.TabIndex = 7;
            // 
            // lblUserError
            // 
            this.lblUserError.AutoSize = true;
            this.lblUserError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUserError.Location = new System.Drawing.Point(87, 60);
            this.lblUserError.Name = "lblUserError";
            this.lblUserError.Size = new System.Drawing.Size(79, 13);
            this.lblUserError.TabIndex = 8;
            this.lblUserError.Text = "Ingrese usuario";
            this.lblUserError.Visible = false;
            // 
            // lblErrorNewContra
            // 
            this.lblErrorNewContra.AutoSize = true;
            this.lblErrorNewContra.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorNewContra.Location = new System.Drawing.Point(77, 129);
            this.lblErrorNewContra.Name = "lblErrorNewContra";
            this.lblErrorNewContra.Size = new System.Drawing.Size(98, 13);
            this.lblErrorNewContra.TabIndex = 9;
            this.lblErrorNewContra.Text = "Ingrese contraseña";
            this.lblErrorNewContra.Visible = false;
            // 
            // lblErrorRepetir
            // 
            this.lblErrorRepetir.AutoSize = true;
            this.lblErrorRepetir.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorRepetir.Location = new System.Drawing.Point(46, 195);
            this.lblErrorRepetir.Name = "lblErrorRepetir";
            this.lblErrorRepetir.Size = new System.Drawing.Size(174, 13);
            this.lblErrorRepetir.TabIndex = 10;
            this.lblErrorRepetir.Text = "Ingrese nuevamente su contraseña";
            this.lblErrorRepetir.Visible = false;
            // 
            // lblUsuarioExiste
            // 
            this.lblUsuarioExiste.AutoSize = true;
            this.lblUsuarioExiste.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUsuarioExiste.Location = new System.Drawing.Point(82, 73);
            this.lblUsuarioExiste.Name = "lblUsuarioExiste";
            this.lblUsuarioExiste.Size = new System.Drawing.Size(93, 13);
            this.lblUsuarioExiste.TabIndex = 11;
            this.lblUsuarioExiste.Text = "Usuario esxistente";
            this.lblUsuarioExiste.Visible = false;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 332);
            this.Controls.Add(this.lblUsuarioExiste);
            this.Controls.Add(this.lblErrorRepetir);
            this.Controls.Add(this.lblErrorNewContra);
            this.Controls.Add(this.lblUserError);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtNewContraseña);
            this.Controls.Add(this.txtNewUsuario);
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewUsuario;
        private System.Windows.Forms.TextBox txtNewContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Label lblRepetir;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.Label lblUserError;
        private System.Windows.Forms.Label lblErrorNewContra;
        private System.Windows.Forms.Label lblErrorRepetir;
        private System.Windows.Forms.Label lblUsuarioExiste;
    }
}