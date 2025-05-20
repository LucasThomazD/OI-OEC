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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.RB_RA_Nao = new System.Windows.Forms.RadioButton();
            this.RB_RA_Sim = new System.Windows.Forms.RadioButton();
            this.label_Renomear = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.RB_MT_Copiar = new System.Windows.Forms.RadioButton();
            this.BT_MT_Mover = new System.Windows.Forms.RadioButton();
            this.label_MT = new System.Windows.Forms.Label();
            this.Ck_Cm_All = new System.Windows.Forms.CheckBox();
            this.Ck_Cm_Word = new System.Windows.Forms.CheckBox();
            this.Ck_Cm_Excel = new System.Windows.Forms.CheckBox();
            this.Ck_Cm_PDF = new System.Windows.Forms.CheckBox();
            this.IniciarCM = new System.Windows.Forms.Button();
            this.PB_BT_Stop_1 = new System.Windows.Forms.PictureBox();
            this.PDestinoBox = new System.Windows.Forms.TextBox();
            this.PRaizBox = new System.Windows.Forms.TextBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelRaiz = new System.Windows.Forms.Label();
            this.LBCataMilho = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Bt_Organizar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bConsolidado = new System.Windows.Forms.Button();
            this.bUnico = new System.Windows.Forms.Button();
            this.bArquivo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxArea = new System.Windows.Forms.ComboBox();
            this.bDerrubar = new System.Windows.Forms.Button();
            this.textFim = new System.Windows.Forms.TextBox();
            this.BoxTA2 = new System.Windows.Forms.ComboBox();
            this.bAplicarInfo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textInicio = new System.Windows.Forms.TextBox();
            this.PB_gerenciador_1 = new System.Windows.Forms.PictureBox();
            this.BoxTA1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxModelo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.botUnificar = new System.Windows.Forms.Button();
            this.PB_buscar_1 = new System.Windows.Forms.PictureBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.boxModeloPDF = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboTim = new System.Windows.Forms.ComboBox();
            this.checkTimbrado = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBranco = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBranco = new System.Windows.Forms.CheckBox();
            this.radioArquivo = new System.Windows.Forms.RadioButton();
            this.radioPasta = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastaDistinoPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelETimbradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unificarPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPDFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesclarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BT_Stop_1)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_gerenciador_1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_buscar_1)).BeginInit();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 16);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1028, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage4.Controls.Add(this.panel12);
            this.tabPage4.Controls.Add(this.panel9);
            this.tabPage4.Controls.Add(this.panel8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1092, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ferramentas";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Controls.Add(this.checkBox1);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.label_Renomear);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label_MT);
            this.panel9.Controls.Add(this.Ck_Cm_All);
            this.panel9.Controls.Add(this.Ck_Cm_Word);
            this.panel9.Controls.Add(this.Ck_Cm_Excel);
            this.panel9.Controls.Add(this.Ck_Cm_PDF);
            this.panel9.Controls.Add(this.IniciarCM);
            this.panel9.Controls.Add(this.PB_BT_Stop_1);
            this.panel9.Controls.Add(this.PDestinoBox);
            this.panel9.Controls.Add(this.PRaizBox);
            this.panel9.Controls.Add(this.labelDestino);
            this.panel9.Controls.Add(this.labelRaiz);
            this.panel9.Controls.Add(this.LBCataMilho);
            this.panel9.Location = new System.Drawing.Point(240, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel9.Size = new System.Drawing.Size(520, 293);
            this.panel9.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.RB_RA_Nao);
            this.panel11.Controls.Add(this.RB_RA_Sim);
            this.panel11.ForeColor = System.Drawing.Color.Transparent;
            this.panel11.Location = new System.Drawing.Point(224, 88);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(184, 32);
            this.panel11.TabIndex = 21;
            // 
            // RB_RA_Nao
            // 
            this.RB_RA_Nao.AutoSize = true;
            this.RB_RA_Nao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_RA_Nao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_RA_Nao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_RA_Nao.ForeColor = System.Drawing.Color.Black;
            this.RB_RA_Nao.Location = new System.Drawing.Point(104, 8);
            this.RB_RA_Nao.Name = "RB_RA_Nao";
            this.RB_RA_Nao.Size = new System.Drawing.Size(45, 20);
            this.RB_RA_Nao.TabIndex = 1;
            this.RB_RA_Nao.TabStop = true;
            this.RB_RA_Nao.Text = "Não";
            this.RB_RA_Nao.UseVisualStyleBackColor = true;
            // 
            // RB_RA_Sim
            // 
            this.RB_RA_Sim.AutoSize = true;
            this.RB_RA_Sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_RA_Sim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_RA_Sim.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_RA_Sim.ForeColor = System.Drawing.Color.Black;
            this.RB_RA_Sim.Location = new System.Drawing.Point(16, 8);
            this.RB_RA_Sim.Name = "RB_RA_Sim";
            this.RB_RA_Sim.Size = new System.Drawing.Size(44, 20);
            this.RB_RA_Sim.TabIndex = 0;
            this.RB_RA_Sim.TabStop = true;
            this.RB_RA_Sim.Text = "Sim";
            this.RB_RA_Sim.UseVisualStyleBackColor = true;
            // 
            // label_Renomear
            // 
            this.label_Renomear.AutoSize = true;
            this.label_Renomear.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Renomear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Renomear.Location = new System.Drawing.Point(24, 96);
            this.label_Renomear.Name = "label_Renomear";
            this.label_Renomear.Size = new System.Drawing.Size(173, 18);
            this.label_Renomear.TabIndex = 20;
            this.label_Renomear.Text = "Renomear Arquivos ?";
            this.label_Renomear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.RB_MT_Copiar);
            this.panel10.Controls.Add(this.BT_MT_Mover);
            this.panel10.ForeColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(224, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(184, 32);
            this.panel10.TabIndex = 19;
            // 
            // RB_MT_Copiar
            // 
            this.RB_MT_Copiar.AutoSize = true;
            this.RB_MT_Copiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_MT_Copiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RB_MT_Copiar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_MT_Copiar.ForeColor = System.Drawing.Color.Black;
            this.RB_MT_Copiar.Location = new System.Drawing.Point(104, 8);
            this.RB_MT_Copiar.Name = "RB_MT_Copiar";
            this.RB_MT_Copiar.Size = new System.Drawing.Size(59, 20);
            this.RB_MT_Copiar.TabIndex = 1;
            this.RB_MT_Copiar.TabStop = true;
            this.RB_MT_Copiar.Text = "Copiar";
            this.RB_MT_Copiar.UseVisualStyleBackColor = true;
            // 
            // BT_MT_Mover
            // 
            this.BT_MT_Mover.AutoSize = true;
            this.BT_MT_Mover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_MT_Mover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_MT_Mover.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MT_Mover.ForeColor = System.Drawing.Color.Black;
            this.BT_MT_Mover.Location = new System.Drawing.Point(16, 8);
            this.BT_MT_Mover.Name = "BT_MT_Mover";
            this.BT_MT_Mover.Size = new System.Drawing.Size(56, 20);
            this.BT_MT_Mover.TabIndex = 0;
            this.BT_MT_Mover.TabStop = true;
            this.BT_MT_Mover.Text = "Mover";
            this.BT_MT_Mover.UseVisualStyleBackColor = true;
            // 
            // label_MT
            // 
            this.label_MT.AutoSize = true;
            this.label_MT.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_MT.Location = new System.Drawing.Point(24, 56);
            this.label_MT.Name = "label_MT";
            this.label_MT.Size = new System.Drawing.Size(176, 18);
            this.label_MT.TabIndex = 18;
            this.label_MT.Text = "Modo de transferência";
            this.label_MT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ck_Cm_All
            // 
            this.Ck_Cm_All.AutoSize = true;
            this.Ck_Cm_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_All.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_All.Location = new System.Drawing.Point(328, 176);
            this.Ck_Cm_All.Name = "Ck_Cm_All";
            this.Ck_Cm_All.Size = new System.Drawing.Size(123, 20);
            this.Ck_Cm_All.TabIndex = 17;
            this.Ck_Cm_All.Text = "Todos os Arquivos";
            this.Ck_Cm_All.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_Word
            // 
            this.Ck_Cm_Word.AutoSize = true;
            this.Ck_Cm_Word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_Word.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_Word.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_Word.Location = new System.Drawing.Point(240, 176);
            this.Ck_Cm_Word.Name = "Ck_Cm_Word";
            this.Ck_Cm_Word.Size = new System.Drawing.Size(53, 20);
            this.Ck_Cm_Word.TabIndex = 16;
            this.Ck_Cm_Word.Text = "Word";
            this.Ck_Cm_Word.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_Excel
            // 
            this.Ck_Cm_Excel.AutoSize = true;
            this.Ck_Cm_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_Excel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_Excel.Location = new System.Drawing.Point(152, 176);
            this.Ck_Cm_Excel.Name = "Ck_Cm_Excel";
            this.Ck_Cm_Excel.Size = new System.Drawing.Size(52, 20);
            this.Ck_Cm_Excel.TabIndex = 15;
            this.Ck_Cm_Excel.Text = "Excel";
            this.Ck_Cm_Excel.UseVisualStyleBackColor = true;
            // 
            // Ck_Cm_PDF
            // 
            this.Ck_Cm_PDF.AutoSize = true;
            this.Ck_Cm_PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ck_Cm_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ck_Cm_PDF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Cm_PDF.Location = new System.Drawing.Point(72, 176);
            this.Ck_Cm_PDF.Name = "Ck_Cm_PDF";
            this.Ck_Cm_PDF.Size = new System.Drawing.Size(46, 20);
            this.Ck_Cm_PDF.TabIndex = 14;
            this.Ck_Cm_PDF.Text = "PDF";
            this.Ck_Cm_PDF.UseVisualStyleBackColor = true;
            // 
            // IniciarCM
            // 
            this.IniciarCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.IniciarCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.IniciarCM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarCM.Location = new System.Drawing.Point(408, 232);
            this.IniciarCM.Name = "IniciarCM";
            this.IniciarCM.Size = new System.Drawing.Size(104, 24);
            this.IniciarCM.TabIndex = 13;
            this.IniciarCM.Text = "Iniciar";
            this.IniciarCM.UseVisualStyleBackColor = false;
            // 
            // PB_BT_Stop_1
            // 
            this.PB_BT_Stop_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_BT_Stop_1.Image = ((System.Drawing.Image)(resources.GetObject("PB_BT_Stop_1.Image")));
            this.PB_BT_Stop_1.Location = new System.Drawing.Point(448, 8);
            this.PB_BT_Stop_1.Name = "PB_BT_Stop_1";
            this.PB_BT_Stop_1.Size = new System.Drawing.Size(48, 32);
            this.PB_BT_Stop_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_BT_Stop_1.TabIndex = 12;
            this.PB_BT_Stop_1.TabStop = false;
            // 
            // PDestinoBox
            // 
            this.PDestinoBox.Location = new System.Drawing.Point(152, 256);
            this.PDestinoBox.Name = "PDestinoBox";
            this.PDestinoBox.Size = new System.Drawing.Size(248, 20);
            this.PDestinoBox.TabIndex = 11;
            // 
            // PRaizBox
            // 
            this.PRaizBox.Location = new System.Drawing.Point(152, 216);
            this.PRaizBox.Name = "PRaizBox";
            this.PRaizBox.Size = new System.Drawing.Size(248, 20);
            this.PRaizBox.TabIndex = 10;
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDestino.Location = new System.Drawing.Point(24, 256);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(114, 18);
            this.labelDestino.TabIndex = 9;
            this.labelDestino.Text = "Pasta Destino";
            this.labelDestino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.labelDestino, "Este é um label informativo.");
            // 
            // labelRaiz
            // 
            this.labelRaiz.AutoSize = true;
            this.labelRaiz.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRaiz.Location = new System.Drawing.Point(24, 216);
            this.labelRaiz.Name = "labelRaiz";
            this.labelRaiz.Size = new System.Drawing.Size(87, 18);
            this.labelRaiz.TabIndex = 8;
            this.labelRaiz.Text = "Pasta Raiz";
            this.labelRaiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.labelRaiz, "Este é um label informativo.");
            // 
            // LBCataMilho
            // 
            this.LBCataMilho.AutoSize = true;
            this.LBCataMilho.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCataMilho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBCataMilho.Location = new System.Drawing.Point(192, 8);
            this.LBCataMilho.Name = "LBCataMilho";
            this.LBCataMilho.Size = new System.Drawing.Size(134, 29);
            this.LBCataMilho.TabIndex = 7;
            this.LBCataMilho.Text = "CATA MILHO";
            this.LBCataMilho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.LBCataMilho, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(216, 468);
            this.panel8.TabIndex = 2;
            // 
            // Bt_Organizar
            // 
            this.Bt_Organizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.Bt_Organizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Organizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.Bt_Organizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Organizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Organizar.Location = new System.Drawing.Point(64, 120);
            this.Bt_Organizar.Name = "Bt_Organizar";
            this.Bt_Organizar.Size = new System.Drawing.Size(96, 24);
            this.Bt_Organizar.TabIndex = 7;
            this.Bt_Organizar.Text = "Organizar";
            this.Bt_Organizar.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(24, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 60);
            this.label17.TabIndex = 6;
            this.label17.Text = "FERRAMENTAS\r\n AUXILIARES";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Converter Numeros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Excel";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(640, 344);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 56);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel5.Controls.Add(this.bConsolidado);
            this.panel5.Controls.Add(this.bUnico);
            this.panel5.Controls.Add(this.bArquivo);
            this.panel5.Location = new System.Drawing.Point(40, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(452, 64);
            this.panel5.TabIndex = 10;
            // 
            // bConsolidado
            // 
            this.bConsolidado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bConsolidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConsolidado.FlatAppearance.BorderSize = 0;
            this.bConsolidado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bConsolidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsolidado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bConsolidado.Location = new System.Drawing.Point(320, 16);
            this.bConsolidado.Name = "bConsolidado";
            this.bConsolidado.Size = new System.Drawing.Size(120, 32);
            this.bConsolidado.TabIndex = 15;
            this.bConsolidado.Text = "CONSOLIDAR";
            this.bConsolidado.UseVisualStyleBackColor = false;
            this.bConsolidado.Click += new System.EventHandler(this.bConsolidado_Click);
            // 
            // bUnico
            // 
            this.bUnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bUnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUnico.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bUnico.FlatAppearance.BorderSize = 0;
            this.bUnico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bUnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bUnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bUnico.Location = new System.Drawing.Point(168, 16);
            this.bUnico.Name = "bUnico";
            this.bUnico.Size = new System.Drawing.Size(118, 34);
            this.bUnico.TabIndex = 3;
            this.bUnico.Text = "BUSCAR ÚNICO";
            this.bUnico.UseVisualStyleBackColor = false;
            this.bUnico.Click += new System.EventHandler(this.bUnico_Click);
            // 
            // bArquivo
            // 
            this.bArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArquivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bArquivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bArquivo.Location = new System.Drawing.Point(16, 16);
            this.bArquivo.Name = "bArquivo";
            this.bArquivo.Size = new System.Drawing.Size(118, 34);
            this.bArquivo.TabIndex = 2;
            this.bArquivo.Text = "BUSCAR ARQUIVOS";
            this.bArquivo.UseVisualStyleBackColor = false;
            this.bArquivo.Click += new System.EventHandler(this.bArquivo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(720, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "TRABALHANDO EM MELHORIAS\r\n";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.BoxArea);
            this.panel4.Controls.Add(this.bDerrubar);
            this.panel4.Controls.Add(this.textFim);
            this.panel4.Controls.Add(this.BoxTA2);
            this.panel4.Controls.Add(this.bAplicarInfo);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.textInicio);
            this.panel4.Controls.Add(this.PB_gerenciador_1);
            this.panel4.Controls.Add(this.BoxTA1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.BoxModelo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(554, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 184);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(184, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Área";
            // 
            // BoxArea
            // 
            this.BoxArea.FormattingEnabled = true;
            this.BoxArea.Location = new System.Drawing.Point(248, 64);
            this.BoxArea.Name = "BoxArea";
            this.BoxArea.Size = new System.Drawing.Size(121, 21);
            this.BoxArea.TabIndex = 6;
            // 
            // bDerrubar
            // 
            this.bDerrubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bDerrubar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDerrubar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bDerrubar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDerrubar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDerrubar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bDerrubar.Location = new System.Drawing.Point(400, 104);
            this.bDerrubar.Name = "bDerrubar";
            this.bDerrubar.Size = new System.Drawing.Size(88, 24);
            this.bDerrubar.TabIndex = 9;
            this.bDerrubar.Text = "DERRUBAR";
            this.bDerrubar.UseVisualStyleBackColor = false;
            this.bDerrubar.Click += new System.EventHandler(this.bDerrubar_Click);
            // 
            // textFim
            // 
            this.textFim.Location = new System.Drawing.Point(448, 146);
            this.textFim.Name = "textFim";
            this.textFim.Size = new System.Drawing.Size(40, 20);
            this.textFim.TabIndex = 13;
            // 
            // BoxTA2
            // 
            this.BoxTA2.FormattingEnabled = true;
            this.BoxTA2.Location = new System.Drawing.Point(72, 104);
            this.BoxTA2.Name = "BoxTA2";
            this.BoxTA2.Size = new System.Drawing.Size(72, 21);
            this.BoxTA2.TabIndex = 5;
            // 
            // bAplicarInfo
            // 
            this.bAplicarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bAplicarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAplicarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bAplicarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAplicarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAplicarInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAplicarInfo.Location = new System.Drawing.Point(400, 64);
            this.bAplicarInfo.Name = "bAplicarInfo";
            this.bAplicarInfo.Size = new System.Drawing.Size(88, 24);
            this.bAplicarInfo.TabIndex = 8;
            this.bAplicarInfo.Text = "ATUALIZAR";
            this.bAplicarInfo.UseVisualStyleBackColor = false;
            this.bAplicarInfo.Click += new System.EventHandler(this.bAplicarInfo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(360, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Demais Arq.";
            // 
            // textInicio
            // 
            this.textInicio.Location = new System.Drawing.Point(296, 144);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(40, 20);
            this.textInicio.TabIndex = 12;
            // 
            // PB_gerenciador_1
            // 
            this.PB_gerenciador_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_gerenciador_1.Image = ((System.Drawing.Image)(resources.GetObject("PB_gerenciador_1.Image")));
            this.PB_gerenciador_1.Location = new System.Drawing.Point(456, 8);
            this.PB_gerenciador_1.Name = "PB_gerenciador_1";
            this.PB_gerenciador_1.Size = new System.Drawing.Size(38, 32);
            this.PB_gerenciador_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_gerenciador_1.TabIndex = 9;
            this.PB_gerenciador_1.TabStop = false;
            this.PB_gerenciador_1.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // BoxTA1
            // 
            this.BoxTA1.FormattingEnabled = true;
            this.BoxTA1.Location = new System.Drawing.Point(72, 64);
            this.BoxTA1.Name = "BoxTA1";
            this.BoxTA1.Size = new System.Drawing.Size(72, 21);
            this.BoxTA1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "2° TA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(176, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Começar na Linha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "1° TA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(16, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "COPIAR CABEÇALHO";
            // 
            // BoxModelo
            // 
            this.BoxModelo.FormattingEnabled = true;
            this.BoxModelo.Location = new System.Drawing.Point(248, 104);
            this.BoxModelo.Name = "BoxModelo";
            this.BoxModelo.Size = new System.Drawing.Size(122, 21);
            this.BoxModelo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(182, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(87, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORMAÇÕES SUPLEMENTARES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(526, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 3);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.bMulti);
            this.panel1.Controls.Add(this.bSupTub);
            this.panel1.Controls.Add(this.bTub);
            this.panel1.Controls.Add(this.bInst);
            this.panel1.Controls.Add(this.bMentos);
            this.panel1.Controls.Add(this.bCBINC);
            this.panel1.Controls.Add(this.bElet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 266);
            this.panel1.TabIndex = 0;
            // 
            // bMulti
            // 
            this.bMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMulti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bMulti.Location = new System.Drawing.Point(141, 217);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(172, 34);
            this.bMulti.TabIndex = 10;
            this.bMulti.Text = "MULTI-DISCIPLINAR";
            this.bMulti.UseVisualStyleBackColor = false;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // bSupTub
            // 
            this.bSupTub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bSupTub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSupTub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bSupTub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSupTub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSupTub.Location = new System.Drawing.Point(245, 168);
            this.bSupTub.Name = "bSupTub";
            this.bSupTub.Size = new System.Drawing.Size(172, 34);
            this.bSupTub.TabIndex = 9;
            this.bSupTub.Text = "SUPORTE A TUBULAÇÃO";
            this.bSupTub.UseVisualStyleBackColor = false;
            this.bSupTub.Click += new System.EventHandler(this.bSupTub_Click);
            // 
            // bTub
            // 
            this.bTub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bTub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bTub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bTub.Location = new System.Drawing.Point(36, 168);
            this.bTub.Name = "bTub";
            this.bTub.Size = new System.Drawing.Size(172, 34);
            this.bTub.TabIndex = 8;
            this.bTub.Text = "TUBULAÇÃO";
            this.bTub.UseVisualStyleBackColor = false;
            this.bTub.Click += new System.EventHandler(this.bTub_Click);
            // 
            // bInst
            // 
            this.bInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bInst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bInst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bInst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bInst.Location = new System.Drawing.Point(245, 118);
            this.bInst.Name = "bInst";
            this.bInst.Size = new System.Drawing.Size(172, 34);
            this.bInst.TabIndex = 7;
            this.bInst.Text = "INSTRUMENTAÇÃO";
            this.bInst.UseVisualStyleBackColor = false;
            this.bInst.Click += new System.EventHandler(this.bInst_Click);
            // 
            // bMentos
            // 
            this.bMentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bMentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bMentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bMentos.Location = new System.Drawing.Point(36, 118);
            this.bMentos.Name = "bMentos";
            this.bMentos.Size = new System.Drawing.Size(172, 34);
            this.bMentos.TabIndex = 6;
            this.bMentos.Text = "INSTRUMENTOS";
            this.bMentos.UseVisualStyleBackColor = false;
            this.bMentos.Click += new System.EventHandler(this.bMentos_Click);
            // 
            // bCBINC
            // 
            this.bCBINC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bCBINC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCBINC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bCBINC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCBINC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bCBINC.Location = new System.Drawing.Point(245, 69);
            this.bCBINC.Name = "bCBINC";
            this.bCBINC.Size = new System.Drawing.Size(172, 34);
            this.bCBINC.TabIndex = 5;
            this.bCBINC.Text = "COMBATE A INCÊNDIO";
            this.bCBINC.UseVisualStyleBackColor = false;
            this.bCBINC.Click += new System.EventHandler(this.bCBINC_Click);
            // 
            // bElet
            // 
            this.bElet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.bElet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bElet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.bElet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bElet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bElet.Location = new System.Drawing.Point(36, 69);
            this.bElet.Name = "bElet";
            this.bElet.Size = new System.Drawing.Size(172, 34);
            this.bElet.TabIndex = 4;
            this.bElet.Text = "ELÉTRICA";
            this.bElet.UseVisualStyleBackColor = false;
            this.bElet.Click += new System.EventHandler(this.bElet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTRAR DISCIPLINAS";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel7.Controls.Add(this.botUnificar);
            this.panel7.Controls.Add(this.PB_buscar_1);
            this.panel7.Controls.Add(this.PathBox);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(256, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 96);
            this.panel7.TabIndex = 5;
            // 
            // botUnificar
            // 
            this.botUnificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.botUnificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botUnificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.botUnificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botUnificar.Location = new System.Drawing.Point(200, 54);
            this.botUnificar.Name = "botUnificar";
            this.botUnificar.Size = new System.Drawing.Size(72, 24);
            this.botUnificar.TabIndex = 14;
            this.botUnificar.Text = "INICIAR";
            this.botUnificar.UseVisualStyleBackColor = false;
            this.botUnificar.Click += new System.EventHandler(this.botUnificar_Click);
            // 
            // PB_buscar_1
            // 
            this.PB_buscar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_buscar_1.Image = ((System.Drawing.Image)(resources.GetObject("PB_buscar_1.Image")));
            this.PB_buscar_1.Location = new System.Drawing.Point(232, 8);
            this.PB_buscar_1.Name = "PB_buscar_1";
            this.PB_buscar_1.Size = new System.Drawing.Size(38, 32);
            this.PB_buscar_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_buscar_1.TabIndex = 10;
            this.PB_buscar_1.TabStop = false;
            this.PB_buscar_1.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(24, 56);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(168, 20);
            this.PathBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(40, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "UNIFICAR PDF\'s";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.boxModeloPDF);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.comboTim);
            this.panel6.Controls.Add(this.checkTimbrado);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.comboBranco);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.checkBranco);
            this.panel6.Controls.Add(this.radioArquivo);
            this.panel6.Controls.Add(this.radioPasta);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(24, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 392);
            this.panel6.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(40, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "MESCLAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // boxModeloPDF
            // 
            this.boxModeloPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxModeloPDF.FormattingEnabled = true;
            this.boxModeloPDF.Location = new System.Drawing.Point(40, 104);
            this.boxModeloPDF.Name = "boxModeloPDF";
            this.boxModeloPDF.Size = new System.Drawing.Size(113, 21);
            this.boxModeloPDF.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(8, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "EXCEL E TIMBRADO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(40, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 11;
            this.label16.Text = "MODELO";
            // 
            // comboTim
            // 
            this.comboTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTim.FormattingEnabled = true;
            this.comboTim.Location = new System.Drawing.Point(40, 168);
            this.comboTim.Name = "comboTim";
            this.comboTim.Size = new System.Drawing.Size(113, 21);
            this.comboTim.TabIndex = 10;
            // 
            // checkTimbrado
            // 
            this.checkTimbrado.AutoSize = true;
            this.checkTimbrado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkTimbrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTimbrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTimbrado.Location = new System.Drawing.Point(152, 145);
            this.checkTimbrado.Name = "checkTimbrado";
            this.checkTimbrado.Size = new System.Drawing.Size(13, 12);
            this.checkTimbrado.TabIndex = 6;
            this.checkTimbrado.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(40, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "TIMBRADO";
            // 
            // comboBranco
            // 
            this.comboBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBranco.FormattingEnabled = true;
            this.comboBranco.Location = new System.Drawing.Point(40, 232);
            this.comboBranco.Name = "comboBranco";
            this.comboBranco.Size = new System.Drawing.Size(113, 21);
            this.comboBranco.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(40, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "EM BRANCO";
            // 
            // checkBranco
            // 
            this.checkBranco.AutoSize = true;
            this.checkBranco.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBranco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBranco.Location = new System.Drawing.Point(152, 209);
            this.checkBranco.Name = "checkBranco";
            this.checkBranco.Size = new System.Drawing.Size(13, 12);
            this.checkBranco.TabIndex = 5;
            this.checkBranco.UseVisualStyleBackColor = true;
            // 
            // radioArquivo
            // 
            this.radioArquivo.AutoSize = true;
            this.radioArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioArquivo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioArquivo.Location = new System.Drawing.Point(32, 270);
            this.radioArquivo.Name = "radioArquivo";
            this.radioArquivo.Size = new System.Drawing.Size(74, 20);
            this.radioArquivo.TabIndex = 6;
            this.radioArquivo.TabStop = true;
            this.radioArquivo.Text = "ARQUIVO";
            this.radioArquivo.UseVisualStyleBackColor = true;
            // 
            // radioPasta
            // 
            this.radioPasta.AutoSize = true;
            this.radioPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPasta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioPasta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPasta.Location = new System.Drawing.Point(120, 270);
            this.radioPasta.Name = "radioPasta";
            this.radioPasta.Size = new System.Drawing.Size(59, 20);
            this.radioPasta.TabIndex = 5;
            this.radioPasta.TabStop = true;
            this.radioPasta.Text = "PASTA";
            this.radioPasta.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(79)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(222)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(40, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "GERAR PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarPDFToolStripMenuItem,
            this.pastaDistinoPDFsToolStripMenuItem});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // visualizarPDFToolStripMenuItem
            // 
            this.visualizarPDFToolStripMenuItem.Name = "visualizarPDFToolStripMenuItem";
            this.visualizarPDFToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.visualizarPDFToolStripMenuItem.Text = "Visualizar PDF";
            this.visualizarPDFToolStripMenuItem.Click += new System.EventHandler(this.visualizarPDF_Click);
            // 
            // pastaDistinoPDFsToolStripMenuItem
            // 
            this.pastaDistinoPDFsToolStripMenuItem.Name = "pastaDistinoPDFsToolStripMenuItem";
            this.pastaDistinoPDFsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pastaDistinoPDFsToolStripMenuItem.Text = "Pasta Distino PDF\'s";
            this.pastaDistinoPDFsToolStripMenuItem.Click += new System.EventHandler(this.caminhoPDFs_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelETimbradoToolStripMenuItem,
            this.unificarPDFsToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // excelETimbradoToolStripMenuItem
            // 
            this.excelETimbradoToolStripMenuItem.Name = "excelETimbradoToolStripMenuItem";
            this.excelETimbradoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.excelETimbradoToolStripMenuItem.Text = "Unificar PDF\'s";
            this.excelETimbradoToolStripMenuItem.Click += new System.EventHandler(this.excelTimHelp_Click);
            // 
            // unificarPDFsToolStripMenuItem
            // 
            this.unificarPDFsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarPDFsToolStripMenuItem,
            this.mesclarToolStripMenuItem});
            this.unificarPDFsToolStripMenuItem.Name = "unificarPDFsToolStripMenuItem";
            this.unificarPDFsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.unificarPDFsToolStripMenuItem.Text = "Excel e Timbrado";
            // 
            // gerarPDFsToolStripMenuItem
            // 
            this.gerarPDFsToolStripMenuItem.Name = "gerarPDFsToolStripMenuItem";
            this.gerarPDFsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.gerarPDFsToolStripMenuItem.Text = "Gerar PDF\'s";
            this.gerarPDFsToolStripMenuItem.Click += new System.EventHandler(this.gerarPDFHelp_Click);
            // 
            // mesclarToolStripMenuItem
            // 
            this.mesclarToolStripMenuItem.Name = "mesclarToolStripMenuItem";
            this.mesclarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.mesclarToolStripMenuItem.Text = "Mesclar";
            this.mesclarToolStripMenuItem.Click += new System.EventHandler(this.mesclarHelp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(40, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(24, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 24);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Buscar Por Palavra Chave";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 23;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(194)))), ((int)(((byte)(63)))));
            this.panel12.Controls.Add(this.label18);
            this.panel12.Controls.Add(this.textBox2);
            this.panel12.Controls.Add(this.radioButton2);
            this.panel12.Controls.Add(this.radioButton1);
            this.panel12.Controls.Add(this.Bt_Organizar);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(240, 315);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(232, 156);
            this.panel12.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ordenar Pastas TA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.label7, "Ferramenta para transferir arquivos de um diretório para outro");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(24, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Padrão";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(112, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Personalizado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(8, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 18);
            this.label18.TabIndex = 25;
            this.label18.Text = "Path";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 740);
            this.MinimumSize = new System.Drawing.Size(1200, 740);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versão 1.0.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BT_Stop_1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_gerenciador_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_buscar_1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bConsolidado;
        private System.Windows.Forms.Button bUnico;
        private System.Windows.Forms.Button bArquivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BoxArea;
        private System.Windows.Forms.Button bDerrubar;
        private System.Windows.Forms.TextBox textFim;
        private System.Windows.Forms.ComboBox BoxTA2;
        private System.Windows.Forms.Button bAplicarInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textInicio;
        private System.Windows.Forms.PictureBox PB_gerenciador_1;
        private System.Windows.Forms.ComboBox BoxTA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BoxModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bSupTub;
        private System.Windows.Forms.Button bTub;
        private System.Windows.Forms.Button bInst;
        private System.Windows.Forms.Button bMentos;
        private System.Windows.Forms.Button bCBINC;
        private System.Windows.Forms.Button bElet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button botUnificar;
        private System.Windows.Forms.PictureBox PB_buscar_1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox boxModeloPDF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboTim;
        private System.Windows.Forms.CheckBox checkTimbrado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBranco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBranco;
        private System.Windows.Forms.RadioButton radioArquivo;
        private System.Windows.Forms.RadioButton radioPasta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastaDistinoPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelETimbradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unificarPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarPDFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesclarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Bt_Organizar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LBCataMilho;
        private System.Windows.Forms.Label labelRaiz;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.TextBox PDestinoBox;
        private System.Windows.Forms.TextBox PRaizBox;
        private System.Windows.Forms.PictureBox PB_BT_Stop_1;
        private System.Windows.Forms.Button IniciarCM;
        private System.Windows.Forms.CheckBox Ck_Cm_All;
        private System.Windows.Forms.CheckBox Ck_Cm_Word;
        private System.Windows.Forms.CheckBox Ck_Cm_Excel;
        private System.Windows.Forms.CheckBox Ck_Cm_PDF;
        private System.Windows.Forms.Label label_MT;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton BT_MT_Mover;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton RB_RA_Nao;
        private System.Windows.Forms.RadioButton RB_RA_Sim;
        private System.Windows.Forms.Label label_Renomear;
        private System.Windows.Forms.RadioButton RB_MT_Copiar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

