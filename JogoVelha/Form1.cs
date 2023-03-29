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

        //LINHA 1
        string a = null;
        string b = null;
        string c = null;

        //LINHA 2
        string d = null;
        string e1 = null;
        string f = null;

        //linha 3
        string h = null;
        string i = null;
        string j = null;

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

        private void verificaLinha3()
        {
            if (h != null && i != null && j != null)
            {
                if (h.Equals(i) && i.Equals(j))
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
        }
        private void verificaLinha2()
        {
            if (d != null && e1 != null && f != null)
            {

                if (d.Equals(e1) && e1.Equals(f))
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
        }

        private void verificaLinha1()
        {

            if (a != null && b != null && c != null)
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
                d = x;
            }
            else
            {
                pictureBox4.Image = imageb;
                d = bola;
            }
            valor++;

            pictureBox4.Enabled = false;
            verificaLinha2();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox5.Image = imagex;
                e1 = x;
            }
            else
            {
                pictureBox5.Image = imageb;
                e1 = bola;
            }
            valor++;
            pictureBox5.Enabled = false;

            verificaLinha2();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox6.Image = imagex;
                f = x;
            }
            else
            {
                pictureBox6.Image = imageb;
                f = bola;
            }
            valor++;
            pictureBox6.Enabled = false;

            verificaLinha2();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox7.Image = imagex;
                h = x;
            }
            else
            {
                pictureBox7.Image = imageb;
                h = bola;
            }
            valor++;
            pictureBox7.Enabled = false;

            verificaLinha3();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox8.Image = imagex;
                i = x;
            }
            else
            {
                pictureBox8.Image = imageb;
                i = bola;
            }
            valor++;
            pictureBox8.Enabled = false;
            verificaLinha3();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox9.Image = imagex;
                j = x;
            }
            else
            {
                pictureBox9.Image = imageb;
                j = bola;
            }
            valor++;
            pictureBox9.Enabled = false;
            verificaLinha3();
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
