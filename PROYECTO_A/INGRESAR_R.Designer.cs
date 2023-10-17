namespace PROYECTO_A
{
    partial class INGRESAR
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
            this.REQUERIMIENTOS = new System.Windows.Forms.ComboBox();
            this.PRIORIDAD = new System.Windows.Forms.ComboBox();
            this.USUARIO = new System.Windows.Forms.ComboBox();
            this.G = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.DESCRIPCION = new System.Windows.Forms.TextBox();
            this.L = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // REQUERIMIENTOS
            // 
            this.REQUERIMIENTOS.BackColor = System.Drawing.Color.Tomato;
            this.REQUERIMIENTOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.REQUERIMIENTOS.ForeColor = System.Drawing.Color.White;
            this.REQUERIMIENTOS.FormattingEnabled = true;
            this.REQUERIMIENTOS.Location = new System.Drawing.Point(143, 64);
            this.REQUERIMIENTOS.Name = "REQUERIMIENTOS";
            this.REQUERIMIENTOS.Size = new System.Drawing.Size(121, 21);
            this.REQUERIMIENTOS.TabIndex = 0;
            // 
            // PRIORIDAD
            // 
            this.PRIORIDAD.BackColor = System.Drawing.Color.Tomato;
            this.PRIORIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PRIORIDAD.ForeColor = System.Drawing.Color.White;
            this.PRIORIDAD.FormattingEnabled = true;
            this.PRIORIDAD.Location = new System.Drawing.Point(143, 326);
            this.PRIORIDAD.Name = "PRIORIDAD";
            this.PRIORIDAD.Size = new System.Drawing.Size(121, 21);
            this.PRIORIDAD.TabIndex = 1;
            // 
            // USUARIO
            // 
            this.USUARIO.BackColor = System.Drawing.Color.Tomato;
            this.USUARIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.USUARIO.ForeColor = System.Drawing.Color.White;
            this.USUARIO.FormattingEnabled = true;
            this.USUARIO.Location = new System.Drawing.Point(143, 130);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(121, 21);
            this.USUARIO.TabIndex = 2;
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Tomato;
            this.G.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.G.Location = new System.Drawing.Point(31, 381);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(75, 20);
            this.G.TabIndex = 3;
            this.G.Text = "Guardar";
            this.G.UseVisualStyleBackColor = false;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // I
            // 
            this.I.BackColor = System.Drawing.Color.Tomato;
            this.I.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.I.Location = new System.Drawing.Point(208, 381);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(157, 20);
            this.I.TabIndex = 4;
            this.I.Text = "Ir a Listar Requerimientos";
            this.I.UseVisualStyleBackColor = false;
            this.I.Click += new System.EventHandler(this.I_Click);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(20, 64);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(117, 13);
            this.R.TabIndex = 6;
            this.R.Text = "Tipo de Requerimiento:";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(28, 202);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(146, 13);
            this.D.TabIndex = 10;
            this.D.Text = "Descripcion del requerimiento";
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Location = new System.Drawing.Point(74, 130);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(63, 13);
            this.U.TabIndex = 11;
            this.U.Text = "Asignado a:";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(89, 329);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(48, 13);
            this.P.TabIndex = 12;
            this.P.Text = "Prioridad";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Location = new System.Drawing.Point(31, 218);
            this.DESCRIPCION.Multiline = true;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Size = new System.Drawing.Size(330, 85);
            this.DESCRIPCION.TabIndex = 13;
            // 
            // L
            // 
            this.L.BackColor = System.Drawing.Color.Tomato;
            this.L.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L.Location = new System.Drawing.Point(112, 381);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(75, 20);
            this.L.TabIndex = 14;
            this.L.Text = "Limpiar";
            this.L.UseVisualStyleBackColor = false;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // INGRESAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.L);
            this.Controls.Add(this.DESCRIPCION);
            this.Controls.Add(this.P);
            this.Controls.Add(this.U);
            this.Controls.Add(this.D);
            this.Controls.Add(this.R);
            this.Controls.Add(this.I);
            this.Controls.Add(this.G);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.PRIORIDAD);
            this.Controls.Add(this.REQUERIMIENTOS);
            this.Name = "INGRESAR";
            this.Text = "INGRESAR REQUERIMIETOS";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox REQUERIMIENTOS;
        private System.Windows.Forms.ComboBox PRIORIDAD;
        private System.Windows.Forms.ComboBox USUARIO;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label U;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.TextBox DESCRIPCION;
        private System.Windows.Forms.Button L;
    }
}