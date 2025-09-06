namespace CapaPresentación
{
    partial class Form2
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
            BtnAcceder = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LbBaseDatos = new Label();
            KbServer = new Label();
            SuspendLayout();
            // 
            // BtnAcceder
            // 
            BtnAcceder.Location = new Point(133, 156);
            BtnAcceder.Name = "BtnAcceder";
            BtnAcceder.Size = new Size(75, 23);
            BtnAcceder.TabIndex = 0;
            BtnAcceder.Text = "&Acceder";
            BtnAcceder.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // LbBaseDatos
            // 
            LbBaseDatos.AutoSize = true;
            LbBaseDatos.Location = new Point(34, 116);
            LbBaseDatos.Name = "LbBaseDatos";
            LbBaseDatos.Size = new Size(64, 15);
            LbBaseDatos.TabIndex = 3;
            LbBaseDatos.Text = "Base Datos";
            // 
            // KbServer
            // 
            KbServer.AutoSize = true;
            KbServer.Location = new Point(34, 60);
            KbServer.Name = "KbServer";
            KbServer.Size = new Size(39, 15);
            KbServer.TabIndex = 4;
            KbServer.Text = "Server";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 261);
            Controls.Add(KbServer);
            Controls.Add(LbBaseDatos);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BtnAcceder);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Acceso a Server/DataBase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAcceder;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LbBaseDatos;
        private Label KbServer;
    }
}