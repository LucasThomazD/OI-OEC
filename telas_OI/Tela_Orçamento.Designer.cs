

using System.Drawing.Drawing2D;

namespace telas_OI
{

    
    partial class Tela_Orçamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Orçamento));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            labelInfo = new Label();
            label1 = new Label();
            BoxArea = new ComboBox();
            TA2 = new Label();
            TA1 = new Label();
            BoxTA1 = new ComboBox();
            BoxTA2 = new ComboBox();
            panel3 = new Panel();
            panel2 = new Panel();
            BotUnico = new Button();
            BotArquivos = new Button();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1 = new Panel();
            BotMulti = new Button();
            BotTub = new Button();
            BotSupTub = new Button();
            BotMentos = new Button();
            BotCBINC = new Button();
            BotInst = new Button();
            BotElétrica = new Button();
            Disciplinas = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            LabelOrçamento = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(50, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1085, 500);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1077, 472);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PDF";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(BotUnico);
            tabPage2.Controls.Add(BotArquivos);
            tabPage2.Controls.Add(statusStrip1);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1077, 472);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Comparativo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Controls.Add(labelInfo);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(BoxArea);
            panel4.Controls.Add(TA2);
            panel4.Controls.Add(TA1);
            panel4.Controls.Add(BoxTA1);
            panel4.Controls.Add(BoxTA2);
            panel4.Location = new Point(536, 56);
            panel4.Margin = new Padding(40);
            panel4.Name = "panel4";
            panel4.Size = new Size(501, 152);
            panel4.TabIndex = 7;
            panel4.Paint += panel4_Paint;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ButtonFace;
            labelInfo.Location = new Point(88, 2);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(330, 30);
            labelInfo.TabIndex = 9;
            labelInfo.Text = "INFORMAÇÕES SUPLEMENTARES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(170, 67);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 8;
            label1.Text = "ÁREA ";
            // 
            // BoxArea
            // 
            BoxArea.FormattingEnabled = true;
            BoxArea.Location = new Point(225, 67);
            BoxArea.Name = "BoxArea";
            BoxArea.Size = new Size(80, 23);
            BoxArea.TabIndex = 7;
            // 
            // TA2
            // 
            TA2.AutoSize = true;
            TA2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TA2.ForeColor = SystemColors.ButtonFace;
            TA2.Location = new Point(19, 109);
            TA2.Name = "TA2";
            TA2.Size = new Size(48, 21);
            TA2.TabIndex = 6;
            TA2.Text = "2° TA";
            // 
            // TA1
            // 
            TA1.AutoSize = true;
            TA1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TA1.ForeColor = SystemColors.ButtonFace;
            TA1.Location = new Point(19, 67);
            TA1.Name = "TA1";
            TA1.Size = new Size(47, 21);
            TA1.TabIndex = 5;
            TA1.Text = "1° TA";
            // 
            // BoxTA1
            // 
            BoxTA1.FormattingEnabled = true;
            BoxTA1.Location = new Point(72, 67);
            BoxTA1.Name = "BoxTA1";
            BoxTA1.Size = new Size(68, 23);
            BoxTA1.TabIndex = 4;
            // 
            // BoxTA2
            // 
            BoxTA2.FormattingEnabled = true;
            BoxTA2.Location = new Point(72, 107);
            BoxTA2.Name = "BoxTA2";
            BoxTA2.Size = new Size(68, 23);
            BoxTA2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(501, 237);
            panel3.Margin = new Padding(40, 3, 0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 5);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(496, 0);
            panel2.Margin = new Padding(40, 3, 40, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 448);
            panel2.TabIndex = 4;
            // 
            // BotUnico
            // 
            BotUnico.BackColor = Color.IndianRed;
            BotUnico.FlatStyle = FlatStyle.Popup;
            BotUnico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotUnico.ForeColor = SystemColors.ControlLightLight;
            BotUnico.Location = new Point(268, 56);
            BotUnico.Margin = new Padding(3, 3, 3, 30);
            BotUnico.Name = "BotUnico";
            BotUnico.Padding = new Padding(1);
            BotUnico.Size = new Size(185, 39);
            BotUnico.TabIndex = 3;
            BotUnico.Text = "BUSCAR UNICO";
            BotUnico.UseVisualStyleBackColor = false;
            // 
            // BotArquivos
            // 
            BotArquivos.BackColor = Color.IndianRed;
            BotArquivos.Cursor = Cursors.Hand;
            BotArquivos.FlatAppearance.BorderSize = 0;
            BotArquivos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotArquivos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BotArquivos.FlatStyle = FlatStyle.Popup;
            BotArquivos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotArquivos.ForeColor = SystemColors.ControlLightLight;
            BotArquivos.Location = new Point(43, 56);
            BotArquivos.Margin = new Padding(3, 3, 3, 30);
            BotArquivos.Name = "BotArquivos";
            BotArquivos.Size = new Size(185, 39);
            BotArquivos.TabIndex = 2;
            BotArquivos.Text = "BUSCAR ARQUIVOS";
            BotArquivos.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(3, 447);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1071, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Margin = new Padding(40, 3, 20, 3);
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(500, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(BotMulti);
            panel1.Controls.Add(BotTub);
            panel1.Controls.Add(BotSupTub);
            panel1.Controls.Add(BotMentos);
            panel1.Controls.Add(BotCBINC);
            panel1.Controls.Add(BotInst);
            panel1.Controls.Add(BotElétrica);
            panel1.Controls.Add(Disciplinas);
            panel1.Location = new Point(43, 123);
            panel1.Margin = new Padding(40, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(410, 274);
            panel1.TabIndex = 0;
            // 
            // BotMulti
            // 
            BotMulti.BackColor = Color.IndianRed;
            BotMulti.FlatStyle = FlatStyle.Popup;
            BotMulti.ForeColor = SystemColors.ControlLightLight;
            BotMulti.Location = new Point(118, 220);
            BotMulti.Margin = new Padding(10);
            BotMulti.Name = "BotMulti";
            BotMulti.Size = new Size(182, 33);
            BotMulti.TabIndex = 10;
            BotMulti.Text = "MULTI-DISCIPLINAR";
            BotMulti.UseVisualStyleBackColor = false;
            BotMulti.Click += button9_Click;
            // 
            // BotTub
            // 
            BotTub.BackColor = Color.IndianRed;
            BotTub.FlatStyle = FlatStyle.Popup;
            BotTub.ForeColor = SystemColors.ControlLightLight;
            BotTub.Location = new Point(30, 167);
            BotTub.Margin = new Padding(10, 10, 20, 10);
            BotTub.Name = "BotTub";
            BotTub.Size = new Size(155, 33);
            BotTub.TabIndex = 9;
            BotTub.Text = "TUBULAÇÃO";
            BotTub.UseVisualStyleBackColor = false;
            BotTub.Click += button8_Click;
            // 
            // BotSupTub
            // 
            BotSupTub.BackColor = Color.IndianRed;
            BotSupTub.FlatStyle = FlatStyle.Popup;
            BotSupTub.ForeColor = SystemColors.ControlLightLight;
            BotSupTub.Location = new Point(225, 167);
            BotSupTub.Margin = new Padding(20, 10, 10, 10);
            BotSupTub.Name = "BotSupTub";
            BotSupTub.Size = new Size(155, 33);
            BotSupTub.TabIndex = 8;
            BotSupTub.Text = "SUPORTE DE TUBULAÇÃO";
            BotSupTub.UseVisualStyleBackColor = false;
            // 
            // BotMentos
            // 
            BotMentos.BackColor = Color.IndianRed;
            BotMentos.FlatStyle = FlatStyle.Popup;
            BotMentos.ForeColor = SystemColors.ControlLightLight;
            BotMentos.Location = new Point(30, 114);
            BotMentos.Margin = new Padding(10, 10, 20, 10);
            BotMentos.Name = "BotMentos";
            BotMentos.Size = new Size(155, 33);
            BotMentos.TabIndex = 7;
            BotMentos.Text = "INSTRUMENTOS";
            BotMentos.UseVisualStyleBackColor = false;
            // 
            // BotCBINC
            // 
            BotCBINC.BackColor = Color.IndianRed;
            BotCBINC.FlatStyle = FlatStyle.Popup;
            BotCBINC.ForeColor = SystemColors.ControlLightLight;
            BotCBINC.Location = new Point(225, 114);
            BotCBINC.Margin = new Padding(20, 10, 10, 10);
            BotCBINC.Name = "BotCBINC";
            BotCBINC.Size = new Size(155, 33);
            BotCBINC.TabIndex = 6;
            BotCBINC.Text = "COMBATE A INCÊNDIO";
            BotCBINC.UseVisualStyleBackColor = false;
            // 
            // BotInst
            // 
            BotInst.BackColor = Color.IndianRed;
            BotInst.FlatStyle = FlatStyle.Popup;
            BotInst.ForeColor = SystemColors.ControlLightLight;
            BotInst.Location = new Point(225, 61);
            BotInst.Margin = new Padding(20, 10, 10, 10);
            BotInst.Name = "BotInst";
            BotInst.Size = new Size(155, 33);
            BotInst.TabIndex = 5;
            BotInst.Text = "INSTRUMENTAÇÃO";
            BotInst.UseVisualStyleBackColor = false;
            // 
            // BotElétrica
            // 
            BotElétrica.BackColor = Color.IndianRed;
            BotElétrica.FlatStyle = FlatStyle.Popup;
            BotElétrica.ForeColor = SystemColors.ControlLightLight;
            BotElétrica.Location = new Point(30, 61);
            BotElétrica.Margin = new Padding(10, 10, 20, 10);
            BotElétrica.Name = "BotElétrica";
            BotElétrica.Size = new Size(155, 33);
            BotElétrica.TabIndex = 4;
            BotElétrica.Text = "ELÉTRICA";
            BotElétrica.UseVisualStyleBackColor = false;
            // 
            // Disciplinas
            // 
            Disciplinas.AutoSize = true;
            Disciplinas.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Disciplinas.ForeColor = SystemColors.ButtonFace;
            Disciplinas.Location = new Point(118, 7);
            Disciplinas.Name = "Disciplinas";
            Disciplinas.Size = new Size(174, 37);
            Disciplinas.TabIndex = 1;
            Disciplinas.Text = "DISCIPLINAS";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1077, 472);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Consolidado";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1077, 472);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Ferramentas";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(936, 40);
            pictureBox1.Margin = new Padding(40, 3, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 40);
            pictureBox2.Margin = new Padding(3, 3, 40, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // LabelOrçamento
            // 
            LabelOrçamento.AutoSize = true;
            LabelOrçamento.BackColor = Color.Transparent;
            LabelOrçamento.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelOrçamento.ForeColor = SystemColors.ActiveCaptionText;
            LabelOrçamento.Location = new Point(288, 51);
            LabelOrçamento.Name = "LabelOrçamento";
            LabelOrçamento.Size = new Size(605, 65);
            LabelOrçamento.TabIndex = 3;
            LabelOrçamento.Text = "ORÇAMENTO INDUSTRIAL";
            LabelOrçamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tela_Orçamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 701);
            Controls.Add(LabelOrçamento);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Name = "Tela_Orçamento";
            Text = "Tela_Orçamento";
            Load += Tela_Orçamento_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private Label Disciplinas;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button BotUnico;
        private Button BotArquivos;
        private Panel panel2;
        private Button BotElétrica;
        private Button BotTub;
        private Button BotSupTub;
        private Button BotMentos;
        private Button BotCBINC;
        private Button BotInst;
        private Button BotMulti;
        private Panel panel3;
        private Panel panel4;
        private Label LabelOrçamento;
        private Label label3;
        private ComboBox BoxTA2;
        private Label TA1;
        private ComboBox BoxTA1;
        private Label TA2;
        private ComboBox BoxArea;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelInfo;
    }
}