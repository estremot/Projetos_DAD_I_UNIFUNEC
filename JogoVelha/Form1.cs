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

        Image imagex = Image.FromFile("E:\\Escolas\\FUNEC\\2023\\DAD I\\Projetos_DAD_I_UNIFUNEC\\JogoVelha\\imagens\\x.png");
        Image imageb = Image.FromFile("E:\\Escolas\\FUNEC\\2023\\DAD I\\Projetos_DAD_I_UNIFUNEC\\JogoVelha\\imagens\\bola.png");

        int a = 0;
        int b = 0;
        int c = 0;

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
                pictureBox1.Tag = 1;
            }
            else
            {
                pictureBox1.Image = imageb;
                pictureBox1.Tag = 0;
            }
            valor++;

            pictureBox1.Enabled = false;

         
            verificaLinha1();
        }

        private void verificaLinha1()
        {
            

            if (pictureBox1.Tag != null)
            {
                a = Int32.Parse(pictureBox1.Tag.ToString());
                MessageBox.Show("" + a);
            }
            else
            {
                if (pictureBox2.Tag != null)
                {
                    b = Int32.Parse(pictureBox2.Tag.ToString());
                    MessageBox.Show("" + b);
                }
                else
                {
                    if (pictureBox3.Tag != null)
                    {
                        c = Int32.Parse(pictureBox3.Tag.ToString());
                        MessageBox.Show("c: " + c + "  a: "+a);
                        

                    }
                    else
                    {
                        if (a == b && b == c)
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

                    
            }
                

            

            

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //COLOCAR IMAGEM NO PICTUREBOX
            if (valor % 2 == 0)
            {
                pictureBox2.Image = imagex;
                pictureBox2.Tag = 1;
            }
            else
            {
                pictureBox2.Image = imageb;
                pictureBox2.Tag = 0;
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
                pictureBox3.Tag = 1;
            }
            else
            {
                pictureBox3.Image = imageb;
                pictureBox3.Tag = 0;
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
