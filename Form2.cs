using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace file_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        FileStream myfile;
        StreamReader sr;
        StreamWriter sw;
        string filename;

        private void button4_Click(object sender, EventArgs e)
        {
            bookname.Text = bookid.Text = author.Text = price.Text = null;
            myfile.Seek(0, SeekOrigin.Begin);
            myfile.Flush();
            sw.Flush();

            string record;
            string[] fields;
            int steps = 0;

            while ((record = sr.ReadLine()) != null)
            {
                fields = record.Split(",");
                int BookName = int.Parse(bookname.Text);
                if (BookName == int.Parse(fields[0]))
                {
                    myfile.Seek(steps, SeekOrigin.Begin);
                    sw.Write("*");
                    sw.Flush();

                    MessageBox.Show("Book Deleted!!");
                }
                steps += record.Length + 2;


            }
        }

            private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.Cancel) { return; }
            filename = fd.FileName;
            myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(myfile);
            sr = new StreamReader(myfile);
            MessageBox.Show("File is opened");
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = true;

        }

        private void search_Click(object sender, EventArgs e)
        {
            int book_id = int.Parse(bookid.Text);            //id the user enter
            string record;
            string[] fields;
            while ((record = sr.ReadLine()) != null)
            {
                fields = record.Split(',');
                if (book_id == int.Parse(fields[0]))
                {
                    bookname.Text = fields[1];
                    author.Text = fields[2];
                    price.Text = fields[3];
                    MessageBox.Show("found");
                    return;
                }

            }

            MessageBox.Show("Not found");
        }

        private void add_Click(object sender, EventArgs e)
        {
            string record = bookid.Text + "," + bookname.Text + "," + author.Text + "," + price.Text;
            sw.WriteLine(record);
            sw.Flush();
            MessageBox.Show("Record saved");
        }

        private void bookid_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Book_Name_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //myfile.Seek(0, SeekOrigin.Begin);

            //string allRecords = "";

            //using (StreamReader sr = new StreamReader()) ;
            //{
            //    string record;
            //    while ((record = sr.ReadLine()) != null)
            //    {
            //        allRecords += record + "\n";
            //    }
            //}


            //MessageBox.Show(allRecords, "All Books", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
