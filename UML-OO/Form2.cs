using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UML_OO
{
    public partial class Form2 : Form
    {
        private String myName;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myName = textBox1.Text;
            this.Dispose();
        }

        public String Get_myName()
        {
            return myName;
        }

        public void Set_List(String name)
        {
            textBox1.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
