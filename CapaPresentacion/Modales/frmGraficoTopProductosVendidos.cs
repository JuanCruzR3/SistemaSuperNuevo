using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Modales
{
    public partial class frmGraficoTopProductosVendidos : Form
    {
        public frmGraficoTopProductosVendidos()
        {
            InitializeComponent();
        }

        private void frmGraficoTopProductosVendidos_Load(object sender, EventArgs e)
        {
            string fechainicio = DateTime.Now.AddMonths(-12).ToString("yyyy-MM-dd");
            string fechafin = DateTime.Now.ToString("yyyy-MM-dd");

            CargarGrafico(fechainicio, fechafin, 10);
        }

        private void CargarGrafico(string fechainicio, string fechafin, int top)
        {
            var lista = new CN_Reporte().TopProductosVendidos(fechainicio, fechafin, top);

            chartTopProductos.Series.Clear();
            chartTopProductos.ChartAreas.Clear();
            chartTopProductos.Titles.Clear();
            chartTopProductos.Legends.Clear();

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay registros para graficar.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // ✅ Agrupar por producto (por si el SP trae repetidos)
            var data = lista
                .GroupBy(x => new { x.CodigoProducto, x.NombreProducto })
                .Select(g => new
                {
                    Etiqueta = $"{g.Key.CodigoProducto} - {g.Key.NombreProducto}",
                    Cantidad = g.Sum(i => i.CantidadVendida)
                })
                .OrderByDescending(x => x.Cantidad)
                .Take(top)
                .ToList();

            ChartArea area = new ChartArea("Area1");
            chartTopProductos.ChartAreas.Add(area);

            chartTopProductos.Titles.Add($"Top {top} productos más vendidos");

            Series serie = new Series("Cantidad Vendida");
            serie.ChartType = SeriesChartType.Column;

            // ✅ CLAVE para que NO se pisen todos en una sola barra
            serie.XValueType = ChartValueType.String;
            serie.YValueType = ChartValueType.Int32;
            serie.IsXValueIndexed = true;

            // Labels prolijos
            serie.IsValueShownAsLabel = true;
            serie.Label = "#VALY";
            serie.SmartLabelStyle.Enabled = true;
            serie.SmartLabelStyle.IsOverlappedHidden = true;

            foreach (var item in data)
            {
                int idx = serie.Points.AddXY(item.Etiqueta, item.Cantidad);
                serie.Points[idx].AxisLabel = item.Etiqueta; // fuerza etiqueta en eje X
            }

            chartTopProductos.Series.Add(serie);
            chartTopProductos.Legends.Add(new Legend("Legend1"));

            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = true;
        }
    }
}
