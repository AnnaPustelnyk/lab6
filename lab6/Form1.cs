using System.ComponentModel;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public BindingList<Blank> dataList = new BindingList<Blank>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form2 form2 = new Form2(dataList);
                form2.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Form form3 = new Form3(dataList, 1);
                form3.Show(this);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form3 form3 = new Form3(dataList, 2);
                form3.label1.Text = "Opinia recenzenta \r\no pracy dyplomowej in¿ynierskiej\r\n";
                form3.label2.Text = "INFORMACJA O RECENZENCIE";
                form3.label3.Text = "Recenzent";
                form3.label20.Visible = false;
                form3.textBox15.Visible = false;
                form3.Show(this);
            }
            else
            {
                Form4 form4 = new Form4(dataList);
                form4.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}