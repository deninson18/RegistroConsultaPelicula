namespace RegistroConsultaPelicula
{
    partial class RegistroEstudio
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
            this.GuardarEstudio = new System.Windows.Forms.Button();
            this.nuevoEstudio = new System.Windows.Forms.Button();
            this.eliminarEstudio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estudioIdtextBox = new System.Windows.Forms.TextBox();
            this.nombreEstudiotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GuardarEstudio
            // 
            this.GuardarEstudio.Image = global::RegistroConsultaPelicula.Properties.Resources._1442278118_save;
            this.GuardarEstudio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarEstudio.Location = new System.Drawing.Point(12, 191);
            this.GuardarEstudio.Name = "GuardarEstudio";
            this.GuardarEstudio.Size = new System.Drawing.Size(75, 57);
            this.GuardarEstudio.TabIndex = 0;
            this.GuardarEstudio.Text = "Guardar";
            this.GuardarEstudio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarEstudio.UseVisualStyleBackColor = true;
            this.GuardarEstudio.Click += new System.EventHandler(this.GuardarEstudio_Click);
            // 
            // nuevoEstudio
            // 
            this.nuevoEstudio.Image = global::RegistroConsultaPelicula.Properties.Resources._1442278245_edit;
            this.nuevoEstudio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevoEstudio.Location = new System.Drawing.Point(102, 191);
            this.nuevoEstudio.Name = "nuevoEstudio";
            this.nuevoEstudio.Size = new System.Drawing.Size(75, 57);
            this.nuevoEstudio.TabIndex = 1;
            this.nuevoEstudio.Text = "Nuevo";
            this.nuevoEstudio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevoEstudio.UseVisualStyleBackColor = true;
            this.nuevoEstudio.Click += new System.EventHandler(this.nuevoEstudio_Click);
            // 
            // eliminarEstudio
            // 
            this.eliminarEstudio.BackColor = System.Drawing.SystemColors.Control;
            this.eliminarEstudio.Image = global::RegistroConsultaPelicula.Properties.Resources.cancel;
            this.eliminarEstudio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarEstudio.Location = new System.Drawing.Point(197, 191);
            this.eliminarEstudio.Name = "eliminarEstudio";
            this.eliminarEstudio.Size = new System.Drawing.Size(75, 57);
            this.eliminarEstudio.TabIndex = 2;
            this.eliminarEstudio.Text = "Eliminar";
            this.eliminarEstudio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminarEstudio.UseVisualStyleBackColor = false;
            this.eliminarEstudio.Click += new System.EventHandler(this.eliminarEstudio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estudio Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de Estudio";
            // 
            // estudioIdtextBox
            // 
            this.estudioIdtextBox.Location = new System.Drawing.Point(12, 25);
            this.estudioIdtextBox.Name = "estudioIdtextBox";
            this.estudioIdtextBox.Size = new System.Drawing.Size(139, 20);
            this.estudioIdtextBox.TabIndex = 5;
            // 
            // nombreEstudiotextBox
            // 
            this.nombreEstudiotextBox.Location = new System.Drawing.Point(15, 112);
            this.nombreEstudiotextBox.Name = "nombreEstudiotextBox";
            this.nombreEstudiotextBox.Size = new System.Drawing.Size(257, 20);
            this.nombreEstudiotextBox.TabIndex = 6;
            // 
            // RegistroEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroConsultaPelicula.Properties.Resources.cine;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nombreEstudiotextBox);
            this.Controls.Add(this.estudioIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminarEstudio);
            this.Controls.Add(this.nuevoEstudio);
            this.Controls.Add(this.GuardarEstudio);
            this.Name = "RegistroEstudio";
            this.Text = "RegistroEstudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarEstudio;
        private System.Windows.Forms.Button nuevoEstudio;
        private System.Windows.Forms.Button eliminarEstudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox estudioIdtextBox;
        private System.Windows.Forms.TextBox nombreEstudiotextBox;
    }
}