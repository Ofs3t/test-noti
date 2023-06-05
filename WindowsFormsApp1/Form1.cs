using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String filePath = string.Format("{0}TextFile1.txt", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"")));

        int prevRand = 0;

        public Form1()
        {
            InitializeComponent();
            label3.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var lines = File.ReadAllLines(filePath);
            var r = new Random();

            var randomLineNumber = r.Next(0, lines.Length);
            if (randomLineNumber == prevRand)
            {
                label4.Text = "the prev rand is " + prevRand + " and the rand line is " + randomLineNumber;
                // if last line 
                if(prevRand+1 < lines.Length)
                    randomLineNumber++;
            }
            prevRand = randomLineNumber;
            var line = lines[randomLineNumber];



            textBox2.Text = Convert.ToString(randomLineNumber);
            textBox1.Text = line;
        }
    }
}
