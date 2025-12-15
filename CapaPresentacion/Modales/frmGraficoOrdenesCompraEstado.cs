using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class frmGraficoOrdenesCompraEstado : Form
    {
        public frmGraficoOrdenesCompraEstado()
        {
            InitializeComponent();
        }

        private void frmGraficoOrdenesCompraEstado_Load(object sender, EventArgs e)
        {
            CargarGrafico();
        }

        private void CargarGrafico()
        {

            List<ReporteOrdenCompraEstado> lista = new CN_Reporte().OrdenCompraPorEstado();

            chartEstadoOC.Series.Clear();
            chartEstadoOC.ChartAreas.Clear();
            chartEstadoOC.Titles.Clear();

            chartEstadoOC.ChartAreas.Add(new ChartArea("Area1"));
            chartEstadoOC.Titles.Add("Órdenes de Compra por Estado");

            Series serie = new Series("Estados");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;

            foreach (var item in lista)
            {
                serie.Points.AddXY(item.Estado, item.TotalOrdenes);
            }

            chartEstadoOC.Series.Add(serie);
            chartEstadoOC.Legends.Clear();
            chartEstadoOC.Legends.Add(new Legend("Legend1"));
        }
    }
}
