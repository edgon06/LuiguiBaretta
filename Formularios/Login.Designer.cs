namespace LuiguiBaretta
{
    partial class Login
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
            this.ButtonIniciarSesion = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.Label();
            this.texboxPassword = new System.Windows.Forms.TextBox();
            this.comboboxUser = new System.Windows.Forms.ComboBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonIniciarSesion
            // 
            this.ButtonIniciarSesion.Location = new System.Drawing.Point(96, 94);
            this.ButtonIniciarSesion.Name = "ButtonIniciarSesion";
            this.ButtonIniciarSesion.Size = new System.Drawing.Size(109, 23);
            this.ButtonIniciarSesion.TabIndex = 9;
            this.ButtonIniciarSesion.Text = "Iniciar Sesión";
            this.ButtonIniciarSesion.UseVisualStyleBackColor = true;
            this.ButtonIniciarSesion.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(24, 58);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(64, 13);
            this.Contraseña.TabIndex = 8;
            this.Contraseña.Text = "Contraseña:";
            // 
            // texboxPassword
            // 
            this.texboxPassword.Location = new System.Drawing.Point(96, 55);
            this.texboxPassword.Name = "texboxPassword";
            this.texboxPassword.PasswordChar = '*';
            this.texboxPassword.Size = new System.Drawing.Size(160, 20);
            this.texboxPassword.TabIndex = 7;
            // 
            // comboboxUser
            // 
            this.comboboxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxUser.FormattingEnabled = true;
            this.comboboxUser.Location = new System.Drawing.Point(96, 28);
            this.comboboxUser.Name = "comboboxUser";
            this.comboboxUser.Size = new System.Drawing.Size(160, 21);
            this.comboboxUser.TabIndex = 6;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(24, 31);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(46, 13);
            this.Usuario.TabIndex = 5;
            this.Usuario.Text = "Usuario:";
            // 
            // Login
            // 
            this.AcceptButton = this.ButtonIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 141);
            this.Controls.Add(this.ButtonIniciarSesion);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.texboxPassword);
            this.Controls.Add(this.comboboxUser);
            this.Controls.Add(this.Usuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 180);
            this.MinimumSize = new System.Drawing.Size(314, 180);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de seción";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonIniciarSesion;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox texboxPassword;
        private System.Windows.Forms.ComboBox comboboxUser;
        private System.Windows.Forms.Label Usuario;
    }
}