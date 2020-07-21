namespace LuiguiBaretta.Formularios.Módulos
{
    partial class FormClientes
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
            this.PanelBotonesCliente = new System.Windows.Forms.Panel();
            this.ButtonEditarCliente = new System.Windows.Forms.Button();
            this.ButtonNuevoCliente = new System.Windows.Forms.Button();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.DataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelBotonesCliente.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBotonesCliente
            // 
            this.PanelBotonesCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.PanelBotonesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBotonesCliente.Controls.Add(this.ButtonEditarCliente);
            this.PanelBotonesCliente.Controls.Add(this.ButtonNuevoCliente);
            this.PanelBotonesCliente.Location = new System.Drawing.Point(0, 0);
            this.PanelBotonesCliente.Name = "PanelBotonesCliente";
            this.PanelBotonesCliente.Size = new System.Drawing.Size(750, 51);
            this.PanelBotonesCliente.TabIndex = 29;
            // 
            // ButtonEditarCliente
            // 
            this.ButtonEditarCliente.Location = new System.Drawing.Point(105, 2);
            this.ButtonEditarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEditarCliente.Name = "ButtonEditarCliente";
            this.ButtonEditarCliente.Size = new System.Drawing.Size(98, 46);
            this.ButtonEditarCliente.TabIndex = 2;
            this.ButtonEditarCliente.Text = "Editar Cliente";
            this.ButtonEditarCliente.UseVisualStyleBackColor = true;
            this.ButtonEditarCliente.Click += new System.EventHandler(this.ButtonEditarCliente_Click);
            // 
            // ButtonNuevoCliente
            // 
            this.ButtonNuevoCliente.Location = new System.Drawing.Point(2, 2);
            this.ButtonNuevoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNuevoCliente.Name = "ButtonNuevoCliente";
            this.ButtonNuevoCliente.Size = new System.Drawing.Size(98, 46);
            this.ButtonNuevoCliente.TabIndex = 1;
            this.ButtonNuevoCliente.Text = "Nuevo Cliente";
            this.ButtonNuevoCliente.UseVisualStyleBackColor = true;
            this.ButtonNuevoCliente.Click += new System.EventHandler(this.ButtonNuevoCliente_Click);
            // 
            // PanelCliente
            // 
            this.PanelCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.PanelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCliente.Controls.Add(this.DataGridViewClientes);
            this.PanelCliente.Controls.Add(this.panel3);
            this.PanelCliente.Location = new System.Drawing.Point(0, 57);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(750, 443);
            this.PanelCliente.TabIndex = 30;
            // 
            // DataGridViewClientes
            // 
            this.DataGridViewClientes.AllowUserToAddRows = false;
            this.DataGridViewClientes.AllowUserToDeleteRows = false;
            this.DataGridViewClientes.AllowUserToResizeColumns = false;
            this.DataGridViewClientes.AllowUserToResizeRows = false;
            this.DataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.DataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewClientes.Location = new System.Drawing.Point(57, 40);
            this.DataGridViewClientes.Name = "DataGridViewClientes";
            this.DataGridViewClientes.ReadOnly = true;
            this.DataGridViewClientes.RowHeadersVisible = false;
            this.DataGridViewClientes.Size = new System.Drawing.Size(621, 368);
            this.DataGridViewClientes.TabIndex = 1;
            this.DataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClientes_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(33, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 401);
            this.panel3.TabIndex = 2;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.PanelBotonesCliente);
            this.Controls.Add(this.PanelCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "Form1";
            this.PanelBotonesCliente.ResumeLayout(false);
            this.PanelCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBotonesCliente;
        public System.Windows.Forms.Button ButtonEditarCliente;
        public System.Windows.Forms.Button ButtonNuevoCliente;
        private System.Windows.Forms.Panel PanelCliente;
        public System.Windows.Forms.DataGridView DataGridViewClientes;
        private System.Windows.Forms.Panel panel3;
    }
}