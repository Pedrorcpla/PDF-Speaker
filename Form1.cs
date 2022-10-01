using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech;
using System.Speech.Synthesis;
using System.Globalization;

using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace LeitorPDF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public string arquivo;
        private void buscarPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();

            dialogo.Title = "Procurar PDFs no computador";

            dialogo.InitialDirectory = @"C:\";

            dialogo.Filter = "Arquivos texto (*.pdf)|*.pdf";
            
            DialogResult resposta = dialogo.ShowDialog();

            if (resposta == DialogResult.OK)
            {
                arquivo = dialogo.FileName;
                enderecoPDF.Text = arquivo;
                ler.Enabled = true;

                continuar.Enabled = false;
                parar.Enabled = false;

                axAcroPDF1.LoadFile(arquivo);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            axAcroPDF1.Dispose();
        }
        static string ConverteTxtPDF(string nameFile, int paginaInicial, int paginaFinal)
        {
            string resultado = null;
            PdfReader pdfReader = new PdfReader(nameFile);
            PdfDocument pdfDocument = new PdfDocument(pdfReader);

            if(paginaFinal == 0)
            {
                for (int page = paginaInicial; page <= pdfDocument.GetNumberOfPages(); page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string conteudo = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(page), strategy);
                    resultado += conteudo;
                }
            }
            else if(paginaFinal > paginaInicial)
            {
                for (int page = paginaInicial; page <= paginaFinal; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string conteudo = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(page), strategy);
                    resultado += conteudo;
                }
            } 
            else if(paginaFinal == paginaInicial)
            {
                int page = paginaInicial;
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string conteudo = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(page), strategy);
                resultado += conteudo;
            }

            pdfDocument.Close();
            pdfReader.Close();
            return resultado;
        }

        private void ler_Click(object sender, EventArgs e)
        {
            int paginaInicial = 1, paginaFinal = 0;

            if (enderecoPDF.Text != "")
            {
                if (inicio.Text != "")
                {
                    paginaInicial = int.Parse(inicio.Text);
                }
                if (termina.Text != "")
                {
                    paginaFinal = int.Parse(termina.Text);
                }

                parar.Enabled = true;
                ler.Enabled = false;
                continuar.Enabled = false;

                synthesizer.Dispose();

                synthesizer = new SpeechSynthesizer();

                if (comboIdioma.Text == "Pt-BR")
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("pt-br"));
                }
                else if (comboIdioma.Text == "En-US")
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("en-us"));
                }
                else
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("pt-br"));
                }

                string texto = ConverteTxtPDF(arquivo, paginaInicial, paginaFinal);
                synthesizer.SpeakAsync(texto);
            }
            else
            {
                MessageBox.Show("Selecione algum arquivo!");
            }
        }

        private void parar_Click(object sender, EventArgs e)
        {
            ler.Enabled = true;
            continuar.Enabled = true;
            parar.Enabled = false;
            synthesizer.Pause();
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            ler.Enabled = false;
            continuar.Enabled = false;
            parar.Enabled = true;
            
            if (comboIdioma.Text == "Pt-BR")
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("pt-br"));
            }
            else if (comboIdioma.Text == "En-US")
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("en-us"));
            }
            else
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("pt-br"));
            }

            synthesizer.Resume();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void termina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
