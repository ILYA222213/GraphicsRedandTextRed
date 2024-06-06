using System;
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
    public partial class Form2 : Form
       
    {
        Bitmap pic;
        int x1, y1;
        Pen p;
        public Form2()
        {
            InitializeComponent();
            pic = new Bitmap(10000, 10000);
           
            x1 = y1 = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button4.BackColor = b.BackColor;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") ;
            pic.Save(saveFileDialog1.FileName);
            MessageBox.Show("Изображение сохранено: " + saveFileDialog1.FileName);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    try
                    {
                        pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                        pictureBox1.Image = pic;
                        MessageBox.Show("Изображение открыто: " + openFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось открыть файл: " + ex.Message);
                    }
                }
            }
        }

        private void выбратьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создать диалоговое окно выбора цвета
            ColorDialog colorDialog = new ColorDialog();

            // Показать диалоговое окно и получить выбранный цвет
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Установить цвет кнопки выбора цвета в выбранный цвет
                button4.BackColor = colorDialog.Color;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
        }

        private void стеркаToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Текст о программе
            string message = "Это упрощенные графический редактор, с менимальным функционалом.";

            // Отобразить MessageBox
            MessageBox.Show(message, "О программе");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отобразить запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите закрыть форму?", "Подтверждение закрытия", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Закрыть форму
                this.Close();
            }
        }
            private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
          
            {
                Pen p;
                p = new Pen(button4.BackColor, trackBar1.Value);
                p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                Graphics g;
                g = Graphics.FromImage(pic);



                if (e.Button == MouseButtons.Left)
                {
                    g.DrawLine(p, x1, y1, e.X, e.Y);
                    pictureBox1.Image = pic;
                }
                x1 = e.X;
                y1 = e.Y;
            }
        }

    }
}
