namespace GestionVenta.VISTA.DetalleVentaVistas
{
    partial class DetalleVentaListarVista
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
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NombreProducto = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            TotalDetalle = new DataGridViewTextBoxColumn();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 33);
            label3.Name = "label3";
            label3.Size = new Size(100, 38);
            label3.TabIndex = 31;
            label3.Text = "VENTA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(280, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(307, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 150);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 29;
            label2.Text = "FECHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 210);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 28;
            label1.Text = "TOTAL VENTA";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, PrecioUnitario, Cantidad, TotalDetalle });
            dataGridView1.Location = new Point(131, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(707, 274);
            dataGridView1.TabIndex = 26;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre del Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 200;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            PrecioUnitario.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // TotalDetalle
            // 
            TotalDetalle.HeaderText = "Total Detalle";
            TotalDetalle.MinimumWidth = 6;
            TotalDetalle.Name = "TotalDetalle";
            TotalDetalle.ReadOnly = true;
            TotalDetalle.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 210);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 32;
            label4.Text = "VENTA";
            // 
            // DetalleVentaListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 626);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "DetalleVentaListarVista";
            Text = "DetalleVentaListarVista";
            Load += DetalleVentaListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn TotalDetalle;
        private Label label4;
    }
}