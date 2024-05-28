using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T6_69451_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();    
            form.ShowDialog();  
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBooks.EBook ebook = new AddBooks.EBook(titletxt.Text, authortxt.Text, categorytxt.Text, "E-book", 
                formattxt.Text, Convert.ToInt32(filesizetxt.Text));
            Library.AddBook(ebook);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            if (item == "Paper Book")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            else if (item == "E-Book")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
            else if (item == "Audio-Book")
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks.PaperBook pbook = new AddBooks.PaperBook(titletxt.Text, authortxt.Text, categorytxt.Text, "Paper book",
                isbntxt.Text, Convert.ToInt32(pagestxt.Text));
            Library.AddBook(pbook);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBooks.AudioBook abook = new AddBooks.AudioBook(titletxt.Text, authortxt.Text, categorytxt.Text, "Audio-book",
                narratortxt.Text, Convert.ToInt32(durationtxt.Text));
            Library.AddBook(abook);
        }
    }
}
