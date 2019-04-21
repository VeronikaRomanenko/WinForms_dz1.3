using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_dz1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }
                if ((e.X < 10 || e.X > ClientSize.Width - 10) && (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    MessageBox.Show("Текущая точка находится снаружи прямоугольника");
                }
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) && (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    MessageBox.Show("Текущая точка находится на границе прямоугольника");
                }
                else
                {
                    MessageBox.Show("Текущая точка находится внутри прямоугольника");
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}";
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X}, Y = {e.Y}";
        }
    }
}