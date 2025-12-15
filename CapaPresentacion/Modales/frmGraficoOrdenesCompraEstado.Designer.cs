namespace CapaPresentacion
{
    partial class frmGraficoOrdenesCompraEstado
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
            chartEstadoOC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartEstadoOC).BeginInit();
            SuspendLayout();
            // 
            // chartEstadoOC
            // 
            chartArea1.Name = "ChartArea1";
            chartEstadoOC.ChartAreas.Add(chartArea1);
            chartEstadoOC.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartEstadoOC.Legends.Add(legend1);
            chartEstadoOC.Location = new Point(0, 0);
            chartEstadoOC.Name = "chartEstadoOC";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartEstadoOC.Series.Add(series1);
            chartEstadoOC.Size = new Size(908, 468);
            chartEstadoOC.TabIndex = 0;
            chartEstadoOC.Text = "chart1";
            // 
            // frmGraficoOrdenesCompraEstado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 468);
            Controls.Add(chartEstadoOC);
            Name = "frmGraficoOrdenesCompraEstado";
            Text = "frmGraficoOrdenesCompraEstado";
            Load += frmGraficoOrdenesCompraEstado_Load;
            ((System.ComponentModel.ISupportInitialize)chartEstadoOC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadoOC;
    }
}