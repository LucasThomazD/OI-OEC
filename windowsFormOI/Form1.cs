using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Diagnostics;
using System.Drawing.Text;
using System.Threading;
using PdfiumViewer;



namespace windowsFormOI
{



    public partial class Form1 : Form
    {
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private string caminhoImprimir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "imprimir");
        private Dictionary<string, Layout> layouts;
        private string ultimoStatus = "";
        private string caminhoArquivo = "include/log.txt"; // Caminho do arquiv
        private PdfViewer pdfViewer = new PdfViewer();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Evita flickering (tremulação)
            LoadLayouts();
            LayoutComboBox();
            checkTimbrado.Enabled = false;
            checkBranco.Enabled = false;
            comboBranco.Enabled = false;
            comboTim.Enabled = false;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            boxModeloPDF.SelectedIndexChanged += boxModeloPDF_SelectedIndexChanged;
            checkTimbrado.CheckedChanged += checkTimbrado_CheckedChanged;
            checkBranco.CheckedChanged += checkBranco_CheckedChanged;
            //SetRoundedBorder(15, button1, button2, button3, button4, botUnificar, bArquivo, bAplicarInfo, bUnico, bElet, bCBINC, bMentos, bInst, bTub, bSupTub, bMulti, bConsolidado);
            SetRoundedBorder(10, panel1, panel5, panel4, panel6, panel7, panel8);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            try
            {

                if (File.Exists(caminhoArquivo))
                {

                    string novoStatus = File.ReadAllText(caminhoArquivo);

                    if (novoStatus == "Tarefa Concluida")
                    {

                        timer1.Stop();

                    }
                    if (novoStatus != ultimoStatus)
                    {
                        AtualizarStatus(novoStatus);
                        ultimoStatus = novoStatus;

                    }

                }
            }
            catch (Exception ex)
            {

                AtualizarStatus($"Erro ao ler o arquivo de log: {ex.Message}");
            }
        }

        private void botoespdf(System.Windows.Forms.Button button2, System.Windows.Forms.Button button4, System.Windows.Forms.Button botUnificar)
        {
            if (button2.Enabled == true || button4.Enabled == true || botUnificar.Enabled == true)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                botUnificar.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button4.Enabled = true;
                botUnificar.Enabled = true;
            }
        }
        private void SetRoundedBorder(int radius, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Paint += (sender, e) =>
                {
                    Graphics g = e.Graphics;
                    g.SmoothingMode = SmoothingMode.AntiAlias; // Ativa antialiasing
                    this.DoubleBuffered = true;
                    GraphicsPath path = new GraphicsPath();
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    control.Region = new Region(path);
                };

                control.Invalidate(); // Força a atualização do controle
            }
        }



        Process pythonProcess;
        string perso = "Personalizar";

        private void Form1_Load(object sender, EventArgs e)
        {

            BoxTA1.Items.Add("Selecione");
            BoxTA1.Items.Add("TA 24");
            BoxTA1.Items.Add("TA 25");
            BoxTA1.Items.Add("TA 26");
            BoxTA1.Items.Add("TA 27");
            BoxTA1.Items.Add("TA 28");
            BoxTA1.Items.Add("TA 29");
            BoxTA1.Items.Add("TA 30");
            BoxTA1.Items.Add("TA 31");
            BoxTA1.Items.Add("TA 32");
            BoxTA1.Items.Add("TA 33");
            BoxTA1.Items.Add("TA 34");
            BoxTA1.Items.Add("TA 35");
            BoxTA1.Items.Add("TA 36");
            BoxTA1.Items.Add("TA 37");
            BoxTA1.Items.Add("TA 38");
            BoxTA1.Items.Add("TA 39");
            BoxTA1.Items.Add("TA 40");
            BoxTA1.SelectedIndex = 0;

            BoxTA2.Items.Add("Selecione");
            BoxTA2.Items.Add("TA 24");
            BoxTA2.Items.Add("TA 25");
            BoxTA2.Items.Add("TA 26");
            BoxTA2.Items.Add("TA 27");
            BoxTA2.Items.Add("TA 28");
            BoxTA2.Items.Add("TA 29");
            BoxTA2.Items.Add("TA 30");
            BoxTA2.Items.Add("TA 31");
            BoxTA2.Items.Add("TA 32");
            BoxTA2.Items.Add("TA 33");
            BoxTA2.Items.Add("TA 34");
            BoxTA2.Items.Add("TA 35");
            BoxTA2.Items.Add("TA 36");
            BoxTA2.Items.Add("TA 37");
            BoxTA2.Items.Add("TA 38");
            BoxTA2.Items.Add("TA 39");
            BoxTA2.Items.Add("TA 40");
            BoxTA2.SelectedIndex = 0;

            BoxArea.Items.Add("Selecione");
            BoxArea.Items.Add("1000");
            BoxArea.Items.Add("2000");
            BoxArea.Items.Add("2502");
            BoxArea.Items.Add("2511");
            BoxArea.Items.Add("2706");
            BoxArea.Items.Add("2721");
            BoxArea.Items.Add("2722");
            BoxArea.Items.Add("2737");
            BoxArea.Items.Add("2744");
            BoxArea.Items.Add("3000");
            BoxArea.Items.Add("4000");
            BoxArea.Items.Add("5000");
            BoxArea.Items.Add("6000");
            BoxArea.Items.Add("7000");
            BoxArea.Items.Add("7816");
            BoxArea.Items.Add("7818");
            BoxArea.Items.Add("8000");
            BoxArea.SelectedIndex = 0;

            BoxModelo.Items.Add("Selecione");
            BoxModelo.Items.Add("PADRÃO");
            BoxModelo.Items.Add("REDES");
            BoxModelo.Items.Add("COMPLEMENTO");
            BoxModelo.Items.Add("ENTREGAS");
            BoxModelo.Items.Add("PPQ");
            BoxModelo.Items.Add("Fis. Financeiro");
            BoxModelo.Items.Add("Crit. Med");
            BoxModelo.Items.Add("Resumo Fis.");
            BoxModelo.SelectedIndex = 0;

            comboBranco.Items.Add("A3 Paisagem");
            comboBranco.Items.Add("A4 Retrato");
            comboBranco.Items.Add("A4 Paisagem");





            boxModeloPDF.Items.Add("Personalizar");
            boxModeloPDF.SelectedIndex = 0;

            //Configurar ToolTip
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.SetToolTip(LBCataMilho, "Ferramenta de transferência de arquivos de um diretório pra outro");
            this.toolTip1.SetToolTip(labelRaiz, "Pasta Alvo");
            this.toolTip1.SetToolTip(labelDestino, "Destino dos arquivos transferidos da pasta alvo");
            this.toolTip1.SetToolTip(Bt_Organizar, "Organiza os arquivos na pasta out gerando-as no formato do TA");
            this.toolTip1.SetToolTip(PB_BT_Stop_1, "Interrompe o processo do cata milho (Fuga de emergência)");
            this.toolTip1.SetToolTip(PB_gerenciador_1, "Abre no gerenciador de arquivos a pasta de saida dos arquivos Excel");
            this.toolTip1.SetToolTip(bAplicarInfo, "Iniciar o arquivo Excel e atualiza as informações de cabeçalho ");
            this.toolTip1.SetToolTip(bDerrubar, "Fecha o Excel");
            this.toolTip1.SetToolTip(bUnico, "Busca Apenas um arquivo, quando não há o mesmo no TA anterior");
            this.toolTip1.SetToolTip(PB_buscar_1, "Inicia o diálogo de diretorio permitindo a busca manual do caminho com os arquivos");
            this.toolTip1.SetToolTip(PathBox, "Cole aqui o caminho da pasta com os arquivos a serem unificados");
            this.toolTip1.SetToolTip(button2, "Gera arquivos PDF a partir de uma planilha excel, usando as margens continadas nos modelos");
            this.toolTip1.SetToolTip(button4, "Aplica mesclagens no PDF, adicionando timbrado e página em branco");
            this.toolTip1.SetToolTip(button1, "Inicia um PopUp Contendo a ferramenta de Conversão de números");

        }
        private void LerNamedPipe()
        {
            string pipeName = @"\\.\pipe\python_pipe";

            // Verifica a existência da Pipe
            if (!File.Exists(pipeName))
            {
                MessageBox.Show("Named Pipe não está disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lê mensagens da Pipe
            using (FileStream pipeStream = new FileStream(pipeName, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(pipeStream))
            {
                while (!reader.EndOfStream)
                {
                    string mensagem = reader.ReadLine();

                    // Atualiza a ToolStripStatusLabel na thread de UI
                    if (statusStrip1.InvokeRequired)
                    {
                        statusStrip1.Invoke(new System.Action(() =>
                        {
                            toolStripStatusLabel1.Text = mensagem;
                        }));
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = mensagem;
                    }
                }
            }
        }
        private void LoadLayouts()
        {
            try
            {
                // Supondo que o arquivo "layouts.json" esteja na pasta de execução
                string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "layouts_papel.json");
                string jsonText = File.ReadAllText(jsonFile);
                layouts = JsonConvert.DeserializeObject<Dictionary<string, Layout>>(jsonText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o arquivo JSON: " + ex.Message);
            }
        }
        private void LayoutComboBox()
        {
            // Suponha que você tenha uma ComboBox chamada comboBoxLayouts no formulário
            boxModeloPDF.Items.Clear();
            comboTim.Items.Clear();

            if (layouts != null)
            {
                foreach (string key in layouts.Keys)
                {
                    boxModeloPDF.Items.Add(key);
                    comboTim.Items.Add(key);
                }
            }
        }
        private void boxModeloPDF_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se a opção "Personalizar" está selecionada
            if (boxModeloPDF.SelectedItem != null && boxModeloPDF.SelectedItem.ToString() == "Personalizar")
            {
                // Habilita os CheckedListBox
                checkTimbrado.Enabled = true;
                checkBranco.Enabled = true;
            }
            else
            {
                // Desabilita os CheckedListBox
                checkTimbrado.Enabled = false;
                checkBranco.Enabled = false;

                // Opcional: Limpa as seleções
                checkTimbrado.Checked = false;
                checkBranco.Checked = false;
            }




        }

        private void checkTimbrado_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            if (checkTimbrado.Checked)
            {
                checkBranco.Checked = false; // Desmarca a outra CheckBox

            }

            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            comboTim.Enabled = checkTimbrado.Checked;
        }

        private void checkBranco_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            if (checkBranco.Checked)
            {
                checkTimbrado.Checked = false; // Desmarca a outra CheckBox
            }

            // Habilita ou desabilita a ComboBox com base no estado do CheckBox
            comboBranco.Enabled = checkBranco.Checked;
        }



        private void AtualizarStatus(string mensagem, int progresso = -1)
        {
            // Atualiza o texto da StatusLabel
            toolStripStatusLabel1.Text = mensagem;

            // Atualiza o progresso, se fornecido
            if (progresso >= 0)
            {
                toolStripProgressBar1.Value = progresso;
            }

            // Força a atualização da interface
            statusStrip1.Refresh();
        }



        private void EnviarParaExcel(string opcao)
        {
            try
            {
                // Inicializa o Excel
                var excelApp = new Excel.Application();
                string caminhoMacro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src", "macros.xlsm");

                // Abre o arquivo Excel
                workbook = excelApp.Workbooks.Open(caminhoMacro);

                // Torna o Excel visível
                excelApp.Visible = true;

                // Executa a macro com o parâmetro
                excelApp.Run("MinhaMacroComParametro", opcao);

                // Opcional: Fechar o Excel após a execução
                // workbook.Close(false);
                // excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void ComboBoxTArea(System.Windows.Forms.ComboBox BoxTA1, System.Windows.Forms.ComboBox BoxTA2, System.Windows.Forms.ComboBox BoxArea, System.Windows.Forms.ComboBox BoxModelo, System.Windows.Forms.TextBox textInicio, System.Windows.Forms.TextBox textFim)
        {
            try
            {
                var worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Seleciona a primeira planilha
                if (BoxTA1.SelectedIndex > 0 || BoxTA2.SelectedIndex > 0 || BoxArea.SelectedIndex > 0 || BoxArea.SelectedIndex > 0 || textFim.Text != null || textInicio.Text != null)
                {
                    AtualizarStatus($"Atualizando Informações", 75);


                    // Define os valores em células específicas
                    worksheet.Cells[1, 1] = BoxTA1.SelectedItem.ToString(); // Célula A1
                    worksheet.Cells[1, 2] = BoxTA2.SelectedItem.ToString(); // Célula B1
                    worksheet.Cells[1, 3] = BoxArea.SelectedItem.ToString(); // Célula C1
                    worksheet.Cells[2, 2] = textInicio.Text.ToString(); // Célula B2
                    worksheet.Cells[2, 3] = textFim.Text.ToString(); // Célula C2
                    worksheet.Cells[2, 1] = BoxModelo.SelectedItem.ToString(); // Célula A2
                    AtualizarStatus($"Informações Atualizadas", 100);
                    System.Threading.Thread.Sleep(2000);
                    AtualizarStatus($"Pronto Para Buscar Arquivos Comparativos", 0);
                    MessageBox.Show("Informações Atualizadas");
                    return;
                }

                //string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src", "macros.xlsm");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar valores no Excel: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void AbrirMacros()
        {
            try
            {
                // Inicializa o Excel apenas se ainda não estiver inicializado
                if (excelApp == null)
                {
                    AtualizarStatus($"Abrindo Aquivo Excel Fornecedor", 25);
                    excelApp = new Excel.Application();
                    string caminhoMacro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "macros.xlsm");

                    // Abre o arquivo Excel
                    workbook = excelApp.Workbooks.Open(caminhoMacro);
                    AtualizarStatus($"Arquivo Pronto", 50);

                    // Torna o Excel visível (opcional)
                    excelApp.Visible = false;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Abrir Arquivo Macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }
        private void FecharExcel()
        {
            try
            {
                if (workbook != null)
                {
                    AtualizarStatus($"Fechando Planilha", 45);
                    workbook.Close(false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    workbook = null;
                    AtualizarStatus($"Planilha Fechada", 60);
                }

                if (excelApp != null)
                {
                    AtualizarStatus($"Saindo da Aplicação", 78);
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                    AtualizarStatus($"Finalizando Excel", 96);
                    System.Threading.Thread.Sleep(2000);
                    AtualizarStatus($"Planilha Fechada Com Sucesso", 0);
                }
                // Libera os objetos COM
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);


                MessageBox.Show("Excel fechado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar o Excel: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }
        private void AbrirGerenciadorArquivos(string caminho)
        {
            try
            {
                AtualizarStatus($"Abrindo Gerenciador de Arquivos", 40);
                // Abre o Gerenciador de Arquivos no caminho especificado
                System.Diagnostics.Process.Start("explorer.exe", caminho);
                AtualizarStatus($"Caminho Encontrado", 80);
                System.Threading.Thread.Sleep(2000);
                AtualizarStatus($"Gerenciador Aberto em {caminho}", 0);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Gerenciador de Arquivos: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }
        private void bArquivo_Click(object sender, EventArgs e)
        {

            try
            {
                AtualizarStatus($"Buscando Arquivos de Comparação", 30);
                //tenta iniciar macro
                excelApp.Run("ComparativoCpuArea");
                AtualizarStatus($"Quase Lá", 91);
                System.Threading.Thread.Sleep(2000);
                AtualizarStatus($"Arquivos Prontos Para Serem Filtrados", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }



        private void bAplicarInfo_Click(object sender, EventArgs e)
        {
            AbrirMacros();
            ComboBoxTArea(BoxTA1, BoxTA2, BoxArea, BoxModelo, textInicio, textFim);

        }

        private void bUnico_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Buscando Arquivo de Comparação", 30);
                //tenta iniciar macro
                excelApp.Run("gerarUnico");
                AtualizarStatus($"Quase Lá", 91);
                System.Threading.Thread.Sleep(2000);
                AtualizarStatus($"Arquivos Prontos Para Serem Filtrados", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }



        private void bElet_Click(object sender, EventArgs e)
        {
            try
            {
                //tenta iniciar macro
                AtualizarStatus($"Gerando Comparativo de Elétrica", 15);
                excelApp.Run("eletrica");
                AtualizarStatus($"Gerando Comparativo de Elétrica", 56);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de Elétrica Gerado", 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void bCBINC_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Comparativo de Combate a Incêndio", 15);
                excelApp.Run("CBINC");
                AtualizarStatus($"Gerando Comparativo de Combate a incêndio", 56);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de Combate a Incêndio Gerado", 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void bMentos_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Comparativo de Instrumentos", 15);
                excelApp.Run("instrumentos");
                AtualizarStatus($"Gerando Comparativo de Instrumentos", 56);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de Instrumentos Gerado", 100); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void bInst_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Comparativo de Instrumentação", 15);
                excelApp.Run("instrumentacao");
                AtualizarStatus($"Gerando Comparativo de Instrumentação", 56);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de Instrumentação Gerado", 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void bTub_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Comparativo de Tubulação", 15);
                excelApp.Run("tubulacao");
                AtualizarStatus($"Gerando Comparativo de Tubulação", 56);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de Tubulação Gerado", 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void bSupTub_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Comparativo de Suporte de Tubulação", 15);
                excelApp.Run("supTub");
                AtualizarStatus($"Gerando Comparativo de Suporte de Tubulação", 56);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo de Suporte de Tubulação Gerado", 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Comparativo de Todas as Disciplinas da Industrial", 4);
                excelApp.Run("processarDisciplinas");
                AtualizarStatus($"Gerando Comparativo de Todas as Disciplinas da Industrial", 85);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo Multi-Disciplinar Gerado", 92);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Comparativo Multi-Disciplinar Gerado", 100);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Arquivos Salvos na Pasta {"./out"} Lembre de Conferir Quais Arquivos Foram adicionados à pasta", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar macro: " + ex.Message);
                AtualizarStatus($"Error", 0);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Exemplo: Abre a pasta "src" no diretório base do aplicativo
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out");
            AbrirGerenciadorArquivos(caminho);
        }

        private void bDerrubar_Click(object sender, EventArgs e)
        {
            FecharExcel();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bConsolidado_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus($"Gerando Consolidado", 20);
                excelApp.Run("ModelosEscolha");
                AtualizarStatus($"Finalizando Consolidado", 90);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Consolidado Gerado", 100);
                System.Threading.Thread.Sleep(1500);
                AtualizarStatus($"Arquivos Salvos na Pasta {"./out"} Lembre de Conferir Quais Arquivos Foram adicionados à pasta", 0);
                System.Threading.Thread.Sleep(6000);
                AtualizarStatus($"Pronto", 0);

            }

            catch
            {
                MessageBox.Show("Abra o Excel e Atualize as Informações: ");
                AtualizarStatus($"Error", 0);
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (excelApp.Visible == false)
                {
                    excelApp.Visible = true;
                }
                else
                {
                    excelApp.Visible = false;
                }

                AtualizarStatus($"Visibilidade do Excel Alterada", 0);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Visibilidade do Excel" + ex.Message);
            }

        }





        /// ----------------------- Aba PDF --------------------------------



        private string SelecionarArquivoOuPastaExcel()
        {
            string resultado = null; // Variável para armazenar o resultado

            if (radioArquivo.Checked) // Quando o RadioButton para arquivo é selecionado
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos Excel (*.xls*)|*.xls*"; // Filtro de arquivos
                openFileDialog.Title = "Selecione um arquivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                }
            }
            else if (radioPasta.Checked) // Quando o RadioButton para pasta é selecionado
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Selecione uma pasta";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = folderBrowserDialog.SelectedPath; // Armazena o caminho da pasta
                }
            }

            return resultado; // Retorna o valor selecionado
        }
        private string SelecionarArquivoOuPastaPDF()
        {

            string resultado = null; // Variável para armazenar o resultado

            if (radioArquivo.Checked) // Quando o RadioButton para arquivo é selecionado
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos de texto (*.pdf)|*.pdf"; // Filtro de arquivos
                openFileDialog.Title = "Selecione um arquivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = openFileDialog.FileName; // Armazena o caminho do arquivo
                }
            }
            else if (radioPasta.Checked) // Quando o RadioButton para pasta é selecionado
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Selecione uma pasta";


                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    resultado = folderBrowserDialog.SelectedPath; // Armazena o caminho da pasta
                }
            }

            return resultado; // Retorna o valor selecionado
        }



        private void iniciarPythonExcel(System.Windows.Forms.ComboBox boxModeloPDF)

        {
            timer1.Start();
            string selecionado = SelecionarArquivoOuPastaExcel();

            if (selecionado != null)
            {
                string par1 = boxModeloPDF.SelectedItem.ToString();
                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");

                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "Excel_to_PDF.py");


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{par1}\" \"{imprimirpath}\" \"{selecionado}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

                pythonProcess = Process.Start(startInfo);

            }
            else
            {
                AtualizarStatus("Erro Ao Selecionar Pasta ou Arquivo!", 0);
            }
        }
        private void iniciarPython(System.Windows.Forms.ComboBox boxModeloPDF)

        {
            timer1.Start();
            string selecionado = SelecionarArquivoOuPastaPDF();

            if (selecionado != null)
            {
                string par1 = boxModeloPDF.SelectedItem.ToString();
                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");

                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "InserirModelo.py");


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{par1}\" \"{imprimirpath}\" \"{selecionado}\""; // Substitua pelo caminho do seu script Python
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

                pythonProcess = Process.Start(startInfo);
            }
            else
            {
                AtualizarStatus("Erro Ao Selecionar Pasta ou Arquivo!", 0);
            }
        }
        private void unificar(System.Windows.Forms.TextBox PathBox)
        {
            timer1.Start();
            string caminho = PathBox.Text;
            string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "MesclarPDF.py");
            AtualizarStatus("", 0);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
            startInfo.Arguments = $"\"{scriptpath}\" \"{caminho}\""; // Substitua pelo caminho do seu script Python
            startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            pythonProcess = Process.Start(startInfo);
        }


        private void pythonPerso(System.Windows.Forms.ComboBox comboTim, System.Windows.Forms.ComboBox comboBranco)
        {
            timer1.Start();
            string selecionado = SelecionarArquivoOuPastaPDF();

            if (selecionado != null)
            {


                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");
                string scriptpath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "timbrado.py");
                string scriptpath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "PaginaRepetida.py");

                if (checkTimbrado.Checked == true && comboTim.SelectedItem.ToString() != null) {
                    string par1 = comboTim.SelectedItem.ToString();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                    startInfo.Arguments = $"\"{scriptpath1}\" \"{par1}\" \"{imprimirpath}\" \"{selecionado}\""; // Substitua pelo caminho do seu script Python
                    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.CreateNoWindow = true;
                    pythonProcess = Process.Start(startInfo);

                }
                else if (checkBranco.Checked == true && comboBranco.Text != null)
                {
                    string par2 = comboBranco.SelectedItem.ToString();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "python.exe"; // Certifique-se de que o Python está no PATH
                    startInfo.Arguments = $"\"{scriptpath2}\" \"{par2}\" \"{imprimirpath}\" \"{selecionado}\""; // Substitua pelo caminho do seu script Python
                    startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.CreateNoWindow = true;
                    pythonProcess = Process.Start(startInfo);
                }

                else
                {
                    AtualizarStatus("Lembre-se de Escolher um Item Na ComboBox", 0);
                    timer1.Stop();
                }


            }
            else
            {
                AtualizarStatus("Erro Ao Selecionar Pasta ou Arquivo!", 0);

                timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarStatus("Nada Atribuido a Este Botão Ainda!");
        }

        private void button4_Click(object sender, EventArgs e)
        {


            try
            {

                if (radioArquivo.Checked || radioPasta.Checked)
                {
                    if (boxModeloPDF.SelectedItem.ToString() == perso) {

                        pythonPerso(comboTim, comboBranco);
                    }
                    else if (boxModeloPDF.SelectedItem.ToString() != perso)
                    {

                        iniciarPython(boxModeloPDF);


                    }
                }
                else
                {
                    AtualizarStatus("Lembre-se de selecionar umas das opções: Pasta ou Arquivo");

                }
            }


            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "txtConvert.exe");

            if (File.Exists(appPath))
            {
                Process.Start(appPath); // Inicia sua aplicação
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioArquivo.Checked || radioPasta.Checked)
                {
                    if (boxModeloPDF.SelectedItem.ToString() != perso)
                    {
                        AtualizarStatus("Iniciando Processo");
                        iniciarPythonExcel(boxModeloPDF);
                    }


                    else
                    {
                        AtualizarStatus("Modelo Incompativel Com Essa Tarefa");
                    }
                }
                else
                {
                    AtualizarStatus("Lembre-se de selecionar umas das opções: Pasta ou Arquivo");

                }
            }


            catch
            {

            }
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string resultado = null;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecione uma pasta";


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                resultado = folderBrowserDialog.SelectedPath; // Armazena o caminho da pasta
                PathBox.Text = resultado;
            }
            else
            {
                AtualizarStatus("Erro Ao Selecionar Pasta!");

            }
        }

        private void botUnificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(PathBox.Text))
                {

                    unificar(PathBox);

                }

                else
                {
                    AtualizarStatus("Por Favor Inserir o Caminho e Tente Novamente!");

                }
            }
            catch (Exception ex) {
                AtualizarStatus($"Erro {ex.Message}");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AtualizarStatus("Timer1_Tick foi chamado");
        }
        

        
        
        public void Form2() // Construtor padrão
        {
            InitializeComponent();
        }

        private void visualizarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 novoForm = new Form2();
                novoForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir Form2: {ex.Message}");
            }
           
        }
        private void caminhoPDFs_Click(object sender, EventArgs e)
         {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "imprimir");
            AbrirGerenciadorArquivos(caminho);
        }
        private void gerarPDFHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste concluido");
        }
        private void mesclarHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste concluido");
        }
        private void excelTimHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste concluido");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
    public class Layout
    {
        public string fundo { get; set; }
        public string repetido { get; set; }
        public List<int> tamanho { get; set; }  // O JSON usará uma lista, já que tuplas não existem no JSON
        public int topMarg { get; set; }
        public int botMarg { get; set; }
        public int leftMarg { get; set; }
        public int rightMarg { get; set; }
        public int papel { get; set; }
        public int orientacao { get; set; }
    }



}
   

