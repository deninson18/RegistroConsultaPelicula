namespace RegistroConsultaPelicula
{
    partial class RegistroGenero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generoIdtextBox = new System.Windows.Forms.TextBox();
            this.generoGuardar = new System.Windows.Forms.Button();
            this.generoNuevo = new System.Windows.Forms.Button();
            this.generoEliminar = new System.Windows.Forms.Button();
            this.descripcionGenero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genero Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // generoIdtextBox
            // 
            this.generoIdtextBox.Location = new System.Drawing.Point(15, 25);
            this.generoIdtextBox.Name = "generoIdtextBox";
            this.generoIdtextBox.Size = new System.Drawing.Size(224, 20);
            this.generoIdtextBox.TabIndex = 2;
            // 
            // generoGuardar
            // 
            this.generoGuardar.Image = global::RegistroConsultaPelicula.Properties.Resources._1442278118_save;
            this.generoGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generoGuardar.Location = new System.Drawing.Point(15, 186);
            this.generoGuardar.Name = "generoGuardar";
            this.generoGuardar.Size = new System.Drawing.Size(60, 63);
            this.generoGuardar.TabIndex = 4;
            this.generoGuardar.Text = "Guardar";
            this.generoGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.generoGuardar.UseVisualStyleBackColor = true;
            this.generoGuardar.Click += new System.EventHandler(this.generoGuardar_Click);
            // 
            // generoNuevo
            // 
            this.generoNuevo.Image = global::RegistroConsultaPelicula.Properties.Resources._1442278245_edit;
            this.generoNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generoNuevo.Location = new System.Drawing.Point(93, 186);
            this.generoNuevo.Name = "generoNuevo";
            this.generoNuevo.Size = new System.Drawing.Size(64, 63);
            this.generoNuevo.TabIndex = 5;
            this.generoNuevo.Text = "Nuevo";
            this.generoNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.generoNuevo.UseVisualStyleBackColor = true;
            this.generoNuevo.Click += new System.EventHandler(this.generoNuevo_Click);
            // 
            // generoEliminar
            // 
            this.generoEliminar.Image = global::RegistroConsultaPelicula.Properties.Resources.cancel;
            this.generoEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generoEliminar.Location = new System.Drawing.Point(178, 186);
            this.generoEliminar.Name = "generoEliminar";
            this.generoEliminar.Size = new System.Drawing.Size(61, 63);
            this.generoEliminar.TabIndex = 6;
            this.generoEliminar.Text = "Eliminar";
            this.generoEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.generoEliminar.UseVisualStyleBackColor = true;
            this.generoEliminar.Click += new System.EventHandler(this.generoEliminar_Click);
            // 
            // descripcionGenero
            // 
            this.descripcionGenero.Location = new System.Drawing.Point(15, 75);
            this.descripcionGenero.Multiline = true;
            this.descripcionGenero.Name = "descripcionGenero";
            this.descripcionGenero.Size = new System.Drawing.Size(223, 95);
            this.descripcionGenero.TabIndex = 7;
            // 
            // RegistroGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroConsultaPelicula.Properties.Resources.montaje_cine_roulette_2;
            this.ClientSize = new System.Drawing.Size(250, 261);
            this.Controls.Add(this.descripcionGenero);
            this.Controls.Add(this.generoEliminar);
            this.Controls.Add(this.generoNuevo);
            this.Controls.Add(this.generoGuardar);
            this.Controls.Add(this.generoIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroGenero";
            this.Text = "RegistroGenero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox generoIdtextBox;
        private System.Windows.Forms.Button generoGuardar;
        private System.Windows.Forms.Button generoNuevo;
        private System.Windows.Forms.Button generoEliminar;
        private System.Windows.Forms.TextBox descripcionGenero;
    }
}