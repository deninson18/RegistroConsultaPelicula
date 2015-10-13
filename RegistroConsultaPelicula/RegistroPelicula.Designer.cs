namespace RegistroConsultaPelicula
{
    partial class RegistroPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPelicula));
            this.CalificaciontextBox = new System.Windows.Forms.TextBox();
            this.ImdbtextBox = new System.Windows.Forms.TextBox();
            this.CategoriatextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.TitulotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AnotextBox = new System.Windows.Forms.TextBox();
            this.rEliminarbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rLimpiarbutton = new System.Windows.Forms.Button();
            this.rGuardarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalificaciontextBox
            // 
            this.CalificaciontextBox.Location = new System.Drawing.Point(453, 49);
            this.CalificaciontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CalificaciontextBox.Name = "CalificaciontextBox";
            this.CalificaciontextBox.Size = new System.Drawing.Size(303, 22);
            this.CalificaciontextBox.TabIndex = 23;
            // 
            // ImdbtextBox
            // 
            this.ImdbtextBox.Location = new System.Drawing.Point(52, 49);
            this.ImdbtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImdbtextBox.Name = "ImdbtextBox";
            this.ImdbtextBox.Size = new System.Drawing.Size(288, 22);
            this.ImdbtextBox.TabIndex = 22;
            this.ImdbtextBox.TextChanged += new System.EventHandler(this.ImdbtextBox_TextChanged);
            // 
            // CategoriatextBox
            // 
            this.CategoriatextBox.Location = new System.Drawing.Point(453, 13);
            this.CategoriatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoriatextBox.Name = "CategoriatextBox";
            this.CategoriatextBox.Size = new System.Drawing.Size(303, 22);
            this.CategoriatextBox.TabIndex = 21;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(453, 91);
            this.DescripciontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(303, 96);
            this.DescripciontextBox.TabIndex = 20;
            // 
            // TitulotextBox
            // 
            this.TitulotextBox.Location = new System.Drawing.Point(52, 14);
            this.TitulotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitulotextBox.Name = "TitulotextBox";
            this.TitulotextBox.Size = new System.Drawing.Size(288, 22);
            this.TitulotextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Categorias Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "IMDB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Calificacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Titulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ano";
            // 
            // AnotextBox
            // 
            this.AnotextBox.Location = new System.Drawing.Point(52, 85);
            this.AnotextBox.Name = "AnotextBox";
            this.AnotextBox.Size = new System.Drawing.Size(288, 22);
            this.AnotextBox.TabIndex = 27;
            // 
            // rEliminarbutton
            // 
            this.rEliminarbutton.Image = global::RegistroConsultaPelicula.Properties.Resources.cancel;
            this.rEliminarbutton.Location = new System.Drawing.Point(265, 113);
            this.rEliminarbutton.Name = "rEliminarbutton";
            this.rEliminarbutton.Size = new System.Drawing.Size(75, 74);
            this.rEliminarbutton.TabIndex = 29;
            this.rEliminarbutton.Text = "Eliminar";
            this.rEliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rEliminarbutton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::RegistroConsultaPelicula.Properties.Resources.moviereg;
            this.pictureBox1.Location = new System.Drawing.Point(52, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 115);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // rLimpiarbutton
            // 
            this.rLimpiarbutton.Image = global::RegistroConsultaPelicula.Properties.Resources._1443952939_edit_clear;
            this.rLimpiarbutton.Location = new System.Drawing.Point(157, 113);
            this.rLimpiarbutton.Name = "rLimpiarbutton";
            this.rLimpiarbutton.Size = new System.Drawing.Size(75, 74);
            this.rLimpiarbutton.TabIndex = 25;
            this.rLimpiarbutton.Text = "Limpiar";
            this.rLimpiarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rLimpiarbutton.UseVisualStyleBackColor = true;
            this.rLimpiarbutton.Click += new System.EventHandler(this.rLimpiarbutton_Click);
            // 
            // rGuardarbutton
            // 
            this.rGuardarbutton.Image = global::RegistroConsultaPelicula.Properties.Resources._1443952702_document_save_as;
            this.rGuardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rGuardarbutton.Location = new System.Drawing.Point(52, 113);
            this.rGuardarbutton.Name = "rGuardarbutton";
            this.rGuardarbutton.Size = new System.Drawing.Size(75, 74);
            this.rGuardarbutton.TabIndex = 24;
            this.rGuardarbutton.Text = "Guardar";
            this.rGuardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rGuardarbutton.UseVisualStyleBackColor = true;
            this.rGuardarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(769, 339);
            this.Controls.Add(this.rEliminarbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnotextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rLimpiarbutton);
            this.Controls.Add(this.rGuardarbutton);
            this.Controls.Add(this.CalificaciontextBox);
            this.Controls.Add(this.ImdbtextBox);
            this.Controls.Add(this.CategoriatextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.TitulotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroPelicula";
            this.Text = "RegistroPelicula";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalificaciontextBox;
        private System.Windows.Forms.TextBox ImdbtextBox;
        private System.Windows.Forms.TextBox CategoriatextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox TitulotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rGuardarbutton;
        private System.Windows.Forms.Button rLimpiarbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AnotextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rEliminarbutton;
    }
}