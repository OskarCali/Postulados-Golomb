using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Postulados_Golomb.Models;

namespace Postulados_Golomb.Views
{
    public partial class formDetails : Form
    {
        private List<int> _p1;
        private List<List<Element>> _p2;
        private List<double> _p3;
        private int _bin;
        private int _indice;

        public formDetails(int indice, List<int> postulatesAnalisisP1)
        {
            InitializeComponent();
            _p1 = postulatesAnalisisP1;
            _indice = indice;
        }

        public formDetails(int indice, List<List<Element>> postulatesAnalisisP2, int bin)
        {
            InitializeComponent();
            _p2 = postulatesAnalisisP2;
            _indice = indice;
            _bin = bin;
        }

        public formDetails(int indice, List<double> postulatesAnalisisP3)
        {
            InitializeComponent();
            _p3 = postulatesAnalisisP3;
            _indice = indice;
        }

        private void formDetails_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
            Chart chart;

            switch (_indice)
            {
                case 1:
                    chart = new Chart();
                    chart.ChartAreas.Add("Area");
                    chart.ChartAreas["Area"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                    chart.Series.Add("Postulado1");
                    chart.Series["Postulado1"].ChartType = SeriesChartType.Column;
                    chart.Series["Postulado1"]["PointWidth"] = "0.5";
                    chart.Series["Postulado1"].IsValueShownAsLabel = true;
                    chart.Dock = DockStyle.Fill;

                    _p1.Select((y, x) => new
                        {
                            count = y,
                            item = x
                        })
                        .ToList()
                        .ForEach(obj =>
                        {
                            chart.Series["Postulado1"].Points.AddXY(obj.item, obj.count);
                        });

                    tabControl.TabPages.Add("1", "TabPage1");
                    tabControl.TabPages["1"].Controls.Add(chart);
                    break;
                case 2:
                    for (int i = 1; i < _bin; i++)
                    {
                        chart = new Chart();
                        chart.ChartAreas.Add("Area");
                        chart.ChartAreas["Area"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                        chart.Series.Add("Bin " + (i + 1));
                        chart.Series["Bin " + (i + 1)].ChartType = SeriesChartType.Column;
                        chart.Series["Bin " + (i + 1)]["PointWidth"] = "0.5";
                        chart.Series["Bin " + (i + 1)].IsValueShownAsLabel = true;
                        chart.Dock = DockStyle.Fill;

                        foreach (var item in _p2[i-1])
                            chart.Series["Bin " + (i + 1)].Points.AddXY(item.Name, item.Coincidences);
                        //item.ForEach(x => chart.Series["Bin " + (i + 1)].Points.AddXY(x.Name, x.Coincidences));


                        tabControl.TabPages.Add((i+1).ToString(), "TabPage" + (i+1));
                        tabControl.TabPages[(i+1).ToString()].Controls.Add(chart);
                    }
                    break;
                case 3:
                    chart = new Chart();
                    chart.ChartAreas.Add("Area");
                    chart.ChartAreas["Area"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                    chart.Series.Add("Postulado3");
                    chart.Series["Postulado3"].ChartType = SeriesChartType.Line;
                    //chart.Series["Postulado3"]["PointWidth"] = "0.5";
                    chart.Series["Postulado3"].BorderWidth = 3;
                    chart.Series["Postulado3"].IsValueShownAsLabel = true;
                    chart.Dock = DockStyle.Fill;

                    _p3.Select((y, x) => new
                        {
                            count = y,
                            item = x
                        })
                        .ToList()
                        .ForEach(obj =>
                        {
                            chart.Series["Postulado3"].Points.AddXY(obj.item, obj.count);
                        });

                    tabControl.TabPages.Add("1", "TabPage1");
                    tabControl.TabPages["1"].Controls.Add(chart);
                    break;
            }
        }
    }
}
