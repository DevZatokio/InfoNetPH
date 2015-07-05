namespace AlmacenStock
{
    partial class ListadodeProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadodeProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadListado = new System.Windows.Forms.TextBox();
            this.dateProducto = new System.Windows.Forms.DateTimePicker();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txtPrecioListado = new System.Windows.Forms.TextBox();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.lbTotalListado = new System.Windows.Forms.Label();
            this.txtTotallistado = new System.Windows.Forms.TextBox();
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscarListados = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // txtCantidadListado
            // 
            this.txtCantidadListado.Location = new System.Drawing.Point(137, 230);
            this.txtCantidadListado.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadListado.Name = "txtCantidadListado";
            this.txtCantidadListado.Size = new System.Drawing.Size(59, 26);
            this.txtCantidadListado.TabIndex = 3;
            // 
            // dateProducto
            // 
            this.dateProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateProducto.Location = new System.Drawing.Point(402, 230);
            this.dateProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dateProducto.Name = "dateProducto";
            this.dateProducto.Size = new System.Drawing.Size(260, 26);
            this.dateProducto.TabIndex = 6;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(203, 233);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(46, 18);
            this.lbPrecio.TabIndex = 8;
            this.lbPrecio.Text = "Precio";
            // 
            // txtPrecioListado
            // 
            this.txtPrecioListado.Location = new System.Drawing.Point(255, 230);
            this.txtPrecioListado.Name = "txtPrecioListado";
            this.txtPrecioListado.Size = new System.Drawing.Size(121, 26);
            this.txtPrecioListado.TabIndex = 9;
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarLista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarLista.Image = global::AlmacenStock.Properties.Resources.add;
            this.btnAgregarLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLista.Location = new System.Drawing.Point(674, 89);
            this.btnAgregarLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(95, 48);
            this.btnAgregarLista.TabIndex = 5;
            this.btnAgregarLista.Text = "AGREGAR";
            this.btnAgregarLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarLista.UseVisualStyleBackColor = true;
            this.btnAgregarLista.Click += new System.EventHandler(this.btnAgregarLista_Click);
            // 
            // lbTotalListado
            // 
            this.lbTotalListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalListado.AutoSize = true;
            this.lbTotalListado.Location = new System.Drawing.Point(631, 496);
            this.lbTotalListado.Name = "lbTotalListado";
            this.lbTotalListado.Size = new System.Drawing.Size(40, 18);
            this.lbTotalListado.TabIndex = 10;
            this.lbTotalListado.Text = "Total";
            // 
            // txtTotallistado
            // 
            this.txtTotallistado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotallistado.Enabled = false;
            this.txtTotallistado.Location = new System.Drawing.Point(678, 493);
            this.txtTotallistado.Name = "txtTotallistado";
            this.txtTotallistado.Size = new System.Drawing.Size(100, 26);
            this.txtTotallistado.TabIndex = 11;
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoProductos.Location = new System.Drawing.Point(61, 67);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dgvListadoProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoProductos.Size = new System.Drawing.Size(601, 156);
            this.dgvListadoProductos.TabIndex = 12;
            this.dgvListadoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProductos_CellContentClick);
            // 
            // txtBuscarListados
            // 
            this.txtBuscarListados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarListados.Location = new System.Drawing.Point(61, 26);
            this.txtBuscarListados.Name = "txtBuscarListados";
            this.txtBuscarListados.Size = new System.Drawing.Size(504, 26);
            this.txtBuscarListados.TabIndex = 13;
            this.txtBuscarListados.TextChanged += new System.EventHandler(this.txtBuscarListados_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 202);
            this.dataGridView1.TabIndex = 14;
            // 
            // ListadodeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(840, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscarListados);
            this.Controls.Add(this.dgvListadoProductos);
            this.Controls.Add(this.txtTotallistado);
            this.Controls.Add(this.lbTotalListado);
            this.Controls.Add(this.txtPrecioListado);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.dateProducto);
            this.Controls.Add(this.btnAgregarLista);
            this.Controls.Add(this.txtCantidadListado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListadodeProductos";
            this.Text = "ListadodeProductos";
            this.Load += new System.EventHandler(this.ListadodeProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadListado;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.DateTimePicker dateProducto;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txtPrecioListado;
        private System.Windows.Forms.Label lbTotalListado;
        private System.Windows.Forms.TextBox txtTotallistado;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private System.Windows.Forms.TextBox txtBuscarListados;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}