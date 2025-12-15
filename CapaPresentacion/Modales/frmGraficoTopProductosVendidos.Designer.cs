namespace CapaPresentacion.Modales
{
    partial class frmGraficoTopProductosVendidos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).BeginInit();
            SuspendLayout();
            // 
            // chartTopProductos
            // 
            chartArea1.Name = "ChartArea1";
            chartTopProductos.ChartAreas.Add(chartArea1);
            chartTopProductos.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartTopProductos.Legends.Add(legend1);
            chartTopProductos.Location = new Point(0, 0);
            chartTopProductos.Name = "chartTopProductos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTopProductos.Series.Add(series1);
            chartTopProductos.Size = new Size(861, 475);
            chartTopProductos.TabIndex = 0;
            chartTopProductos.Text = "chart1";
            // 
            // frmGraficoTopProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 475);
            Controls.Add(chartTopProductos);
            Name = "frmGraficoTopProductosVendidos";
            Text = "frmGraficoTopProductosVendidos";
            Load += frmGraficoTopProductosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProductos;
    }
}