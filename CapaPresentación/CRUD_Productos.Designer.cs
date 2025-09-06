namespace CapaPresentación
{
    partial class CRUD_Productos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtMarca = new TextBox();
            txtDesc = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(502, 285);
            dataGridView1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(610, 273);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(208, 42);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(164, 303);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(52, 303);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button3_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(638, 212);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(180, 23);
            txtStock.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(638, 170);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(180, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(638, 118);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(180, 23);
            txtMarca.TabIndex = 6;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(638, 72);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(180, 23);
            txtDesc.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(638, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(555, 220);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 178);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 126);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 11;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 80);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 12;
            label4.Text = "Descripciòn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 33);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(427, 303);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // CRUD_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 353);
            Controls.Add(btnLimpiar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(txtDesc);
            Controls.Add(txtMarca);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Name = "CRUD_Productos";
            Text = "CRUD_Productos (Biblioteca)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtMarca;
        private TextBox txtDesc;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLimpiar;
    }
}
