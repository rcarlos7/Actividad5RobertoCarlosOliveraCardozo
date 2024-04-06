namespace GestionVenta.VISTA.DetalleVentaVistas
{
    partial class DetalleVentaInsertarVista
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
            dataGridView1 = new DataGridView();
            NombreProducto = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            TotalDetalle = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, PrecioUnitario, Cantidad, TotalDetalle });
            dataGridView1.Location = new Point(48, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(707, 274);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
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
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(783, 91);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(459, 420);
            dataGridView2.TabIndex = 16;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(464, 561);
            button2.Name = "button2";
            button2.Size = new Size(291, 54);
            button2.TabIndex = 18;
            button2.Text = "GUARDAR VENTA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 163);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 20;
            label1.Text = "TOTAL VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 103);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 21;
            label2.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(197, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(307, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(464, 21);
            label3.Name = "label3";
            label3.Size = new Size(247, 38);
            label3.TabIndex = 23;
            label3.Text = "REGISTRAR VENTA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(783, 57);
            label4.Name = "label4";
            label4.Size = new Size(309, 17);
            label4.TabIndex = 24;
            label4.Text = "DOBLE CLICK PARA SELECCIONAR LOS PRODUCTOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 214);
            label5.Name = "label5";
            label5.Size = new Size(334, 17);
            label5.TabIndex = 25;
            label5.Text = "DOBLE CLICK EN CANTIDAD PARA EDITAR LA CANTIDAD";
            // 
            // DetalleVentaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 640);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "DetalleVentaInsertarVista";
            Text = "DetalleVentaVista";
            Load += DetalleVentaVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn TotalDetalle;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}