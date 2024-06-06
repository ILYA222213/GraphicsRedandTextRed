using System;
using System.IO;
using QRCoder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|TIM Notepad File(*.tnf)|*.tnf";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SaveAsQRCode(string filePath)
        {
            // Чтение содержимого файла
            string fileContent = File.ReadAllText(filePath);

            // Создание объекта генератора QR-кода
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(fileContent, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Рендеринг QR-кода в изображение
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            // Выбор директории для сохранения файла
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Генерация уникального имени файла на основе текущей даты и времени
                string qrCodeFilePath = Path.Combine(folderBrowserDialog1.SelectedPath, DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");

                // Сохранение QR-кода как изображения PNG
                qrCodeImage.Save(qrCodeFilePath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show("QR-код сохранен в файле " + qrCodeFilePath);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            MessageBox.Show("Файл открыт.");
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void настройкиШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void настройкиФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Cut();
            }
        }


        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void сохраитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);

            // Вызов метода сохранения файла с помощью QR-кода
            SaveAsQRCode(filename);

            MessageBox.Show("QR code сохранен.");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("Файл сохранен.");
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создать новую форму
            Form2 form2 = new Form2();

            // Показать новую форму
            form2.Show();
        }
    }
}
