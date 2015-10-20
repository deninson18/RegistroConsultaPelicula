namespace RegistroConsultaPelicula
{
    partial class RegistroActores
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
            this.label3 = new System.Windows.Forms.Label();
            this.ActoresIdtextBox = new System.Windows.Forms.TextBox();
            this.NombreActortextBox = new System.Windows.Forms.TextBox();
            this.ApellidoActortextBox = new System.Windows.Forms.TextBox();
            this.ActorEliminar = new System.Windows.Forms.Button();
            this.ActorNuevo = new System.Windows.Forms.Button();
            this.ActorGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actores Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // ActoresIdtextBox
            // 
            this.ActoresIdtextBox.Location = new System.Drawing.Point(15, 25);
            this.ActoresIdtextBox.Name = "ActoresIdtextBox";
            this.ActoresIdtextBox.Size = new System.Drawing.Size(171, 20);
            this.ActoresIdtextBox.TabIndex = 6;
            // 
            // NombreActortextBox
            // 
            this.NombreActortextBox.Location = new System.Drawing.Point(15, 98);
            this.NombreActortextBox.Name = "NombreActortextBox";
            this.NombreActortextBox.Size = new System.Drawing.Size(257, 20);
            this.NombreActortextBox.TabIndex = 7;
            this.NombreActortextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ApellidoActortextBox
            // 
            this.ApellidoActortextBox.Location = new System.Drawing.Point(15, 149);
            this.ApellidoActortextBox.Name = "ApellidoActortextBox";
            this.ApellidoActortextBox.Size = new System.Drawing.Size(257, 20);
            this.ApellidoActortextBox.TabIndex = 8;
            // 
            // ActorEliminar
            // 
            this.ActorEliminar.Image = global::RegistroConsultaPelicula.Properties.Resources.cancel1;
            this.ActorEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ActorEliminar.Location = new System.Drawing.Point(197, 175);
            this.ActorEliminar.Name = "ActorEliminar";
            this.ActorEliminar.Size = new System.Drawing.Size(75, 61);
            this.ActorEliminar.TabIndex = 2;
            this.ActorEliminar.Text = "Eliminar";
            this.ActorEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ActorEliminar.UseVisualStyleBackColor = true;
            this.ActorEliminar.Click += new System.EventHandler(this.ActorEliminar_Click);
            // 
            // ActorNuevo
            // 
            this.ActorNuevo.Image = global::RegistroConsultaPelicula.Properties.Resources._1442278245_edit;
            this.ActorNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ActorNuevo.Location = new System.Drawing.Point(106, 175);
            this.ActorNuevo.Name = "ActorNuevo";
            this.ActorNuevo.Size = new System.Drawing.Size(75, 61);
            this.ActorNuevo.TabIndex = 1;
            this.ActorNuevo.Text = "Nuevo";
            this.ActorNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ActorNuevo.UseVisualStyleBackColor = true;
            this.ActorNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // ActorGuardar
            // 
            this.ActorGuardar.Image = global::RegistroConsultaPelicula.Properties.Resources._1442278118_save;
            this.ActorGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ActorGuardar.Location = new System.Drawing.Point(15, 175);
            this.ActorGuardar.Name = "ActorGuardar";
            this.ActorGuardar.Size = new System.Drawing.Size(75, 61);
            this.ActorGuardar.TabIndex = 0;
            this.ActorGuardar.Text = "Guardar";
            this.ActorGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ActorGuardar.UseVisualStyleBackColor = true;
            this.ActorGuardar.Click += new System.EventHandler(this.ActorGuardar_Click);
            // 
            // RegistroActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroConsultaPelicula.Properties.Resources.image13;
            this.ClientSize = new System.Drawing.Size(296, 240);
            this.Controls.Add(this.ApellidoActortextBox);
            this.Controls.Add(this.NombreActortextBox);
            this.Controls.Add(this.ActoresIdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActorEliminar);
            this.Controls.Add(this.ActorNuevo);
            this.Controls.Add(this.ActorGuardar);
            this.Name = "RegistroActores";
            this.Text = "RegistroActores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActorGuardar;
        private System.Windows.Forms.Button ActorNuevo;
        private System.Windows.Forms.Button ActorEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ActoresIdtextBox;
        private System.Windows.Forms.TextBox NombreActortextBox;
        private System.Windows.Forms.TextBox ApellidoActortextBox;
    }
}