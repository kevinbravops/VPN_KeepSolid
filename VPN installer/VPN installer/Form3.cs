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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                this.textBox1.Text = openFileDlg.SelectedPath + @" VPN Unlimited";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 SecondForm = new Form2();
            SecondForm.Show();
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.dir2 = textBox1.Text + @"\VPN Unlimited";
            Form4 FourthForm = new Form4();
            FourthForm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
