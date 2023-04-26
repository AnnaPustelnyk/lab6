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

namespace lab6
{
    public partial class Form4 : Form
    {
        private BindingList<Blank> dataList;
        public Form4(BindingList<Blank> dataList)
        {
            InitializeComponent();
            this.dataList = dataList;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Panel my_panel = new Panel();
            VScrollBar vScroller = new VScrollBar();
            vScroller.Dock = DockStyle.Right;
            vScroller.Width = 30;
            vScroller.Height = 200;
            vScroller.Name = "VScrollBar1";
            my_panel.Controls.Add(vScroller);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Protokol newItem = new Protokol();

            newItem.NameSurname = textBox1.Text;
            newItem.Data = textBox2.Text;
            newItem.City = textBox3.Text;
            newItem.Nralbumu = textBox4.Text;
            newItem.DataExam = textBox5.Text;
            newItem.Title = textBox6.Text;
            newItem.Faculty = textBox7.Text;
            newItem.Field = textBox8.Text;
            newItem.Profile = textBox9.Text;
            newItem.Form = textBox10.Text;
            newItem.Level = textBox11.Text;
            newItem.DataOfStart = textBox12.Text;
            newItem.ChairManName = textBox13.Text;
            newItem.PromotorName = textBox14.Text;
            newItem.RecenzentName = textBox15.Text;
            newItem.Diplom = textBox16.Text;
            newItem.Question = textBox17.Text;
            newItem.Mark = textBox18.Text;
            newItem.MeanMarkWord = textBox19.Text;
            newItem.DiplomMarkWord = textBox20.Text;
            newItem.ExamMarkWord = textBox21.Text;
            newItem.MeanMark = textBox23.Text;
            newItem.DiplomMark = textBox24.Text;
            newItem.ExamMark = textBox25.Text;
            newItem.ResultWord = textBox22.Text;
            newItem.Result = textBox26.Text;

            dataList.Add(newItem);
            XmlSerializer serializer = new XmlSerializer(typeof(Protokol));
            using (TextWriter writer = new StreamWriter("Protokol.xml"))
            {
                serializer.Serialize(writer, newItem);
            }
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Protokol));

            using (FileStream fileStream = new FileStream("Protokol.xml", FileMode.Open))
            {
                Protokol newItem = (Protokol)serializer.Deserialize(fileStream);

                textBox1.Text = newItem.NameSurname;
                textBox2.Text = newItem.Data;
                textBox3.Text = newItem.City;
                textBox4.Text = newItem.Nralbumu;
                textBox5.Text = newItem.DataExam;
                textBox6.Text = newItem.Title;
                textBox7.Text = newItem.Faculty;
                textBox8.Text = newItem.Field;
                textBox9.Text = newItem.Profile;
                textBox10.Text = newItem.Form;
                textBox11.Text = newItem.Level;
                textBox12.Text = newItem.DataOfStart;
                textBox13.Text = newItem.ChairManName;
                textBox14.Text = newItem.PromotorName;
                textBox15.Text = newItem.RecenzentName;
                textBox16.Text = newItem.Diplom;
                textBox17.Text = newItem.Question;
                textBox18.Text = newItem.Mark;
                textBox19.Text = newItem.MeanMarkWord;
                textBox20.Text = newItem.DiplomMarkWord;
                textBox21.Text = newItem.ExamMarkWord;
                textBox22.Text = newItem.ResultWord;
                textBox23.Text = newItem.MeanMark;
                textBox24.Text = newItem.DiplomMark;
                textBox25.Text = newItem.ExamMark;
                textBox26.Text = newItem.Result;
            }
        }
    }
}
