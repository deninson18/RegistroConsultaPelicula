﻿namespace BLL
{
    partial class VisorReportesPelicula
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
            this.VisorReportePelicula = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorReportePelicula
            // 
            this.VisorReportePelicula.ActiveViewIndex = -1;
            this.VisorReportePelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorReportePelicula.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorReportePelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorReportePelicula.Location = new System.Drawing.Point(0, 0);
            this.VisorReportePelicula.Name = "VisorReportePelicula";
            this.VisorReportePelicula.Size = new System.Drawing.Size(844, 464);
            this.VisorReportePelicula.TabIndex = 0;
            // 
            // VisorReportesPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 464);
            this.Controls.Add(this.VisorReportePelicula);
            this.Name = "VisorReportesPelicula";
            this.Text = "VisorReportesPelicula";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorReportePelicula;
    }
}