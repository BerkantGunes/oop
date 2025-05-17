using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // texbox ın içerisine yazılan renge göre form un arka plan rengini değiştir. üç renk yeterli, mavi, yeşil, kırmızı



            if (textBox1.Text=="mavi")
            {
                this.BackColor = Color.Blue;
            }
            if (textBox1.Text == "yeşil")
            {
                this.BackColor = Color.Green;
            }
            if (textBox1.Text == "kırmızı")
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
