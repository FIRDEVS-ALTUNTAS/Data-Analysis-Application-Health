using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Analiz2
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
                filePath = openFileDialog.FileName;  // Yolu sakla
            }
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                // Python scriptini çağırarak analiz yapalım
                RunPythonScript(filePath);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir dosya yolu girin.");
            }
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            // Word dosyasının oluşturulup oluşturulmadığını kontrol et ve dosyayı indir
            CreateWordDocument();
        }

        private void RunPythonScript(string filePath)
        {
            string pythonExePath = @"C:\Users\Firdevs\anaconda3\python.exe";
            string scriptPath = @"C:\Users\Firdevs\PycharmProjects\pythonProject1\AnalizUygulama.py";

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonExePath;
            start.Arguments = $"{scriptPath} \"{filePath}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    resultTextBox.Text = result;
                }
                using (StreamReader reader = process.StandardError)
                {
                    string error = reader.ReadToEnd();
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Hata oluştu: " + error);
                    }
                }
            }
        }

        private void CreateWordDocument()
        {
            string wordSourcePath = @"C:\Users\Firdevs\PycharmProjects\pythonProject1\analysis_report.docx";
            string wordDestinationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "analysis_report.docx");

            if (File.Exists(wordSourcePath))
            {
                File.Copy(wordSourcePath, wordDestinationPath, true);
                MessageBox.Show($"Word belgesi indirildi: {wordDestinationPath}");
            }
            else
            {
                MessageBox.Show("Word belgesi bulunamadı. Lütfen analiz tamamlandıktan sonra tekrar deneyin.");
            }
        }
    }
}
