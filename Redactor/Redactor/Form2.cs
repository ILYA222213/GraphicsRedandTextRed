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
using NLog;

namespace Redactor
{
    public partial class Form2 : Form
       
    {
        Bitmap pic;
        int x1, y1;
        int index = 1;
        int x, y, sX, sY, cX, cY;
        Graphics g;
        Pen p = new Pen(Color.Black, 1);

        public Form2()
        {
            Logger.Log($"Открытие формы");
            InitializeComponent();
            pic = new Bitmap(10000, 10000);
           
            x1 = y1 = 0;

            g = Graphics.FromImage(pic);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Log($"Кнопка для отображения цвета");
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            button4.BackColor = b.BackColor;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Log($"Сохранение изображения");
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "");
            pic.Save(saveFileDialog1.FileName);
            MessageBox.Show("Изображение сохранено: " + saveFileDialog1.FileName);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Logger.Log($"Открытие изображения");
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
            Logger.Log($"Выбор цвета линии");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            cX = e.X;
            cY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            sX = x - cX;
            sY = y - cY;

            if (index == 2)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
                pictureBox1.Image = pic;
            }

            if (index == 3)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
                pictureBox1.Image = pic;
            }

            if(index == 4)
            {
                g.DrawLine(p, cX, cY, x, y);
                pictureBox1.Image = pic;
            }
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            Logger.Log($"Кнопка круга");
            index = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logger.Log($"Кнопка квадрата");
            index = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Logger.Log($"Кнопка линии");
            index = 4;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Logger.Log($"Кнопка возращение кисти");
            index = 1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Logger.Log($"Изменение размера линии");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Log($"О программе");
            // Текст о программе
            string message = "Это упрощенные графический редактор, с менимальным функционалом.";

            // Отобразить MessageBox
            MessageBox.Show(message, "О программе");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Log($"ЗАкрытие формы");
            // Отобразить запрос подтверждения
            if (MessageBox.Show("Вы действительно хотите закрыть форму?", "Подтверждение закрытия", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Закрыть форму
                this.Close();
            }
        }

        private void очиститьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Log($"Очистить экран");
            pic = new Bitmap(10000, 10000);
            pictureBox1.Image = null;
        }

        private void режимСтёркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Log($"Использование стерки");
            button4.BackColor = Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
          
            if(index == 1)
            {
               
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
            x = e.X;
            y = e.Y;

            sX = e.X - cX;
            sY = e.Y - cY;
        }

    }
}
