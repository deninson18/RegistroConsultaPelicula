namespace RegistroConsultaPelicula
{
    partial class Consulta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cEliminarbutton = new System.Windows.Forms.Button();
            this.cLimpiarbutton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cEliminarbutton
            // 
            this.cEliminarbutton.Image = global::RegistroConsultaPelicula.Properties.Resources.cancel;
            this.cEliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cEliminarbutton.Location = new System.Drawing.Point(582, 198);
            this.cEliminarbutton.Name = "cEliminarbutton";
            this.cEliminarbutton.Size = new System.Drawing.Size(132, 54);
            this.cEliminarbutton.TabIndex = 3;
            this.cEliminarbutton.Text = "Eliminar";
            this.cEliminarbutton.UseVisualStyleBackColor = true;
            // 
            // cLimpiarbutton
            // 
            this.cLimpiarbutton.Image = global::RegistroConsultaPelicula.Properties.Resources._1443952939_edit_clear;
            this.cLimpiarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cLimpiarbutton.Location = new System.Drawing.Point(291, 198);
            this.cLimpiarbutton.Name = "cLimpiarbutton";
            this.cLimpiarbutton.Size = new System.Drawing.Size(126, 54);
            this.cLimpiarbutton.TabIndex = 2;
            this.cLimpiarbutton.Text = "Limpiar";
            this.cLimpiarbutton.UseVisualStyleBackColor = true;
            this.cLimpiarbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // consultarButton
            // 
            this.consultarButton.Image = global::RegistroConsultaPelicula.Properties.Resources._1443952390_client;
            this.consultarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consultarButton.Location = new System.Drawing.Point(12, 198);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(127, 54);
            this.consultarButton.TabIndex = 1;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(745, 264);
            this.Controls.Add(this.cEliminarbutton);
            this.Controls.Add(this.cLimpiarbutton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button cLimpiarbutton;
        private System.Windows.Forms.Button cEliminarbutton;
    }
}