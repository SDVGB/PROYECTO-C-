namespace PROYECTO_A
{
    partial class CONSULTA
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
            this.PRIORIDAD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.CONSULTAR_R = new System.Windows.Forms.DataGridView();
            this.USUARIO = new System.Windows.Forms.TextBox();
            this.pendiente = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.R = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CONSULTAR_R)).BeginInit();
            this.SuspendLayout();
            // 
            // PRIORIDAD
            // 
            this.PRIORIDAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PRIORIDAD.FormattingEnabled = true;
            this.PRIORIDAD.Location = new System.Drawing.Point(289, 98);
            this.PRIORIDAD.Name = "PRIORIDAD";
            this.PRIORIDAD.Size = new System.Drawing.Size(225, 21);
            this.PRIORIDAD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Requerimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prioridad";
            // 
            // BUSCAR
            // 
            this.BUSCAR.BackColor = System.Drawing.Color.Red;
            this.BUSCAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BUSCAR.Location = new System.Drawing.Point(665, 196);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BUSCAR.TabIndex = 6;
            this.BUSCAR.Text = "Buscar";
            this.BUSCAR.UseVisualStyleBackColor = false;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // CONSULTAR_R
            // 
            this.CONSULTAR_R.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.CONSULTAR_R.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CONSULTAR_R.Location = new System.Drawing.Point(12, 219);
            this.CONSULTAR_R.Name = "CONSULTAR_R";
            this.CONSULTAR_R.Size = new System.Drawing.Size(728, 150);
            this.CONSULTAR_R.TabIndex = 7;
            this.CONSULTAR_R.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CONSULTAR_R_CellContentClick);
            // 
            // USUARIO
            // 
            this.USUARIO.BackColor = System.Drawing.Color.Gainsboro;
            this.USUARIO.ForeColor = System.Drawing.Color.Black;
            this.USUARIO.Location = new System.Drawing.Point(36, 12);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            this.USUARIO.Size = new System.Drawing.Size(100, 20);
            this.USUARIO.TabIndex = 8;
            // 
            // pendiente
            // 
            this.pendiente.AutoSize = true;
            this.pendiente.Checked = true;
            this.pendiente.Location = new System.Drawing.Point(26, 196);
            this.pendiente.Name = "pendiente";
            this.pendiente.Size = new System.Drawing.Size(78, 17);
            this.pendiente.TabIndex = 9;
            this.pendiente.TabStop = true;
            this.pendiente.Text = "Pendientes";
            this.pendiente.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 196);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Resueltos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.Red;
            this.R.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R.ForeColor = System.Drawing.Color.White;
            this.R.FormattingEnabled = true;
            this.R.Location = new System.Drawing.Point(36, 98);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(225, 21);
            this.R.TabIndex = 11;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminar.Location = new System.Drawing.Point(26, 384);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 12;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.Red;
            this.Modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modificar.Location = new System.Drawing.Point(129, 384);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 13;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // CONSULTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.R);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.pendiente);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.CONSULTAR_R);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PRIORIDAD);
            this.Name = "CONSULTA";
            this.Text = "CONSULTAR REQUERIMIENTOS";
            this.Load += new System.EventHandler(this.CONSULTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CONSULTAR_R)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PRIORIDAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.DataGridView CONSULTAR_R;
        private System.Windows.Forms.TextBox USUARIO;
        private System.Windows.Forms.RadioButton pendiente;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox R;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
    }
}