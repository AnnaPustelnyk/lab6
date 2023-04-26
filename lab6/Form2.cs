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
using static System.Windows.Forms.DataFormats;

namespace lab6
{
    public partial class Form2 : Form
    {
        private BindingList<Blank> dataList;
        bool hasNullItem = false;
        public Form2(BindingList<Blank> dataList)
        {
            InitializeComponent();
            this.dataList = dataList;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //string[] row1 = new string[] { "column2 value", "column6 value" };
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.Rows[0].HeaderCell.Value = "Student";
            dataGridView1.Rows[1].HeaderCell.Value = "Student";
            dataGridView1.Rows[2].HeaderCell.Value = "Student";
            dataGridView1.Rows[3].HeaderCell.Value = "Student";

            dataGridView1.RowHeadersWidth = 120;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Karta newItem = new Karta();

            newItem.Faculty = textBox2.Text;
            newItem.Profile = textBox4.Text;
            newItem.StudyForm = textBox5.Text;
            newItem.Field = textBox3.Text;
            newItem.Level = textBox6.Text;
            newItem.Name = textBox7.Text;
            newItem.VersionEng = textBox8.Text;
            newItem.Data = textBox9.Text;
            newItem.Range_ = textBox10.Text;
            newItem.Deadline = textBox11.Text;
            newItem.Promotor = textBox12.Text;
            newItem.PromoterUnit = textBox13.Text;

            newItem.Students = new Student[dataGridView1.Rows.Count];

            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    newItem.Students[i].Name_Surname = row.Cells[0].Value.ToString();
                    if (row.Cells[1].Value == null)
                    {
                        hasNullItem = true;
                    }
                    else
                    {
                        hasNullItem = false;
                        newItem.Students[i].Nr_albumu = row.Cells[1].Value.ToString();
                        i++;
                    }
                }
                if (hasNullItem)
                {
                    MessageBox.Show("Please fill in all the items in the row.");
                    return;
                }
            }
            dataList.Add(newItem);

            XmlSerializer serializer = new XmlSerializer(typeof(Karta));
            using (TextWriter writer = new StreamWriter("data.xml"))
            {
                serializer.Serialize(writer, newItem);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Karta));

            using (FileStream fileStream = new FileStream("data.xml", FileMode.Open))
            {
                Karta newItem = (Karta)serializer.Deserialize(fileStream);

                textBox2.Text = newItem.Faculty;
                textBox3.Text = newItem.Field;
                textBox4.Text = newItem.Profile;
                textBox5.Text = newItem.StudyForm;
                textBox6.Text = newItem.Level;
                textBox7.Text = newItem.Name;
                textBox8.Text = newItem.VersionEng;
                textBox9.Text = newItem.Data;
                textBox10.Text = newItem.Range_;
                textBox11.Text = newItem.Deadline;
                textBox12.Text = newItem.Promotor;
                textBox13.Text = newItem.PromoterUnit;

                dataGridView1.Rows.Clear();

                foreach (Student student in newItem.Students)
                {
                    int index = dataGridView1.Rows.Add(student.Name_Surname, student.Nr_albumu);
                    dataGridView1.Rows[index].HeaderCell.Value = "Student";
                }
            }
        }
    }
}
