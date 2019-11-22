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

namespace Postulados_Golomb.Views
{
    public partial class formDetails : Form
    {
        private List<int> _p1;
        private int _indice;

        public formDetails(int indice, List<int> postulatesAnalisisP1)
        {
            InitializeComponent();
            _p1 = postulatesAnalisisP1;
            _indice = indice;
        }

        private void formDetails_Load(object sender, EventArgs e)
        {
            switch (_indice)
            {
                case 1:
                    chart.Series.Add("Postulado1");
                    chart.Series["Postulado1"].ChartType = SeriesChartType.Column;
                    chart.Series["Postulado1"]["PointWidth"] = "0.5";
                    chart.Series["Postulado1"].IsValueShownAsLabel = true;

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
                    break;
            }
        }
    }
}
