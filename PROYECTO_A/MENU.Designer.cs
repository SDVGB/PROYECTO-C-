namespace PROYECTO_A
{
    partial class MENU
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
            this.CONSULTAR = new System.Windows.Forms.Button();
            this.INGRESO = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CONSULTAR
            // 
            this.CONSULTAR.BackColor = System.Drawing.Color.Red;
            this.CONSULTAR.ForeColor = System.Drawing.Color.White;
            this.CONSULTAR.Location = new System.Drawing.Point(203, 150);
            this.CONSULTAR.Name = "CONSULTAR";
            this.CONSULTAR.Size = new System.Drawing.Size(126, 75);
            this.CONSULTAR.TabIndex = 0;
            this.CONSULTAR.Text = "CONSULTAR REQUERIMIENTOS";
            this.CONSULTAR.UseVisualStyleBackColor = false;
            this.CONSULTAR.Click += new System.EventHandler(this.CONSULTAR_Click);
            // 
            // INGRESO
            // 
            this.INGRESO.BackColor = System.Drawing.Color.Tomato;
            this.INGRESO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.INGRESO.Location = new System.Drawing.Point(3, 150);
            this.INGRESO.Name = "INGRESO";
            this.INGRESO.Size = new System.Drawing.Size(126, 75);
            this.INGRESO.TabIndex = 1;
            this.INGRESO.Text = "INGRESAR REQUERIMIENTOS";
            this.INGRESO.UseVisualStyleBackColor = false;
            this.INGRESO.Click += new System.EventHandler(this.INGRESO_Click_1);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Usuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usuario.Location = new System.Drawing.Point(21, 27);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(289, 35);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "\"Bienvenido Usuario\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(331, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.INGRESO);
            this.Controls.Add(this.CONSULTAR);
            this.Name = "MENU";
            this.Text = "GESTOR DE REQUERIMIENTOS";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CONSULTAR;
        private System.Windows.Forms.Button INGRESO;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label1;
    }
}