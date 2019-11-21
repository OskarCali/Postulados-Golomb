using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postulados_Golomb
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void formHome_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            //MessageBox.Show(
            //    "Si usted desea aplicar los 3 postulados a un mismo texto, ingrese el texto en el area y de click en \"FIJAR TEXTO\"",
            //    "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
            //    MessageBoxOptions.ServiceNotification);
        }
    }
}
