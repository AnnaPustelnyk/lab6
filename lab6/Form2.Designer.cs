namespace lab6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 45);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 1;
            label1.Text = "Karta pracy dyplomowej inżynierskiej";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 129);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Uczelnia";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 165);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Kierunek";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 201);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 4;
            label4.Text = "Studia w zakresie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 129);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 5;
            label5.Text = "Profil studiów";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 165);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 6;
            label6.Text = "Forma studiów";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 201);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 7;
            label7.Text = "Poziom studiów";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "Politechnika Poznańska";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(433, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(433, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(433, 197);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(35, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(647, 165);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Imię i nazwisko";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 139;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nr albumu";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 108;
            // 
            // Column3
            // 
            Column3.HeaderText = "Data i podpis";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 128;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 482);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 15;
            label8.Text = "Tytuł pracy";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 517);
            label9.Name = "label9";
            label9.Size = new Size(160, 20);
            label9.TabIndex = 16;
            label9.Text = "Wersja angielska tytułu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 550);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 17;
            label10.Text = "Dane wejściowe";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 586);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 18;
            label11.Text = "Zakres pracy";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 624);
            label12.Name = "label12";
            label12.Size = new Size(153, 20);
            label12.TabIndex = 19;
            label12.Text = "Termin oddania pracy";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 661);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 20;
            label13.Text = "Promotor";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 693);
            label14.Name = "label14";
            label14.Size = new Size(246, 20);
            label14.TabIndex = 21;
            label14.Text = "Jednostka organizacyjna promotora";
            // 
            // button1
            // 
            button1.Location = new Point(130, 737);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "ZAPISZ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(385, 737);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 23;
            button2.Text = "ODCZYT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(281, 479);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(281, 514);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(281, 547);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(281, 583);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 27;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(281, 621);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 27);
            textBox11.TabIndex = 28;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(281, 658);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 27);
            textBox12.TabIndex = 29;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(281, 690);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(125, 27);
            textBox13.TabIndex = 30;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(753, 778);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public TextBox textBox4;
        public TextBox textBox5;
        public TextBox textBox6;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button1;
        private Button button2;
        public TextBox textBox7;
        public TextBox textBox8;
        public TextBox textBox9;
        public TextBox textBox10;
        public TextBox textBox11;
        public TextBox textBox12;
        public TextBox textBox13;
    }
}