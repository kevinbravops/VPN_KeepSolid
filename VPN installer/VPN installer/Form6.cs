using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace vpn.exe
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        void ProgressBar()
        {
            double count = 0;
            progressBar1.Maximum = 1000;
            while (progressBar1.Value < 1000)
            {
                count += 0.003;
                if (Math.Floor(count) % 5 == 0)
                {
                    progressBar1.Value += 1;
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
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

        private void Form6_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            ProgressBar();
            button1.Enabled = true;
            label3.Text = "VPN has been installed, click Next to finish the setup";
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 SeventhForm = new Form7();
            SeventhForm.Show();
            this.Close();
        }
    }
}
