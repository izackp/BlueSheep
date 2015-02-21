﻿namespace BlueSheep.Interface
{
    partial class JobUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sadikTabControl1 = new BlueSheep.Interface.SadikTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.g = new System.Windows.Forms.DataGridView();
            this.gg = new System.Windows.Forms.DataGridView();
            this.GatherPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sadikTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GatherPie)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sadikTabControl1
            // 
            this.sadikTabControl1.Controls.Add(this.tabPage4);
            this.sadikTabControl1.Controls.Add(this.tabPage5);
            this.sadikTabControl1.Controls.Add(this.tabPage6);
            this.sadikTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sadikTabControl1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikTabControl1.ItemSize = new System.Drawing.Size(0, 30);
            this.sadikTabControl1.Location = new System.Drawing.Point(0, 0);
            this.sadikTabControl1.Name = "sadikTabControl1";
            this.sadikTabControl1.SelectedIndex = 0;
            this.sadikTabControl1.Size = new System.Drawing.Size(410, 283);
            this.sadikTabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(402, 245);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Récolte";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(402, 245);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Craft";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(402, 245);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Stats";
            // 
            // g
            // 
            this.g.BackgroundColor = System.Drawing.Color.LightCyan;
            this.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g.Location = new System.Drawing.Point(0, 0);
            this.g.Name = "g";
            this.g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.g.Size = new System.Drawing.Size(410, 283);
            this.g.TabIndex = 0;
            // 
            // gg
            // 
            this.gg.BackgroundColor = System.Drawing.Color.LightCyan;
            this.gg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gg.Location = new System.Drawing.Point(3, 3);
            this.gg.Name = "gg";
            this.gg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gg.Size = new System.Drawing.Size(419, 323);
            this.gg.TabIndex = 0;
            // 
            // GatherPie
            // 
            this.GatherPie.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GatherPie.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.GatherPie.BackImageTransparentColor = System.Drawing.Color.White;
            this.GatherPie.BackSecondaryColor = System.Drawing.Color.Cyan;
            this.GatherPie.BorderlineColor = System.Drawing.Color.Black;
            this.GatherPie.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.GatherPie.ChartAreas.Add(chartArea1);
            this.GatherPie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.GatherPie.Legends.Add(legend1);
            this.GatherPie.Location = new System.Drawing.Point(3, 3);
            this.GatherPie.Name = "GatherPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GatherPie.Series.Add(series1);
            this.GatherPie.Size = new System.Drawing.Size(419, 323);
            this.GatherPie.TabIndex = 0;
            this.GatherPie.Text = "chart1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Récolte";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.gg);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Craft";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.GatherPie);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stats";
            // 
            // JobUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sadikTabControl1);
            this.Name = "JobUC";
            this.Size = new System.Drawing.Size(410, 283);
            this.sadikTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GatherPie)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SadikTabControl sadikTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart GatherPie;
        public System.Windows.Forms.DataGridView g;
        public System.Windows.Forms.DataGridView gg;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}
