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
    public partial class Form3 : Form
    {
        Form1 form1;
        Form2 form2;
        public Form3()
        {
            InitializeComponent();
            form1 = new Form1(this);
            form2 = new Form2(this);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = ("Benvenuto a PERDITEMPO 2020, se non hai niente da fare " +
                "o vuoi semplicemente ascoltare la musica senza guardare nel vuoto e sembrare " +
                "strano, questo fa per te! \n Scegli una delle due opzioni.");
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try {
                form2.Show();
                this.Hide();
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Non è possibile riaprire questa forma.");
            }
               
        }//BrickWall

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide(); 
        }//Hangman

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CIAO CIAO :(");
            this.Close();
        }
    }
}
