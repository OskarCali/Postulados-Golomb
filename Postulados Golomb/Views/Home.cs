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
using Postulados_Golomb.Extensions;
using Postulados_Golomb.Functions;
using Postulados_Golomb.Views;

namespace Postulados_Golomb
{
    public partial class formHome : Form
    {
        private Postulates postulates;
        private formDetails details;

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
            postulates = new Postulates();

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

        private void toolStripBtnPostulate_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton btn = sender as ToolStripButton;
                int indice = Int32.Parse(btn.Tag.ToString());

                postulates.postulado(indice, richTxtBxData.Text.TextToBin(Encoding.UTF8), (int)numUDBits.Value);

                switch (indice)
                {
                    case 1:
                        toolStripBtnR1.Enabled = true;
                        break;
                    case 2:
                        toolStripBtnR2.Enabled = true;
                        break;
                    case 3:
                        toolStripBtnR3.Enabled = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, por favor revise las entradas\n" + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
            }
        }

        private void toolStripBtnPostulateResult_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton btn = sender as ToolStripButton;
                int indice = Int32.Parse(btn.Tag.ToString());

                switch (indice)
                {
                    case 1:
                        details = new formDetails(indice, postulates.AnalisisP1);
                        break;
                    case 2:
                        toolStripBtnR2.Enabled = true;
                        break;
                    case 3:
                        toolStripBtnR3.Enabled = true;
                        break;
                }

                Hide();
                details.ShowDialog(this);
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, por favor revise las entradas\n" + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
            }
        }
    }
}
