using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpn.exe
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Data.checkbox = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

                this.Close();
                Form5 FifthForm = new Form5();
                FifthForm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = "Setup is not complete.If you exit now, the programm will be not installed.\n\n You may run setup again at another time to complete the installiation. \n\n Exit setup?";
            string header = "Exit Setup";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, header, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
