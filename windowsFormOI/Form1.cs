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

namespace windowsFormOI
{   

    public partial class Form1 : Form
    {
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private string caminhoImprimir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out", "imprimir");


        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Evita flickering (tremulação)
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




        }
        private void button9_Click(object sender, EventArgs e)
        {
            string opcaoSelecionada = "A";

            if (!string.IsNullOrEmpty(opcaoSelecionada))
            {
                EnviarParaExcel(opcaoSelecionada);
            }
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
                    MessageBox.Show("Por favor, selecione opções válidas em ambos os campos.");
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
        private void ComboBoxEscolha(System.Windows.Forms.ComboBox BoxModelo, System.Windows.Forms.TextBox textInicio, System.Windows.Forms.TextBox textFim, System.Windows.Forms.ComboBox BoxTA1)
        {

            
            try
            {
                var worksheet = (Excel.Worksheet)workbook.Sheets[1];
                if (textFim.Text != null || textInicio.Text != null)
                    {
                    worksheet.Cells[2, 2] = textInicio.Text.ToString(); // Célula B2
                    worksheet.Cells[2, 3] = textFim.Text.ToString(); // Célula C2
                }
                worksheet.Cells[2, 1] = BoxModelo.SelectedItem.ToString(); // Célula A2
                worksheet.Cells[1, 1] = BoxTA1.SelectedItem.ToString(); // Célula A1
                System.Threading.Thread.Sleep(2000);
                
            }

            catch(Exception ex) 
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
            try { 
                if(excelApp.Visible == false)
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
    }
    
    
}
   

