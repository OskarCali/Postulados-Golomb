using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Postulados_Golomb.Extensions;
using Postulados_Golomb.Functions;
using Postulados_Golomb.Views;

namespace Postulados_Golomb
{
    public partial class formHome : Form
    {
        private Postulates _postulates;
        private formDetails _details;

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
            _postulates = new Postulates();

            radBtnText.Checked = true;

            toolStripBtn1.Enabled = false;
            toolStripBtn2.Enabled = false;
            toolStripBtn3.Enabled = false;

            toolStripBtnR1.Enabled = false;
            toolStripBtnR2.Enabled = false;
            toolStripBtnR3.Enabled = false;

            toolStripStLblPostulate.Text = "";
            toolStripStLblInfo.Text = "";
            toolStripStLblTime.Text = "";
        }

        private void radBtnText_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxData.ReadOnly = false;

            btnFile.Enabled = false;
            lblFilename.Text = "";

            richTxtBxData.Text = "";
            toolStripStLblTime.Text = "";
        }

        private void radBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxData.ReadOnly = true;

            btnFile.Enabled = true;

            richTxtBxData.Text = "";
            toolStripStLblTime.Text = "";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            toolStripStLblInfo.Text = "Buscando archivo...";
            Application.DoEvents();

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFilename.Text = openFileDialog.FileName;
                richTxtBxData.Text = File.ReadAllText(lblFilename.Text);

                toolStripStLblInfo.Text = "Archivo cargado!!";
            }
        }

        private void richTxtBxData_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTxtBxData.Text))
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
                var binData = richTxtBxData.Text.TextToBin(Encoding.UTF8);

                var btn = sender as ToolStripButton;
                var indice = int.Parse(btn.Tag.ToString());

                toolStripStLblPostulate.Text = "Postulado " + indice;
                toolStripStLblInfo.Text = "Analizando...";
                toolStripStLblTime.Text = "";
                Application.DoEvents();

                var inicio = DateTime.Now;
                _postulates.postulado(indice, binData, (int) numUDBits.Value);
                var tiempo = DateTime.Now - inicio;

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

                toolStripStLblInfo.Text = binData.Length + " caracteres";
                toolStripStLblTime.Text = tiempo.ToString("g");
            }
            catch (Exception ex)
            {
                toolStripStLblInfo.Text = "error";

                MessageBox.Show("Ocurrio un error, por favor revise las entradas\n" + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
            }
        }

        private void toolStripBtnPostulateResult_Click(object sender, EventArgs e)
        {
            try
            {
                var inicio = DateTime.Now;

                var btn = sender as ToolStripButton;
                var indice = int.Parse(btn.Tag.ToString());

                toolStripStLblPostulate.Text = "Detalles del postulado " + indice;
                toolStripStLblInfo.Text = "Cargando...";
                toolStripStLblTime.Text = "";
                Application.DoEvents();

                switch (indice)
                {
                    case 1:
                        _details = new formDetails(indice, _postulates.AnalisisP1);
                        break;
                    case 2:
                        _details = new formDetails(indice, _postulates.AnalisisP2, (int) numUDBits.Value);
                        break;
                    case 3:
                        _details = new formDetails(indice, _postulates.AnalisisP3);
                        break;
                }

                var tiempo = DateTime.Now - inicio;
                toolStripStLblInfo.Text = "";
                toolStripStLblTime.Text = tiempo.ToString("g");
                Application.DoEvents();

                Hide();
                _details.ShowDialog(this);
                Show();
            }
            catch (Exception ex)
            {
                toolStripStLblInfo.Text = "error";

                MessageBox.Show("Ocurrio un error, por favor revise las entradas\n" + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
            }
        }
    }
}