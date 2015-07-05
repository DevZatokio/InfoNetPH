namespace AlmacenStock
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioUsuarioToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.crearListaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioUsuarioToolStripMenuItem
            // 
            this.inicioUsuarioToolStripMenuItem.Image = global::AlmacenStock.Properties.Resources.user;
            this.inicioUsuarioToolStripMenuItem.Name = "inicioUsuarioToolStripMenuItem";
            this.inicioUsuarioToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.inicioUsuarioToolStripMenuItem.Text = "Inicio Usuario";
            this.inicioUsuarioToolStripMenuItem.Click += new System.EventHandler(this.inicioUsuarioToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Image = global::AlmacenStock.Properties.Resources.package;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // ingresarProductosToolStripMenuItem
            // 
            this.ingresarProductosToolStripMenuItem.Name = "ingresarProductosToolStripMenuItem";
            this.ingresarProductosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ingresarProductosToolStripMenuItem.Text = "Ingresar Productos";
            this.ingresarProductosToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductosToolStripMenuItem_Click);
            // 
            // crearListaToolStripMenuItem
            // 
            this.crearListaToolStripMenuItem.Image = global::AlmacenStock.Properties.Resources.book;
            this.crearListaToolStripMenuItem.Name = "crearListaToolStripMenuItem";
            this.crearListaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.crearListaToolStripMenuItem.Text = "Crear Lista";
            this.crearListaToolStripMenuItem.Click += new System.EventHandler(this.crearListaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = global::AlmacenStock.Properties.Resources.report;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuPrincipal";
            this.Text = "Sistema Bodega";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}

