namespace LuiguiBaretta
{
    partial class login
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.Label();
            this.texboxPassword = new System.Windows.Forms.TextBox();
            this.comboboxUser = new System.Windows.Forms.ComboBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(178, 119);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(109, 23);
            this.Aceptar.TabIndex = 9;
            this.Aceptar.Text = "Iniciar Sesión";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(55, 84);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(64, 13);
            this.Contraseña.TabIndex = 8;
            this.Contraseña.Text = "Contraseña:";
            // 
            // texboxPassword
            // 
            this.texboxPassword.Location = new System.Drawing.Point(127, 81);
            this.texboxPassword.Name = "texboxPassword";
            this.texboxPassword.PasswordChar = '*';
            this.texboxPassword.Size = new System.Drawing.Size(160, 20);
            this.texboxPassword.TabIndex = 7;
            // 
            // comboboxUser
            // 
            this.comboboxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxUser.FormattingEnabled = true;
            this.comboboxUser.Location = new System.Drawing.Point(127, 54);
            this.comboboxUser.Name = "comboboxUser";
            this.comboboxUser.Size = new System.Drawing.Size(160, 21);
            this.comboboxUser.TabIndex = 6;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(55, 57);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(46, 13);
            this.Usuario.TabIndex = 5;
            this.Usuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inicio de seción";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.texboxPassword);
            this.Controls.Add(this.comboboxUser);
            this.Controls.Add(this.Usuario);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de seción";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox texboxPassword;
        private System.Windows.Forms.ComboBox comboboxUser;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label1;
    }
}