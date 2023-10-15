using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcsf20a039
{
    public partial class Form1 : Form
    {
        private ArrayList namesList = new ArrayList(); // ArrayList to store first names and last names
        private List<string> subjectsList = new List<string>(); // List to store subjects

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            bool prerequisiteClear = checkBox1.Checked;

            firstName = Regex.Replace(firstName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
            lastName = Regex.Replace(lastName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);

            namesList.Add(firstName + " " + lastName);

            string result = firstName + " " + lastName +
                            " is successfully enrolled in the following subjects:" + Environment.NewLine;

            string[] subjects = textBox3.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            subjectsList.AddRange(subjects);

            foreach (string subject in subjects)
            {
                result += subject + Environment.NewLine;
            }

            result += "Prerequisite Clear: " + prerequisiteClear;
            label3.Text = result;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
