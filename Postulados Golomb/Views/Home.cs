using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void toolStripStLblAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desarrollado por Óskar Calí.\nNoviembre 2019", "AUTOR", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            radBtnText.Checked = true;

            toolStripBtn1.Enabled = false;
            toolStripBtn2.Enabled = false;
            toolStripBtn3.Enabled = false;

            toolStripBtnR1.Enabled = false;
            toolStripBtnR2.Enabled = false;
            toolStripBtnR3.Enabled = false;

            toolStripStLblPostulate.Text = "";
            toolStripStLblInfo.Text = "";
        }

        private void radBtnText_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxData.ReadOnly = false;

            btnFile.Enabled = false;
            lblFilename.Text = "";

            richTxtBxData.Text = "";
        }

        private void radBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxData.ReadOnly = true;

            btnFile.Enabled = true;

            richTxtBxData.Text = "";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFilename.Text = openFileDialog.FileName;
                richTxtBxData.Text = File.ReadAllText(lblFilename.Text);
            }
        }

        private void richTxtBxData_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTxtBxData.Text))
            {
                toolStripBtn1.Enabled = true;
                toolStripBtn2.Enabled = true;
                toolStripBtn3.Enabled = true;
            }
        }
    }
}
