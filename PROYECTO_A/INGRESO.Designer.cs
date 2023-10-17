namespace PROYECTO_A
{
    partial class INGRESO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INGRESO));
            this.USUARIO = new System.Windows.Forms.TextBox();
            this.CLAVE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INGRESAR = new System.Windows.Forms.Button();
            this.VER = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // USUARIO
            // 
            this.USUARIO.Location = new System.Drawing.Point(96, 102);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(100, 20);
            this.USUARIO.TabIndex = 0;
            this.USUARIO.Text = "blisbos";
            // 
            // CLAVE
            // 
            this.CLAVE.Location = new System.Drawing.Point(96, 212);
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.Size = new System.Drawing.Size(100, 20);
            this.CLAVE.TabIndex = 1;
            this.CLAVE.Text = "123456";
            this.CLAVE.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // INGRESAR
            // 
            this.INGRESAR.BackColor = System.Drawing.Color.Red;
            this.INGRESAR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGRESAR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.INGRESAR.Location = new System.Drawing.Point(82, 260);
            this.INGRESAR.Name = "INGRESAR";
            this.INGRESAR.Size = new System.Drawing.Size(145, 31);
            this.INGRESAR.TabIndex = 4;
            this.INGRESAR.Text = "Ingresar";
            this.INGRESAR.UseVisualStyleBackColor = false;
            this.INGRESAR.Click += new System.EventHandler(this.INGRESAR_Click);
            // 
            // VER
            // 
            this.VER.BackColor = System.Drawing.Color.Red;
            this.VER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VER.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VER.Location = new System.Drawing.Point(202, 212);
            this.VER.Name = "VER";
            this.VER.Size = new System.Drawing.Size(63, 29);
            this.VER.TabIndex = 5;
            this.VER.Text = "Ver";
            this.VER.UseVisualStyleBackColor = false;
            this.VER.Click += new System.EventHandler(this.VER_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "INGRESO";
            // 
            // INGRESO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VER);
            this.Controls.Add(this.INGRESAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLAVE);
            this.Controls.Add(this.USUARIO);
            this.Name = "INGRESO";
            this.Text = "GESTOR DE REQUERIMIENTOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox USUARIO;
        private System.Windows.Forms.TextBox CLAVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button INGRESAR;
        private System.Windows.Forms.Button VER;
        private System.Windows.Forms.Label label3;
    }
}

