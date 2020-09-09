using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form2 : Form 
    {
        Form3 form3;

        private int xPalla      = 4;
        private int yPalla      = 3;
        private int punteggio;
        private int count       = 42;
        System.Media.SoundPlayer player  = new System.Media.SoundPlayer();
        System.Media.SoundPlayer vincita = new System.Media.SoundPlayer();
        System.Media.SoundPlayer perdita = new System.Media.SoundPlayer();

        public Form2(Form3 nform3)
        {
            form3 = nform3;
            form3.Hide();

            InitializeComponent();
            player.SoundLocation = "MotivationToAction.wav";
            vincita.SoundLocation = "vinto.wav";
            perdita.SoundLocation = "perso.wav";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            palla.Visible = true;
        }       
               
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && paddle.Left>10)
            {
                paddle.Left -= 10;
            }
            if(e.KeyCode == Keys.Right && paddle.Right < 630)
            {
                paddle.Left += 10;
            }
        }

        private void MovimentoPalla()
        {
            palla.Left += xPalla;
            palla.Top += yPalla;

            if ((palla.Left + palla.Width > this.Width-40) || (palla.Left<20))
            {
                xPalla = -xPalla;
            }
            if ((palla.Top < 70) || (palla.Bounds.IntersectsWith(paddle.Bounds)))
            {
                yPalla = -yPalla;
            }
           
            if (palla.Top == 630)
            {
                GameOver();
            }
           
        }// end MovimentoPalla

       
        private void GetPunteggio()
        {

            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    if (palla.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        punteggio += 1;
                        yPalla = -yPalla;
                        label1.Text = "RISULTATO: " + punteggio;
                        count -= 1;
                    }

                    if (count == 0)
                        YouWon();
                    
                }

            }
            
            
                
        }//end GetPunteggio
       
        private void YouWon()
        {
            vincita.Play();
            timer1.Stop();
            MessageBox.Show("HAI VINTOO!!");
            form3.Show();
            this.Close();

        } //end YouWon
        private void GameOver()
        {
            perdita.Play();
            timer1.Stop();
            MessageBox.Show("Hai perso:(");
            form3.Show();
            this.Close();
           
        }//end GameOver

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            MovimentoPalla();
            GetPunteggio();
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void pictureBox38_DoubleClick(object sender, EventArgs e)
        {
            player.Stop();
        }

       

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rimuovi tutti i mattoni per scoprire l'immagine. \n" +
                "Per accendere la musica clicka una volta sulla nota e per spegnerla due volte. ");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            punteggio = 0;
           
        }//restart label

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            form3.Show();
        }
    }
}
