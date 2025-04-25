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



namespace windowsFormOI
{

    

    public partial class Form1 : Form
    {
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private string caminhoImprimir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "imprimir");
        private Dictionary<string, Layout> layouts;

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
            

            boxModeloPDF.SelectedIndexChanged += boxModeloPDF_SelectedIndexChanged;
            checkTimbrado.CheckedChanged += checkTimbrado_CheckedChanged;
            checkBranco.CheckedChanged += checkBranco_CheckedChanged;

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.GhostWhite,
                Color.DeepSkyBlue,
                LinearGradientMode.Vertical))
                
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
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


            boxModeloPDF.Items.Add("Personalizar");
            boxModeloPDF.SelectedIndex = 0;


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
                string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include","layouts_papel.json");
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
            if (layouts != null)
            {
                foreach (string key in layouts.Keys)
                {
                    boxModeloPDF.Items.Add(key);
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
                AtualizarStatus($"Error",0);
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
                AtualizarStatus($"Error",0);
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
            string selecionado = SelecionarArquivoOuPastaExcel();

            if (selecionado != null)
            {
                string par1 = boxModeloPDF.SelectedItem.ToString();
                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");

                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "Excel_to_PDF.py");


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "pyPDF", "Scripts", "python.exe"); // Certifique-se de que o Python está no PATH
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
            string selecionado = SelecionarArquivoOuPastaPDF();

            if (selecionado != null)
            {
                string par1 = boxModeloPDF.SelectedItem.ToString();
                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");

                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "InserirModelo.py");


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "pyPDF", "Scripts", "python.exe"); // Certifique-se de que o Python está no PATH
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


        private void pythonPerso(System.Windows.Forms.ComboBox boxModeloPDF)
        {
            string selecionado = SelecionarArquivoOuPastaExcel();

            if (selecionado != null)
            {
                string par1 = boxModeloPDF.SelectedItem.ToString();
                bool par2 = checkTimbrado.Checked;
                bool par3 = checkBranco.Checked;
                string imprimirpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "Imprimir");
                string scriptpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "include", "InserirModelo.py");


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", "pyPDF", "Scripts", "python.exe"); // Certifique-se de que o Python está no PATH
                startInfo.Arguments = $"\"{scriptpath}\" \"{par1}\" \"{imprimirpath}\" \"{selecionado}\" \"{par2}\" \"{par3}\""; // Substitua pelo caminho do seu script Python
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (radioArquivo.Checked || radioPasta.Checked)
                {   
                    if (boxModeloPDF.SelectedItem.ToString() == perso) {
                        
                        pythonPerso(boxModeloPDF);
                    }
                    else if(boxModeloPDF.SelectedItem.ToString() != perso)
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
   

