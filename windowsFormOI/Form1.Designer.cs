using System.Drawing.Drawing2D;


namespace windowsFormOI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textFim = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textInicio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxModelo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bDerrubar = new System.Windows.Forms.Button();
            this.bAplicarInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxArea = new System.Windows.Forms.ComboBox();
            this.BoxTA2 = new System.Windows.Forms.ComboBox();
            this.BoxTA1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bUnico = new System.Windows.Forms.Button();
            this.bArquivo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bMulti = new System.Windows.Forms.Button();
            this.bSupTub = new System.Windows.Forms.Button();
            this.bTub = new System.Windows.Forms.Button();
            this.bInst = new System.Windows.Forms.Button();
            this.bMentos = new System.Windows.Forms.Button();
            this.bCBINC = new System.Windows.Forms.Button();
            this.bElet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(40, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.bUnico);
            this.tabPage2.Controls.Add(this.bArquivo);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comparativo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.textFim);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.textInicio);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.BoxModelo);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(552, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(512, 192);
            this.panel5.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(264, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Abrir Diretório De Arquivos";
            // 
            // textFim
            // 
            this.textFim.Location = new System.Drawing.Point(208, 154);
            this.textFim.Name = "textFim";
            this.textFim.Size = new System.Drawing.Size(40, 20);
            this.textFim.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(448, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // textInicio
            // 
            this.textInicio.Location = new System.Drawing.Point(88, 154);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(40, 20);
            this.textInicio.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(160, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(24, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Início";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(24, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "LINHAS DE INICIO E FIM (OPN)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modelo";
            // 
            // BoxModelo
            // 
            this.BoxModelo.FormattingEnabled = true;
            this.BoxModelo.Location = new System.Drawing.Point(96, 66);
            this.BoxModelo.Name = "BoxModelo";
            this.BoxModelo.Size = new System.Drawing.Size(152, 21);
            this.BoxModelo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(144, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "CONSOLIDAR PLANILHAS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.bDerrubar);
            this.panel4.Controls.Add(this.bAplicarInfo);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.BoxArea);
            this.panel4.Controls.Add(this.BoxTA2);
            this.panel4.Controls.Add(this.BoxTA1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(554, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 118);
            this.panel4.TabIndex = 6;
            // 
            // bDerrubar
            // 
            this.bDerrubar.Location = new System.Drawing.Point(400, 80);
            this.bDerrubar.Name = "bDerrubar";
            this.bDerrubar.Size = new System.Drawing.Size(88, 24);
            this.bDerrubar.TabIndex = 9;
            this.bDerrubar.Text = "DERRUBAR";
            this.bDerrubar.UseVisualStyleBackColor = true;
            this.bDerrubar.Click += new System.EventHandler(this.bDerrubar_Click);
            // 
            // bAplicarInfo
            // 
            this.bAplicarInfo.Location = new System.Drawing.Point(408, 48);
            this.bAplicarInfo.Name = "bAplicarInfo";
            this.bAplicarInfo.Size = new System.Drawing.Size(72, 24);
            this.bAplicarInfo.TabIndex = 8;
            this.bAplicarInfo.Text = "APLICAR";
            this.bAplicarInfo.UseVisualStyleBackColor = true;
            this.bAplicarInfo.Click += new System.EventHandler(this.bAplicarInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(192, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Área";
            // 
            // BoxArea
            // 
            this.BoxArea.FormattingEnabled = true;
            this.BoxArea.Location = new System.Drawing.Point(248, 48);
            this.BoxArea.Name = "BoxArea";
            this.BoxArea.Size = new System.Drawing.Size(121, 21);
            this.BoxArea.TabIndex = 6;
            // 
            // BoxTA2
            // 
            this.BoxTA2.FormattingEnabled = true;
            this.BoxTA2.Location = new System.Drawing.Point(80, 80);
            this.BoxTA2.Name = "BoxTA2";
            this.BoxTA2.Size = new System.Drawing.Size(72, 21);
            this.BoxTA2.TabIndex = 5;
            // 
            // BoxTA1
            // 
            this.BoxTA1.FormattingEnabled = true;
            this.BoxTA1.Location = new System.Drawing.Point(80, 48);
            this.BoxTA1.Name = "BoxTA1";
            this.BoxTA1.Size = new System.Drawing.Size(72, 21);
            this.BoxTA1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "2° TA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "1° TA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(87, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORMAÇÕES SUPLEMENTARES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(526, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 3);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bUnico
            // 
            this.bUnico.Location = new System.Drawing.Point(304, 72);
            this.bUnico.Name = "bUnico";
            this.bUnico.Size = new System.Drawing.Size(118, 34);
            this.bUnico.TabIndex = 3;
            this.bUnico.Text = "BUSCAR ÚNICO";
            this.bUnico.UseVisualStyleBackColor = true;
            this.bUnico.Click += new System.EventHandler(this.bUnico_Click);
            // 
            // bArquivo
            // 
            this.bArquivo.Location = new System.Drawing.Point(96, 72);
            this.bArquivo.Name = "bArquivo";
            this.bArquivo.Size = new System.Drawing.Size(118, 34);
            this.bArquivo.TabIndex = 2;
            this.bArquivo.Text = "BUSCAR ARQUIVOS";
            this.bArquivo.UseVisualStyleBackColor = true;
            this.bArquivo.Click += new System.EventHandler(this.bArquivo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(523, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 480);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.bMulti);
            this.panel1.Controls.Add(this.bSupTub);
            this.panel1.Controls.Add(this.bTub);
            this.panel1.Controls.Add(this.bInst);
            this.panel1.Controls.Add(this.bMentos);
            this.panel1.Controls.Add(this.bCBINC);
            this.panel1.Controls.Add(this.bElet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 266);
            this.panel1.TabIndex = 0;
            // 
            // bMulti
            // 
            this.bMulti.Location = new System.Drawing.Point(141, 217);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(172, 34);
            this.bMulti.TabIndex = 10;
            this.bMulti.Text = "MULTI-DISCIPLINAR";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // bSupTub
            // 
            this.bSupTub.Location = new System.Drawing.Point(245, 168);
            this.bSupTub.Name = "bSupTub";
            this.bSupTub.Size = new System.Drawing.Size(172, 34);
            this.bSupTub.TabIndex = 9;
            this.bSupTub.Text = "SUPORTE A TUBULAÇÃO";
            this.bSupTub.UseVisualStyleBackColor = true;
            this.bSupTub.Click += new System.EventHandler(this.bSupTub_Click);
            // 
            // bTub
            // 
            this.bTub.Location = new System.Drawing.Point(36, 168);
            this.bTub.Name = "bTub";
            this.bTub.Size = new System.Drawing.Size(172, 34);
            this.bTub.TabIndex = 8;
            this.bTub.Text = "TUBULAÇÃO";
            this.bTub.UseVisualStyleBackColor = true;
            this.bTub.Click += new System.EventHandler(this.bTub_Click);
            // 
            // bInst
            // 
            this.bInst.Location = new System.Drawing.Point(245, 118);
            this.bInst.Name = "bInst";
            this.bInst.Size = new System.Drawing.Size(172, 34);
            this.bInst.TabIndex = 7;
            this.bInst.Text = "INSTRUMENTAÇÃO";
            this.bInst.UseVisualStyleBackColor = true;
            this.bInst.Click += new System.EventHandler(this.bInst_Click);
            // 
            // bMentos
            // 
            this.bMentos.Location = new System.Drawing.Point(36, 118);
            this.bMentos.Name = "bMentos";
            this.bMentos.Size = new System.Drawing.Size(172, 34);
            this.bMentos.TabIndex = 6;
            this.bMentos.Text = "INSTRUMENTOS";
            this.bMentos.UseVisualStyleBackColor = true;
            this.bMentos.Click += new System.EventHandler(this.bMentos_Click);
            // 
            // bCBINC
            // 
            this.bCBINC.Location = new System.Drawing.Point(245, 69);
            this.bCBINC.Name = "bCBINC";
            this.bCBINC.Size = new System.Drawing.Size(172, 34);
            this.bCBINC.TabIndex = 5;
            this.bCBINC.Text = "COMBATE A INCÊNDIO";
            this.bCBINC.UseVisualStyleBackColor = true;
            this.bCBINC.Click += new System.EventHandler(this.bCBINC_Click);
            // 
            // bElet
            // 
            this.bElet.Location = new System.Drawing.Point(36, 69);
            this.bElet.Name = "bElet";
            this.bElet.Size = new System.Drawing.Size(172, 34);
            this.bElet.TabIndex = 4;
            this.bElet.Text = "ELÉTRICA";
            this.bElet.UseVisualStyleBackColor = true;
            this.bElet.Click += new System.EventHandler(this.bElet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISCIPLINAS";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1092, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consolidar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1092, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ferramentas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(960, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(240, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(694, 59);
            this.label7.TabIndex = 9;
            this.label7.Text = "ORÇAMENTO INDUSTRIAL";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "BUSCAR PASTA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 740);
            this.MinimumSize = new System.Drawing.Size(1200, 740);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bUnico;
        private System.Windows.Forms.Button bArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bElet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bSupTub;
        private System.Windows.Forms.Button bTub;
        private System.Windows.Forms.Button bInst;
        private System.Windows.Forms.Button bMentos;
        private System.Windows.Forms.Button bCBINC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BoxArea;
        private System.Windows.Forms.ComboBox BoxTA2;
        private System.Windows.Forms.ComboBox BoxTA1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bAplicarInfo;
        private System.Windows.Forms.Button bDerrubar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BoxModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textFim;
        private System.Windows.Forms.TextBox textInicio;
        private System.Windows.Forms.Button button1;
    }
}

