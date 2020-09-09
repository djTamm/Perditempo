using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        Form3 form3;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private string parolacor, parola, aiuto;
        private string parolamiss;
        private string trattini;
        
        PictureBox[] PictureBoxes;
        int errorCount = 0;

        public Form1(Form3 nform3)
        {
            form3 = nform3;
            form3.Hide();
            InitializeComponent();
            player.SoundLocation = "pianomoment.wav";
        }       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BENVENUTO/A, devi scoprire la parola nascosta senza fare 5 sbagli.");
            PictureBoxes = new PictureBox[]
            { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6};

            textBox1.Visible = false;
            label1.Visible   = false;
            label4.Visible   = false;
            label5.Visible   = false;
            help.Visible     = false;
        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stai chiudendo il gioco. :(");
            form3.Show();
            this.Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reset();
            ScegliParola();          
            GetHint();
            GetClue();

        } //end (re)START click
        private void Reset()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            textBox1.Visible    = true;            
            parolamiss          = "";
            errorCount          = 0;
            label5.Text         = "NOPE: ";
            help.Visible        = false;
            textBox1.Clear();
            label1.Visible      = false;
            label4.Visible      = true;
            label5.Visible      = true;
            trattini            = "";
            label6.Text         = " ";
            
        }
        private void ScegliParola()

        {
            
            Random rnd = new Random();
            string filePath = Path.Combine(Path.GetDirectoryName
                (System.Reflection.Assembly.GetExecutingAssembly().Location), "listaParole.txt"); //per vedere il file messo nel bin 
            using (TextReader tr = new StreamReader(filePath, Encoding.ASCII))
            {

                var tutteParole = tr.ReadToEnd().Split(new[] { '\n' },
                    StringSplitOptions.RemoveEmptyEntries);
                parolacor = tutteParole[rnd.Next(0, tutteParole.Length - 1)];
            }
            
        }//end ScegliParola

        private void GetHint()
        {
            
            string[] soluzione = parolacor.Split('/');
            parola             = soluzione[0];
            aiuto              = soluzione[1];
            label1.Text        = "SOLUZIONE: " + parola;           
            help.Text          = "HINT: " +  aiuto;
            
        }//end GetHint

        

        private void GetClue()
        {
                        
            for (int i = 0; i < parola.Length; i++)
            {
                trattini += "_";
            }
            label6.Text += trattini;

        }
        
       
        private void Controlla()
        {
            char[] sup         = parola.ToCharArray();
            string prova       = textBox1.Text;
            prova              = prova.ToUpper();
            char[] temp        = prova.ToCharArray();
            StringBuilder clue = new StringBuilder(trattini);

            if (temp.Length == 1)
            {
                if (parola.Contains(prova) == false && parolamiss.Contains(prova) == false)
                {
                    parolamiss = parolamiss + prova + ", ";
                    errorCount += 1;
                    textBox1.Clear();
                    prova = "";

                }
                else if (parolamiss.Contains(prova) || trattini.Contains(prova))
                {
                    MessageBox.Show("Hai già provato quello.");
                    textBox1.Clear();
                    prova = "";

                }

                for (int i=0; i<sup.Length; i++)
                {
                    if (temp[0] == sup[i]) 
                    {
                        clue[i]  = sup[i];
                        trattini = clue.ToString();                                                                   
                    }
                    
                }
                label6.Text = "YUP: " + clue;
               
                              
            }

            else
            {
                if (((prova.Length == parola.Length) && (prova == parola))||label6.Text == parola)
                {
                    MessageBox.Show("Congratulazioni, hai indovinato la parola. \n Se vuoi" +
                        " riprovare fai click su (re)START :)");
                    label1.Visible = true;
                }
                else if ((prova.Length>1) && (prova != parola))
                {
                    MessageBox.Show("Hai sbagliato :(");
                    textBox1.Clear();
                    prova = "";
                }
            }

            label5.Text = "NOPE: " + parolamiss;
            if (errorCount >= 3)
                help.Visible = true;

        }//end Controlla

        private void musica_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void musica_DoubleClick(object sender, EventArgs e)
        {
            player.Stop();
        }

       

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserisci le lettere per indovinare la parola nascosta, oppure se hai corraggio la intera parola. \n" +
                "Se non ci riesci ti aiutero' con un hint. Per verificare clicka su 'CONTROLLA' e per chiudere il gioco 'EXIT'.\n" +
                "Per accendere la musica fai un click sulla nota e due per spegnerla. \n ENJOY");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Controlla();
            
            PictureBoxes[errorCount].Visible = true;
            if (errorCount==5)
            {
                MessageBox.Show("Hai sbagliato troppe volte :( \n Fai click su (re)START per riprovare!");
                label1.Visible      = true;
                textBox1.Visible    = false;
                label4.Visible      = false;

            }

        }       

    }//end form1  

}//end namespace Hangman
