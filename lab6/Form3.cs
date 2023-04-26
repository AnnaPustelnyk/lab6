using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Form3 : Form
    {
        private BindingList<Blank> dataList;
        private Opinie newItem;
        int Index;
        public Form3(BindingList<Blank> dataList, int selectedIndex)
        {
            InitializeComponent();
            this.dataList = dataList;
            Index = selectedIndex;
            if (selectedIndex == 1)
            {
                newItem = new OpinieP();
            }
            else if (selectedIndex == 2)
            {
                newItem = new OpinieR();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Index == 1)
            {
                OpinieP opinieP = new OpinieP();
                SetOpinieVariables(opinieP);
                opinieP.Promotor = textBox1.Text;
                opinieP.UnitP = textBox2.Text;
                opinieP.criteriumH = textBox15.Text;
                this.newItem = opinieP;

                dataList.Add(newItem);

                XmlSerializer serializer = new XmlSerializer(typeof(OpinieP));
                using (TextWriter writer = new StreamWriter("opinie_promotora.xml"))
                {
                    serializer.Serialize(writer, newItem);
                }
            }
            else if (Index == 2)
            {
                OpinieR opinieR = new OpinieR();
                SetOpinieVariables(opinieR);
                opinieR.Recenzent = textBox1.Text;
                opinieR.UnitR = textBox2.Text;
                this.newItem = opinieR;

                dataList.Add(newItem);

                XmlSerializer serializer = new XmlSerializer(typeof(OpinieR));
                using (TextWriter writer = new StreamWriter("opinia_recenzenta.xml"))
                {
                    serializer.Serialize(writer, newItem);
                }
            }



            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public void SetOpinieVariables(Opinie newItem)
        {
            newItem.Title = textBox3.Text;
            newItem.Dyplomant = textBox4.Text;
            newItem.Faculty = textBox5.Text;
            newItem.NrAlbumu = textBox6.Text;
            newItem.Field = textBox7.Text;
            newItem.criteriumA = textBox8.Text;
            newItem.criteriumB = textBox9.Text;
            newItem.criteriumC = textBox10.Text;
            newItem.criteriumD = textBox11.Text;
            newItem.criteriumE = textBox12.Text;
            newItem.criteriumF = textBox13.Text;
            newItem.criteriumG = textBox14.Text;
            newItem.conclusion = textBox16.Text;
            newItem.Mark = textBox17.Text;
            newItem.MarkWord = textBox18.Text;
        }

        public void SetTextBox(Opinie newItem)
        {
            textBox3.Text = newItem.Title;
            textBox4.Text = newItem.Dyplomant;
            textBox5.Text = newItem.Faculty;
            textBox6.Text = newItem.NrAlbumu;
            textBox7.Text = newItem.Field;
            textBox8.Text = newItem.criteriumA;
            textBox9.Text = newItem.criteriumB;
            textBox10.Text = newItem.criteriumC;
            textBox11.Text = newItem.criteriumD;
            textBox12.Text = newItem.criteriumE;
            textBox13.Text = newItem.criteriumF;
            textBox14.Text = newItem.criteriumG;
            textBox16.Text = newItem.conclusion;
            textBox17.Text = newItem.Mark;
            textBox18.Text = newItem.MarkWord;

            if (newItem is OpinieP)
            {
                OpinieP newItemP = (OpinieP)newItem;
                textBox1.Text = newItemP.Promotor;
                textBox2.Text = newItemP.UnitP;
                textBox15.Text = newItemP.criteriumH;
            }
            else if (newItem is OpinieR)
            {
                OpinieR newItemR = (OpinieR)newItem;
                textBox1.Text = newItemR.Recenzent;
                textBox2.Text = newItemR.UnitR;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(Index == 1)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(OpinieP));

                using (FileStream fileStream = new FileStream("opinie_promotora.xml", FileMode.Open))
                {
                    OpinieP Item = (OpinieP)serializer.Deserialize(fileStream);
                    SetTextBox(Item);
                }
            }
            else if (Index == 2)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(OpinieR));

                using (FileStream fileStream = new FileStream("opinia_recenzenta.xml", FileMode.Open))
                {
                    OpinieR Item = (OpinieR)serializer.Deserialize(fileStream);
                    SetTextBox(Item);
                }
            }
        }

    }
}
