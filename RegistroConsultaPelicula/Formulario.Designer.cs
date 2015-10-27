namespace RegistroConsultaPelicula
{
    partial class Formulario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeActoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEstudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.crystalReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.registroDeActoresToolStripMenuItem,
            this.registroDeEstudiosToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroToolStripMenuItem.Text = "Registro Peliculas";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaToolStripMenuItem.Text = "Registro de Generos";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // registroDeActoresToolStripMenuItem
            // 
            this.registroDeActoresToolStripMenuItem.Name = "registroDeActoresToolStripMenuItem";
            this.registroDeActoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeActoresToolStripMenuItem.Text = "Registro de Actores";
            this.registroDeActoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeActoresToolStripMenuItem_Click);
            // 
            // registroDeEstudiosToolStripMenuItem
            // 
            this.registroDeEstudiosToolStripMenuItem.Name = "registroDeEstudiosToolStripMenuItem";
            this.registroDeEstudiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeEstudiosToolStripMenuItem.Text = "Registro de Estudios";
            this.registroDeEstudiosToolStripMenuItem.Click += new System.EventHandler(this.registroDeEstudiosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            this.peliculasToolStripMenuItem.Click += new System.EventHandler(this.peliculasToolStripMenuItem_Click_1);
            // 
            // crystalReportsToolStripMenuItem
            // 
            this.crystalReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportePeliculasToolStripMenuItem});
            this.crystalReportsToolStripMenuItem.Name = "crystalReportsToolStripMenuItem";
            this.crystalReportsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.crystalReportsToolStripMenuItem.Text = "CrystalReports";
            // 
            // reportePeliculasToolStripMenuItem
            // 
            this.reportePeliculasToolStripMenuItem.Name = "reportePeliculasToolStripMenuItem";
            this.reportePeliculasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reportePeliculasToolStripMenuItem.Text = "Reporte Peliculas";
            this.reportePeliculasToolStripMenuItem.Click += new System.EventHandler(this.reportePeliculasToolStripMenuItem_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroConsultaPelicula.Properties.Resources.formulario;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulario";
            this.Text = "Registro de Peliculas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeActoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEstudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crystalReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePeliculasToolStripMenuItem;
    }
}

