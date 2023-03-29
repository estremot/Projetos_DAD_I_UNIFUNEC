using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Form1 : Form
    {
        int valor = 0;
        static string x = "E:\\Escolas\\FUNEC\\2023\\DAD I\\Projetos_DAD_I_UNIFUNEC\\JogoVelha\\imagens\\x.png";
        static string bola = "E:\\Escolas\\FUNEC\\2023\\DAD I\\Projetos_DAD_I_UNIFUNEC\\JogoVelha\\imagens\\bola.png";
        Image imagex = Image.FromFile(x);
        Image imageb = Image.FromFile(bola);

        string a = null;
        string b = null;
        string c = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if(valor % 2 == 0)
            {
                pictureBox1.Image = imagex;
                a = x;
            }
            else
            {
                pictureBox1.Image = imageb;
                a = bola;
            }
            valor++;

            pictureBox1.Enabled = false;

         
            verificaLinha1();
        }

        private void verificaLinha1()
        {
            
            if (a.Equals(b) && b.Equals(c))
            {
                if (valor % 2 == 0)
                {
                    MessageBox.Show("Bola Venceu");
                }
                else
                {
                    MessageBox.Show("X Venceu");
                }

            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox2.Image = imagex;
                b = x;
            }
            else
            {
                pictureBox2.Image = imageb;
                b = bola;
            }
            valor++;

            pictureBox2.Enabled = false;

            verificaLinha1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox3.Image = imagex;
                c = x;
            
            }
            else
            {
                pictureBox3.Image = imageb;
                c = bola;
            }
            valor++;
            pictureBox3.Enabled = false;

            verificaLinha1();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox4.Image = imagex;
            }
            else
            {
                pictureBox4.Image = imageb;
            }
            valor++;

            pictureBox4.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox5.Image = imagex;
            }
            else
            {
                pictureBox5.Image = imageb;
            }
            valor++;
            pictureBox5.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox6.Image = imagex;
            }
            else
            {
                pictureBox6.Image = imageb;
            }
            valor++;
            pictureBox6.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox7.Image = imagex;
            }
            else
            {
                pictureBox7.Image = imageb;
            }
            valor++;
            pictureBox7.Enabled = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox8.Image = imagex;
            }
            else
            {
                pictureBox8.Image = imageb;
            }
            valor++;
            pictureBox8.Enabled = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox9.Image = imagex;
            }
            else
            {
                pictureBox9.Image = imageb;
            }
            valor++;
            pictureBox9.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reinicioJogo(this.Controls);
        }

        private void reinicioJogo(Control.ControlCollection controls)
        {
            foreach (Control controle in controls) { 
                if(controle is PictureBox)
                {
                    ((PictureBox)controle).Image = null;
                    ((PictureBox)controle).Enabled = true;
                }

                if (controle is CheckBox)
                {
                    ((CheckBox)controle).Checked = false;
                   
                }
            }

            valor = 0;
        }
    }
}
