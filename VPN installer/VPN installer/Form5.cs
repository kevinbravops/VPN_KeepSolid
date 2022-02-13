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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            {
                string information = "Destination location:\n\t";
                information += Data.dir1 + "\n\n" + "Start Menu Folder:" + "\n\t" + Data.dir2 + "\n\n";
                richTextBox1.Text = information;
                if (Data.checkbox) richTextBox1.Text = information += "Additional tasks: \n\t Additional shortcuts: \n\t\t Create a desktop shortcut";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 FourthForm = new Form4();
            FourthForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = "Setup is not complete.If you exit now, the programm will be not installed.\n\n You may run setup at another time to complete the installiation. \n\n Exit setup?";
            string header = "Exit Setup";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, header, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 SixthForm = new Form6();
            SixthForm.Show();
            this.Close();
        }
    }
}
