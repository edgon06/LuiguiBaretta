namespace LuiguiBaretta.Formularios.Módulos
{
    partial class FormInventario
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
            this.PanelInventario = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridViewInventario = new System.Windows.Forms.DataGridView();
            this.PanelBotonesInventario = new System.Windows.Forms.Panel();
            this.ButtonProductosAgotados = new System.Windows.Forms.Button();
            this.ButtonVerTodosLosProductos = new System.Windows.Forms.Button();
            this.ButtonProductosAgotandose = new System.Windows.Forms.Button();
            this.ButtonEditarProducto = new System.Windows.Forms.Button();
            this.ButtonNuevoProducto = new System.Windows.Forms.Button();
            this.PanelInventario.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInventario)).BeginInit();
            this.PanelBotonesInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInventario
            // 
            this.PanelInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.PanelInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInventario.Controls.Add(this.panel4);
            this.PanelInventario.Location = new System.Drawing.Point(0, 57);
            this.PanelInventario.Name = "PanelInventario";
            this.PanelInventario.Size = new System.Drawing.Size(750, 443);
            this.PanelInventario.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Controls.Add(this.DataGridViewInventario);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 433);
            this.panel4.TabIndex = 2;
            // 
            // DataGridViewInventario
            // 
            this.DataGridViewInventario.AllowUserToAddRows = false;
            this.DataGridViewInventario.AllowUserToDeleteRows = false;
            this.DataGridViewInventario.AllowUserToResizeColumns = false;
            this.DataGridViewInventario.AllowUserToResizeRows = false;
            this.DataGridViewInventario.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.DataGridViewInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInventario.Location = new System.Drawing.Point(5, 5);
            this.DataGridViewInventario.Name = "DataGridViewInventario";
            this.DataGridViewInventario.ReadOnly = true;
            this.DataGridViewInventario.RowHeadersVisible = false;
            this.DataGridViewInventario.Size = new System.Drawing.Size(730, 423);
            this.DataGridViewInventario.TabIndex = 1;
            this.DataGridViewInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInventario_CellClick);
            // 
            // PanelBotonesInventario
            // 
            this.PanelBotonesInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.PanelBotonesInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBotonesInventario.Controls.Add(this.ButtonProductosAgotados);
            this.PanelBotonesInventario.Controls.Add(this.ButtonVerTodosLosProductos);
            this.PanelBotonesInventario.Controls.Add(this.ButtonProductosAgotandose);
            this.PanelBotonesInventario.Controls.Add(this.ButtonEditarProducto);
            this.PanelBotonesInventario.Controls.Add(this.ButtonNuevoProducto);
            this.PanelBotonesInventario.Location = new System.Drawing.Point(0, 0);
            this.PanelBotonesInventario.Name = "PanelBotonesInventario";
            this.PanelBotonesInventario.Size = new System.Drawing.Size(750, 51);
            this.PanelBotonesInventario.TabIndex = 30;
            // 
            // ButtonProductosAgotados
            // 
            this.ButtonProductosAgotados.Location = new System.Drawing.Point(307, 2);
            this.ButtonProductosAgotados.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonProductosAgotados.Name = "ButtonProductosAgotados";
            this.ButtonProductosAgotados.Size = new System.Drawing.Size(98, 46);
            this.ButtonProductosAgotados.TabIndex = 6;
            this.ButtonProductosAgotados.Text = "Ver Productos Agotados";
            this.ButtonProductosAgotados.UseVisualStyleBackColor = true;
            this.ButtonProductosAgotados.Click += new System.EventHandler(this.ButtonProductosAgotados_Click);
            // 
            // ButtonVerTodosLosProductos
            // 
            this.ButtonVerTodosLosProductos.Location = new System.Drawing.Point(409, 2);
            this.ButtonVerTodosLosProductos.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonVerTodosLosProductos.Name = "ButtonVerTodosLosProductos";
            this.ButtonVerTodosLosProductos.Size = new System.Drawing.Size(98, 46);
            this.ButtonVerTodosLosProductos.TabIndex = 5;
            this.ButtonVerTodosLosProductos.Text = "Ver Todos Los Productos";
            this.ButtonVerTodosLosProductos.UseVisualStyleBackColor = true;
            this.ButtonVerTodosLosProductos.Click += new System.EventHandler(this.ButtonVerTodosLosProductos_Click);
            // 
            // ButtonProductosAgotandose
            // 
            this.ButtonProductosAgotandose.Location = new System.Drawing.Point(205, 2);
            this.ButtonProductosAgotandose.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonProductosAgotandose.Name = "ButtonProductosAgotandose";
            this.ButtonProductosAgotandose.Size = new System.Drawing.Size(98, 46);
            this.ButtonProductosAgotandose.TabIndex = 4;
            this.ButtonProductosAgotandose.Text = "Ver Productos Agotandose";
            this.ButtonProductosAgotandose.UseVisualStyleBackColor = true;
            this.ButtonProductosAgotandose.Click += new System.EventHandler(this.ButtonProductosAgotandose_Click);
            // 
            // ButtonEditarProducto
            // 
            this.ButtonEditarProducto.Location = new System.Drawing.Point(103, 2);
            this.ButtonEditarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEditarProducto.Name = "ButtonEditarProducto";
            this.ButtonEditarProducto.Size = new System.Drawing.Size(98, 46);
            this.ButtonEditarProducto.TabIndex = 3;
            this.ButtonEditarProducto.Text = "Editar Producto";
            this.ButtonEditarProducto.UseVisualStyleBackColor = true;
            this.ButtonEditarProducto.Click += new System.EventHandler(this.ButtonEditarProducto_Click);
            // 
            // ButtonNuevoProducto
            // 
            this.ButtonNuevoProducto.Location = new System.Drawing.Point(3, 2);
            this.ButtonNuevoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNuevoProducto.Name = "ButtonNuevoProducto";
            this.ButtonNuevoProducto.Size = new System.Drawing.Size(98, 46);
            this.ButtonNuevoProducto.TabIndex = 2;
            this.ButtonNuevoProducto.Text = "Nuevo Producto";
            this.ButtonNuevoProducto.UseVisualStyleBackColor = true;
            this.ButtonNuevoProducto.Click += new System.EventHandler(this.ButtonNuevoProducto_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.PanelInventario);
            this.Controls.Add(this.PanelBotonesInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventario";
            this.Text = "Form1";
            this.PanelInventario.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInventario)).EndInit();
            this.PanelBotonesInventario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInventario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DataGridViewInventario;
        private System.Windows.Forms.Panel PanelBotonesInventario;
        public System.Windows.Forms.Button ButtonProductosAgotados;
        public System.Windows.Forms.Button ButtonVerTodosLosProductos;
        public System.Windows.Forms.Button ButtonProductosAgotandose;
        public System.Windows.Forms.Button ButtonEditarProducto;
        public System.Windows.Forms.Button ButtonNuevoProducto;
    }
}