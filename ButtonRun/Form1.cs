using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonRun
{
    public partial class Form1 : Form
    {
        private int id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id++;
            button1.Text = id.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "0";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            var x = Size.Width / 2;
            var y = Size.Height / 2;

            button1.Location = new Point(random.Next(x), random.Next(y));
        }
    }


    
}


