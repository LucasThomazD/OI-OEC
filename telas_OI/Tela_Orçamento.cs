using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace telas_OI
{
    public partial class Tela_Orçamento : Form
    {
        public Tela_Orçamento()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Evita flickering (tremulação)
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Cria um gradiente diagonal do azul pro roxo
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FloralWhite,
                Color.DeepSkyBlue,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }



        private void Tela_Orçamento_Load(object sender, EventArgs e)
        {
            BoxTA1.Items.Add("Selecione");
            BoxTA1.Items.Add("24");
            BoxTA1.Items.Add("25");
            BoxTA1.Items.Add("26");
            BoxTA1.Items.Add("27");
            BoxTA1.Items.Add("28");
            BoxTA1.Items.Add("29");
            BoxTA1.Items.Add("30");
            BoxTA1.Items.Add("31");
            BoxTA1.Items.Add("32");
            BoxTA1.Items.Add("33");
            BoxTA1.Items.Add("34");
            BoxTA1.Items.Add("35");
            BoxTA1.Items.Add("36");
            BoxTA1.Items.Add("37");
            BoxTA1.Items.Add("38");
            BoxTA1.Items.Add("39");
            BoxTA1.Items.Add("40");
            BoxTA1.SelectedIndex = 0;

            BoxTA2.Items.Add("Selecione");
            BoxTA2.Items.Add("24");
            BoxTA2.Items.Add("25");
            BoxTA2.Items.Add("26");
            BoxTA2.Items.Add("27");
            BoxTA2.Items.Add("28");
            BoxTA2.Items.Add("29");
            BoxTA2.Items.Add("30");
            BoxTA2.Items.Add("31");
            BoxTA2.Items.Add("32");
            BoxTA2.Items.Add("33");
            BoxTA2.Items.Add("34");
            BoxTA2.Items.Add("35");
            BoxTA2.Items.Add("36");
            BoxTA2.Items.Add("37");
            BoxTA2.Items.Add("38");
            BoxTA2.Items.Add("39");
            BoxTA2.Items.Add("40");
            BoxTA2.SelectedIndex = 0;

            BoxArea.Items.Add("Selecione");
            BoxArea.Items.Add("Área 1000");
            BoxArea.Items.Add("Área 2000");
            BoxArea.Items.Add("Área 2502");
            BoxArea.Items.Add("Área 2511");
            BoxArea.Items.Add("Área 2706");
            BoxArea.Items.Add("Área 2721");
            BoxArea.Items.Add("Área 2722");
            BoxArea.Items.Add("Área 2737");
            BoxArea.Items.Add("Área 2744");
            BoxArea.Items.Add("Área 3000");
            BoxArea.Items.Add("Área 4000");
            BoxArea.Items.Add("Área 5000");
            BoxArea.Items.Add("Área 6000");
            BoxArea.Items.Add("Área 7000");
            BoxArea.Items.Add("Área 7816");
            BoxArea.Items.Add("Área 7818");
            BoxArea.Items.Add("Área 8000");
            BoxArea.SelectedIndex = 0;
            }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string opcaoSelecionada = "A";

            if (!string.IsNullOrEmpty(opcaoSelecionada))
            {
                EnviarParaExcel(opcaoSelecionada);
            }

        }
        private void EnviarParaExcel(string opcao)
        {
            try
            {
                var excelApp = new Excel.Application();
                string caminhoMacro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src", "macro.xlsm");
                var workbook = excelApp.Workbooks.Open(caminhoMacro);

                excelApp.Visible = true;

                excelApp.Run("MinhaMacroComParametro", opcao);

                // Você pode deixar o Excel aberto ou fechá-lo depois:
                // workbook.Close(false);
                // excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar macro: " + ex.Message);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }

}
