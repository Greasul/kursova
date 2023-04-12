using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fdsfsdfsdfsdf
{
    public partial class Form1 : Form
    {
        CFigure[] figures;
        int FiguresCount = 0;
        int CurrentFigureIndex;
        public Form1()
        {
            InitializeComponent();
            figures = new CFigure[100];
            comboBox2.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FiguresCount >= 101)
            {
                MessageBox.Show("Досягнуто межі кількості об`єктів");
            return;
            }
            Graphics graphics = panel1.CreateGraphics();
            CurrentFigureIndex = FiguresCount;

            if (comboBox2.SelectedIndex == 0)
            {
                figures[CurrentFigureIndex] = new CCircle(graphics, panel1.Width / 2, panel1.Height / 2, 50);
                comboBox1.Items.Add("Фігура No " +(FiguresCount).ToString() + "[коло]");
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                figures[CurrentFigureIndex] = new CTriangle(graphics, panel1.Width / 2, panel1.Height / 2, 100);
                comboBox1.Items.Add(" Фігура No" +(FiguresCount).ToString() +
                "[трикутник] ");
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                figures[CurrentFigureIndex] = new CRectangle(graphics, panel1.Width / 2, panel1.Height / 2, 50);
                comboBox1.Items.Add("Фігура No" +(FiguresCount).ToString() +
                "[квадрат]");
            }
            figures[CurrentFigureIndex].Show();
            FiguresCount++;
            comboBox1.SelectedIndex = FiguresCount - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            figures[CurrentFigureIndex].Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;
            figures[CurrentFigureIndex].Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            figures[CurrentFigureIndex].Expand(5);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            figures[CurrentFigureIndex].Collapse(5);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            figures[CurrentFigureIndex].Move(0, -2);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            figures[CurrentFigureIndex].Move(0, 2);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;
            figures[CurrentFigureIndex].Move(2, 0);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            figures[CurrentFigureIndex].Move(-2, 0);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(0, 1); System.Threading.Thread.Sleep(5);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0)) return;
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CurrentFigureIndex = comboBox1.SelectedIndex;
            if ((CurrentFigureIndex > FiguresCount) || (CurrentFigureIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                figures[CurrentFigureIndex].Move(-1, 0); System.Threading.Thread.Sleep(5);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }
    }
}
