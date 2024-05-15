namespace ProyectoFinalAlgebra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCarnet = new System.Windows.Forms.TextBox();
            this.TextBoxResultado = new System.Windows.Forms.TextBox();
            this.SwitchGenerar = new System.Windows.Forms.Button();
            this.SwitchLimpiar = new System.Windows.Forms.Button();
            this.SwitchGuardar = new System.Windows.Forms.Button();
            this.ImagenPic = new System.Windows.Forms.PictureBox();
            this.QR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Número de Carnet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(718, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuevo Carnet";
            // 
            // TextBoxCarnet
            // 
            this.TextBoxCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TextBoxCarnet.Location = new System.Drawing.Point(38, 100);
            this.TextBoxCarnet.Multiline = true;
            this.TextBoxCarnet.Name = "TextBoxCarnet";
            this.TextBoxCarnet.Size = new System.Drawing.Size(499, 41);
            this.TextBoxCarnet.TabIndex = 2;
            // 
            // TextBoxResultado
            // 
            this.TextBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TextBoxResultado.Location = new System.Drawing.Point(639, 100);
            this.TextBoxResultado.Multiline = true;
            this.TextBoxResultado.Name = "TextBoxResultado";
            this.TextBoxResultado.Size = new System.Drawing.Size(382, 41);
            this.TextBoxResultado.TabIndex = 3;
            this.TextBoxResultado.Visible = false;
            this.TextBoxResultado.TextChanged += new System.EventHandler(this.TextBoxResultado_TextChanged);
            // 
            // SwitchGenerar
            // 
            this.SwitchGenerar.BackColor = System.Drawing.Color.Snow;
            this.SwitchGenerar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchGenerar.Location = new System.Drawing.Point(639, 166);
            this.SwitchGenerar.Name = "SwitchGenerar";
            this.SwitchGenerar.Size = new System.Drawing.Size(382, 84);
            this.SwitchGenerar.TabIndex = 4;
            this.SwitchGenerar.Text = "Generar Nuevo Carnet y Codigo QR para Escanear";
            this.SwitchGenerar.UseVisualStyleBackColor = false;
            this.SwitchGenerar.Click += new System.EventHandler(this.SwitchGenerar_Click);
            // 
            // SwitchLimpiar
            // 
            this.SwitchLimpiar.BackColor = System.Drawing.Color.Snow;
            this.SwitchLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchLimpiar.Location = new System.Drawing.Point(639, 284);
            this.SwitchLimpiar.Name = "SwitchLimpiar";
            this.SwitchLimpiar.Size = new System.Drawing.Size(184, 104);
            this.SwitchLimpiar.TabIndex = 5;
            this.SwitchLimpiar.Text = "Limpiar";
            this.SwitchLimpiar.UseVisualStyleBackColor = false;
            this.SwitchLimpiar.Click += new System.EventHandler(this.SwitchLimpiar_Click);
            // 
            // SwitchGuardar
            // 
            this.SwitchGuardar.BackColor = System.Drawing.Color.Snow;
            this.SwitchGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchGuardar.Location = new System.Drawing.Point(847, 284);
            this.SwitchGuardar.Name = "SwitchGuardar";
            this.SwitchGuardar.Size = new System.Drawing.Size(174, 104);
            this.SwitchGuardar.TabIndex = 6;
            this.SwitchGuardar.Text = "Guardar Carnet";
            this.SwitchGuardar.UseVisualStyleBackColor = false;
            this.SwitchGuardar.Click += new System.EventHandler(this.SwitchGuardar_Click);
            // 
            // ImagenPic
            // 
            this.ImagenPic.Location = new System.Drawing.Point(674, 491);
            this.ImagenPic.Name = "ImagenPic";
            this.ImagenPic.Size = new System.Drawing.Size(100, 50);
            this.ImagenPic.TabIndex = 7;
            this.ImagenPic.TabStop = false;
            this.ImagenPic.Click += new System.EventHandler(this.ImagenPic_Click);
            // 
            // QR
            // 
            this.QR.Location = new System.Drawing.Point(38, 177);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(499, 416);
            this.QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QR.TabIndex = 8;
            this.QR.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1072, 656);
            this.Controls.Add(this.QR);
            this.Controls.Add(this.ImagenPic);
            this.Controls.Add(this.SwitchGuardar);
            this.Controls.Add(this.SwitchLimpiar);
            this.Controls.Add(this.SwitchGenerar);
            this.Controls.Add(this.TextBoxResultado);
            this.Controls.Add(this.TextBoxCarnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCarnet;
        private System.Windows.Forms.TextBox TextBoxResultado;
        private System.Windows.Forms.Button SwitchGenerar;
        private System.Windows.Forms.Button SwitchLimpiar;
        private System.Windows.Forms.Button SwitchGuardar;
        private System.Windows.Forms.PictureBox ImagenPic;
        private System.Windows.Forms.PictureBox QR;
    }
}

