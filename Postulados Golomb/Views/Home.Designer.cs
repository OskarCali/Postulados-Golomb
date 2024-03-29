﻿namespace Postulados_Golomb
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBxOptions = new System.Windows.Forms.GroupBox();
            this.lblBits = new System.Windows.Forms.Label();
            this.numUDBits = new System.Windows.Forms.NumericUpDown();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.radBtnFile = new System.Windows.Forms.RadioButton();
            this.radBtnText = new System.Windows.Forms.RadioButton();
            this.toolStripCont = new System.Windows.Forms.ToolStripContainer();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStLblAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblPostulate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTxtBxData = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnR1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnR2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnR3 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBits)).BeginInit();
            this.toolStripCont.BottomToolStripPanel.SuspendLayout();
            this.toolStripCont.ContentPanel.SuspendLayout();
            this.toolStripCont.TopToolStripPanel.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            this.stStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(922, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "POSTULADOS DE GOLOMB";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxOptions
            // 
            this.grpBxOptions.Controls.Add(this.lblBits);
            this.grpBxOptions.Controls.Add(this.numUDBits);
            this.grpBxOptions.Controls.Add(this.lblFilename);
            this.grpBxOptions.Controls.Add(this.btnFile);
            this.grpBxOptions.Controls.Add(this.radBtnFile);
            this.grpBxOptions.Controls.Add(this.radBtnText);
            this.grpBxOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxOptions.Location = new System.Drawing.Point(0, 62);
            this.grpBxOptions.Name = "grpBxOptions";
            this.grpBxOptions.Size = new System.Drawing.Size(922, 98);
            this.grpBxOptions.TabIndex = 1;
            this.grpBxOptions.TabStop = false;
            // 
            // lblBits
            // 
            this.lblBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBits.AutoSize = true;
            this.lblBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBits.Location = new System.Drawing.Point(618, 23);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(117, 18);
            this.lblBits.TabIndex = 6;
            this.lblBits.Text = "Cantidad de bits:";
            // 
            // numUDBits
            // 
            this.numUDBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numUDBits.Location = new System.Drawing.Point(755, 21);
            this.numUDBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUDBits.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUDBits.Name = "numUDBits";
            this.numUDBits.ReadOnly = true;
            this.numUDBits.Size = new System.Drawing.Size(68, 24);
            this.numUDBits.TabIndex = 5;
            this.numUDBits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblFilename.Location = new System.Drawing.Point(225, 64);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(68, 18);
            this.lblFilename.TabIndex = 3;
            this.lblFilename.Text = "Filename";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFile.Location = new System.Drawing.Point(228, 21);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(115, 40);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "ARCHIVO";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // radBtnFile
            // 
            this.radBtnFile.AutoSize = true;
            this.radBtnFile.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.radBtnFile.Location = new System.Drawing.Point(12, 55);
            this.radBtnFile.Name = "radBtnFile";
            this.radBtnFile.Size = new System.Drawing.Size(93, 27);
            this.radBtnFile.TabIndex = 1;
            this.radBtnFile.TabStop = true;
            this.radBtnFile.Text = "Archivo";
            this.radBtnFile.UseVisualStyleBackColor = true;
            this.radBtnFile.CheckedChanged += new System.EventHandler(this.radBtnFile_CheckedChanged);
            // 
            // radBtnText
            // 
            this.radBtnText.AutoSize = true;
            this.radBtnText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.radBtnText.Location = new System.Drawing.Point(12, 22);
            this.radBtnText.Name = "radBtnText";
            this.radBtnText.Size = new System.Drawing.Size(77, 27);
            this.radBtnText.TabIndex = 0;
            this.radBtnText.TabStop = true;
            this.radBtnText.Text = "Texto";
            this.radBtnText.UseVisualStyleBackColor = true;
            this.radBtnText.CheckedChanged += new System.EventHandler(this.radBtnText_CheckedChanged);
            // 
            // toolStripCont
            // 
            // 
            // toolStripCont.BottomToolStripPanel
            // 
            this.toolStripCont.BottomToolStripPanel.Controls.Add(this.stStrip);
            // 
            // toolStripCont.ContentPanel
            // 
            this.toolStripCont.ContentPanel.Controls.Add(this.richTxtBxData);
            this.toolStripCont.ContentPanel.Size = new System.Drawing.Size(922, 417);
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCont.Location = new System.Drawing.Point(0, 160);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(922, 473);
            this.toolStripCont.TabIndex = 2;
            // 
            // toolStripCont.TopToolStripPanel
            // 
            this.toolStripCont.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // stStrip
            // 
            this.stStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStLblAuthor,
            this.toolStripStLblPostulate,
            this.toolStripStLblInfo,
            this.toolStripStLblTime});
            this.stStrip.Location = new System.Drawing.Point(0, 0);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(922, 29);
            this.stStrip.TabIndex = 0;
            // 
            // toolStripStLblAuthor
            // 
            this.toolStripStLblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripStLblAuthor.Name = "toolStripStLblAuthor";
            this.toolStripStLblAuthor.Size = new System.Drawing.Size(65, 23);
            this.toolStripStLblAuthor.Text = "AUTOR";
            this.toolStripStLblAuthor.Click += new System.EventHandler(this.toolStripStLblAuthor_Click);
            // 
            // toolStripStLblPostulate
            // 
            this.toolStripStLblPostulate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.toolStripStLblPostulate.Name = "toolStripStLblPostulate";
            this.toolStripStLblPostulate.Size = new System.Drawing.Size(593, 23);
            this.toolStripStLblPostulate.Spring = true;
            this.toolStripStLblPostulate.Text = "Postulado x";
            this.toolStripStLblPostulate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStLblInfo
            // 
            this.toolStripStLblInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.toolStripStLblInfo.Name = "toolStripStLblInfo";
            this.toolStripStLblInfo.Size = new System.Drawing.Size(185, 23);
            this.toolStripStLblInfo.Text = "x caracteres analizados";
            // 
            // toolStripStLblTime
            // 
            this.toolStripStLblTime.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.toolStripStLblTime.Name = "toolStripStLblTime";
            this.toolStripStLblTime.Size = new System.Drawing.Size(64, 23);
            this.toolStripStLblTime.Text = "tiempo";
            // 
            // richTxtBxData
            // 
            this.richTxtBxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxData.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxData.Name = "richTxtBxData";
            this.richTxtBxData.Size = new System.Drawing.Size(922, 417);
            this.richTxtBxData.TabIndex = 0;
            this.richTxtBxData.Text = "";
            this.richTxtBxData.TextChanged += new System.EventHandler(this.richTxtBxData_TextChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn1,
            this.toolStripBtn2,
            this.toolStripBtn3,
            this.toolStripSep1,
            this.toolStripBtnR1,
            this.toolStripBtnR2,
            this.toolStripBtnR3});
            this.toolStrip.Location = new System.Drawing.Point(4, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(499, 27);
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripBtn1
            // 
            this.toolStripBtn1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn1.Image")));
            this.toolStripBtn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn1.Name = "toolStripBtn1";
            this.toolStripBtn1.Size = new System.Drawing.Size(54, 24);
            this.toolStripBtn1.Tag = "1";
            this.toolStripBtn1.Text = "1er";
            this.toolStripBtn1.Click += new System.EventHandler(this.toolStripBtnPostulate_Click);
            // 
            // toolStripBtn2
            // 
            this.toolStripBtn2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn2.Image")));
            this.toolStripBtn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn2.Name = "toolStripBtn2";
            this.toolStripBtn2.Size = new System.Drawing.Size(59, 24);
            this.toolStripBtn2.Tag = "2";
            this.toolStripBtn2.Text = "2do";
            this.toolStripBtn2.Click += new System.EventHandler(this.toolStripBtnPostulate_Click);
            // 
            // toolStripBtn3
            // 
            this.toolStripBtn3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn3.Image")));
            this.toolStripBtn3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn3.Name = "toolStripBtn3";
            this.toolStripBtn3.Size = new System.Drawing.Size(54, 24);
            this.toolStripBtn3.Tag = "3";
            this.toolStripBtn3.Text = "3er";
            this.toolStripBtn3.Click += new System.EventHandler(this.toolStripBtnPostulate_Click);
            // 
            // toolStripSep1
            // 
            this.toolStripSep1.Name = "toolStripSep1";
            this.toolStripSep1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnR1
            // 
            this.toolStripBtnR1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnR1.Image")));
            this.toolStripBtnR1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnR1.Name = "toolStripBtnR1";
            this.toolStripBtnR1.Size = new System.Drawing.Size(106, 24);
            this.toolStripBtnR1.Tag = "1";
            this.toolStripBtnR1.Text = "Detalle 1er";
            this.toolStripBtnR1.Click += new System.EventHandler(this.toolStripBtnPostulateResult_Click);
            // 
            // toolStripBtnR2
            // 
            this.toolStripBtnR2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnR2.Image")));
            this.toolStripBtnR2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnR2.Name = "toolStripBtnR2";
            this.toolStripBtnR2.Size = new System.Drawing.Size(111, 24);
            this.toolStripBtnR2.Tag = "2";
            this.toolStripBtnR2.Text = "Detalle 2do";
            this.toolStripBtnR2.Click += new System.EventHandler(this.toolStripBtnPostulateResult_Click);
            // 
            // toolStripBtnR3
            // 
            this.toolStripBtnR3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnR3.Image")));
            this.toolStripBtnR3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnR3.Name = "toolStripBtnR3";
            this.toolStripBtnR3.Size = new System.Drawing.Size(106, 24);
            this.toolStripBtnR3.Tag = "3";
            this.toolStripBtnR3.Text = "Detalle 3er";
            this.toolStripBtnR3.Click += new System.EventHandler(this.toolStripBtnPostulateResult_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            this.openFileDialog.InitialDirectory = "D:\\Drive Upp\\09_Cuatri\\Seguridad";
            this.openFileDialog.Title = "Postulado de Golomb - Archivo";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 633);
            this.Controls.Add(this.toolStripCont);
            this.Controls.Add(this.grpBxOptions);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 680);
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.formHome_Load);
            this.grpBxOptions.ResumeLayout(false);
            this.grpBxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBits)).EndInit();
            this.toolStripCont.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripCont.BottomToolStripPanel.PerformLayout();
            this.toolStripCont.ContentPanel.ResumeLayout(false);
            this.toolStripCont.TopToolStripPanel.ResumeLayout(false);
            this.toolStripCont.TopToolStripPanel.PerformLayout();
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBxOptions;
        private System.Windows.Forms.ToolStripContainer toolStripCont;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.NumericUpDown numUDBits;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.RadioButton radBtnFile;
        private System.Windows.Forms.RadioButton radBtnText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblAuthor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblPostulate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblInfo;
        private System.Windows.Forms.ToolStripButton toolStripBtn1;
        private System.Windows.Forms.ToolStripButton toolStripBtn2;
        private System.Windows.Forms.ToolStripButton toolStripBtn3;
        private System.Windows.Forms.ToolStripSeparator toolStripSep1;
        private System.Windows.Forms.ToolStripButton toolStripBtnR1;
        private System.Windows.Forms.ToolStripButton toolStripBtnR2;
        private System.Windows.Forms.ToolStripButton toolStripBtnR3;
        private System.Windows.Forms.RichTextBox richTxtBxData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblTime;
    }
}

