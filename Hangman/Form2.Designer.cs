namespace Hangman
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.palla = new System.Windows.Forms.PictureBox();
            this.paddle = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.palla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(126, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 120;
            this.label1.Text = "RISULTATO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(551, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 122;
            this.label2.Text = "START ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(717, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 38);
            this.label3.TabIndex = 123;
            this.label3.Text = "EXIT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button37
            // 
            this.button37.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button37.Enabled = false;
            this.button37.Location = new System.Drawing.Point(771, 416);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(143, 47);
            this.button37.TabIndex = 119;
            this.button37.Text = "button37";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button38.Enabled = false;
            this.button38.Location = new System.Drawing.Point(622, 416);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(143, 47);
            this.button38.TabIndex = 118;
            this.button38.Text = "button38";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button39.Enabled = false;
            this.button39.Location = new System.Drawing.Point(473, 416);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(143, 47);
            this.button39.TabIndex = 117;
            this.button39.Text = "button39";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button40.Enabled = false;
            this.button40.Location = new System.Drawing.Point(324, 416);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(143, 47);
            this.button40.TabIndex = 116;
            this.button40.Text = "button40";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button41.Enabled = false;
            this.button41.Location = new System.Drawing.Point(175, 416);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(143, 47);
            this.button41.TabIndex = 115;
            this.button41.Text = "button41";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button42.Enabled = false;
            this.button42.Location = new System.Drawing.Point(26, 416);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(143, 47);
            this.button42.TabIndex = 114;
            this.button42.Text = "button42";
            this.button42.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button31.Enabled = false;
            this.button31.Location = new System.Drawing.Point(771, 363);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(143, 47);
            this.button31.TabIndex = 113;
            this.button31.Text = "button31";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button32.Enabled = false;
            this.button32.Location = new System.Drawing.Point(622, 363);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(143, 47);
            this.button32.TabIndex = 112;
            this.button32.Text = "button32";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button33.Enabled = false;
            this.button33.Location = new System.Drawing.Point(473, 363);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(143, 47);
            this.button33.TabIndex = 111;
            this.button33.Text = "button33";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button34.Enabled = false;
            this.button34.Location = new System.Drawing.Point(324, 363);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(143, 47);
            this.button34.TabIndex = 110;
            this.button34.Text = "button34";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button35.Enabled = false;
            this.button35.Location = new System.Drawing.Point(175, 363);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(143, 47);
            this.button35.TabIndex = 109;
            this.button35.Text = "button35";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button36.Enabled = false;
            this.button36.Location = new System.Drawing.Point(26, 363);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(143, 47);
            this.button36.TabIndex = 108;
            this.button36.Text = "button36";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.Enabled = false;
            this.button25.Location = new System.Drawing.Point(771, 310);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(143, 47);
            this.button25.TabIndex = 107;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button26.Enabled = false;
            this.button26.Location = new System.Drawing.Point(622, 310);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(143, 47);
            this.button26.TabIndex = 106;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button27.Enabled = false;
            this.button27.Location = new System.Drawing.Point(473, 310);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(143, 47);
            this.button27.TabIndex = 105;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button28.Enabled = false;
            this.button28.Location = new System.Drawing.Point(324, 310);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(143, 47);
            this.button28.TabIndex = 104;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button29.Enabled = false;
            this.button29.Location = new System.Drawing.Point(175, 310);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(143, 47);
            this.button29.TabIndex = 103;
            this.button29.Text = "button29";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button30.Enabled = false;
            this.button30.Location = new System.Drawing.Point(26, 310);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(143, 47);
            this.button30.TabIndex = 102;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Enabled = false;
            this.button19.Location = new System.Drawing.Point(771, 257);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(143, 47);
            this.button19.TabIndex = 101;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.Enabled = false;
            this.button20.Location = new System.Drawing.Point(622, 257);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(143, 47);
            this.button20.TabIndex = 100;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.Enabled = false;
            this.button21.Location = new System.Drawing.Point(473, 257);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(143, 47);
            this.button21.TabIndex = 99;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.Enabled = false;
            this.button22.Location = new System.Drawing.Point(324, 257);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(143, 47);
            this.button22.TabIndex = 98;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.Enabled = false;
            this.button23.Location = new System.Drawing.Point(175, 257);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(143, 47);
            this.button23.TabIndex = 97;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.Enabled = false;
            this.button24.Location = new System.Drawing.Point(26, 257);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(143, 47);
            this.button24.TabIndex = 96;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(771, 204);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(143, 47);
            this.button13.TabIndex = 95;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Enabled = false;
            this.button14.Location = new System.Drawing.Point(622, 204);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(143, 47);
            this.button14.TabIndex = 94;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Enabled = false;
            this.button15.Location = new System.Drawing.Point(473, 204);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(143, 47);
            this.button15.TabIndex = 93;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Enabled = false;
            this.button16.Location = new System.Drawing.Point(324, 204);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(143, 47);
            this.button16.TabIndex = 92;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(175, 204);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(143, 47);
            this.button17.TabIndex = 91;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Enabled = false;
            this.button18.Location = new System.Drawing.Point(26, 204);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(143, 47);
            this.button18.TabIndex = 90;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(771, 151);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 47);
            this.button7.TabIndex = 89;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(622, 151);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 47);
            this.button8.TabIndex = 88;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(473, 151);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 47);
            this.button9.TabIndex = 87;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(324, 151);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(143, 47);
            this.button10.TabIndex = 86;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(175, 151);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 47);
            this.button11.TabIndex = 85;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(26, 151);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(143, 47);
            this.button12.TabIndex = 84;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(771, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 47);
            this.button6.TabIndex = 83;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(622, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 47);
            this.button5.TabIndex = 82;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(473, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 47);
            this.button4.TabIndex = 81;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(324, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 47);
            this.button3.TabIndex = 80;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(175, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 47);
            this.button2.TabIndex = 79;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Hangman.Properties.Resources.brick;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(23, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 78;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // palla
            // 
            this.palla.Image = global::Hangman.Properties.Resources.ball;
            this.palla.Location = new System.Drawing.Point(429, 526);
            this.palla.Name = "palla";
            this.palla.Size = new System.Drawing.Size(50, 50);
            this.palla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palla.TabIndex = 77;
            this.palla.TabStop = false;
            // 
            // paddle
            // 
            this.paddle.Image = global::Hangman.Properties.Resources.paddle;
            this.paddle.Location = new System.Drawing.Point(356, 625);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(216, 24);
            this.paddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paddle.TabIndex = 75;
            this.paddle.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = global::Hangman.Properties.Resources.question;
            this.pictureBox39.Location = new System.Drawing.Point(884, 12);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(56, 50);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox39.TabIndex = 72;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Click += new System.EventHandler(this.pictureBox39_Click);
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = global::Hangman.Properties.Resources.music;
            this.pictureBox38.Location = new System.Drawing.Point(12, 12);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(53, 50);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox38.TabIndex = 43;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Click += new System.EventHandler(this.pictureBox38_Click);
            this.pictureBox38.DoubleClick += new System.EventHandler(this.pictureBox38_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hangman.Properties.Resources.sunset;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 690);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.palla);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "BrickBreaker";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.palla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.PictureBox palla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}