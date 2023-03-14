using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SimulaEnter
{
    public partial class Form1 : Form
    {

        int valor = 0;
        public Form1()
        {
            InitializeComponent();
            valor++;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // label1.Text = ((int)(e.KeyChar))+"";
           if(e.KeyChar == 27)
            {
                //Application.Exit();
            }
            if(e.KeyChar == 13)
            {
                MessageBox.Show("Você apertou o Enter!!!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            System.Drawing.Image image1 = System.Drawing.Image.FromFile("C:\\Users\\" +
                "marco\\Desktop\\img1.png");
            System.Drawing.Image image2 = System.Drawing.Image.FromFile("C:\\Users\\" +
                "marco\\Desktop\\img2.png");

            // Set the size of the label to accommodate the bitmap size.

            label1.Size = new Size(image1.Width, image1.Height);


            if (valor % 2 == 0)
            {
                label3.Image = image1;
            }
            else
            {
                label3.Image = image2;
            }
            valor++;

            if(e.KeyCode == Keys.Up)
            {
                label3.Location = new Point(label3.Location.X, label3.Location.Y - 5);
                label3.BackColor = Color.Red;
            }

            if (e.KeyCode == Keys.Down)
            {
                label3.Location = new Point(label3.Location.X, label3.Location.Y + 5);
                label3.BackColor = Color.Red;
            }

            if (e.KeyCode == Keys.Left)
            {
                label3.Location = new Point(label3.Location.X - 5, label3.Location.Y);
                label3.BackColor = Color.Blue;
            }

            if (e.KeyCode == Keys.Right)
            {
                label3.Location = new Point(label3.Location.X + 5, label3.Location.Y);
                label3.BackColor = Color.Blue;
            }
        }
    }
}
