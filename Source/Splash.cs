﻿using System;
using System.Windows.Forms;

namespace _345_Launcher
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            if (Properties.Settings.Default.langtr == false)
            {
                metroLabel1.Text = "Loading...";
                //English
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            guna2CircleProgressBar1.Value += 1;
            if (guna2CircleProgressBar1.Value == 30)
            {

                if (Properties.Settings.Default.langtr == false)
                {

                    //English
                    metroLabel1.Text = "Connecting to server...";
                }
                else
                {
                    metroLabel1.Text = "Sunucuya bağlanılıyor...";
                    //Turkish

                }
            }
            if (guna2CircleProgressBar1.Value == 75)
            {
                if (Properties.Settings.Default.langtr == false)
                {
                    metroLabel1.Text = "Checking files...";
                    //English
                }
                else
                {
                    metroLabel1.Text = "Dosyalar Doğrulanıyor...";
                    //Turkish
                }

            }
            if (guna2CircleProgressBar1.Value >= 100)
            {
                if (Properties.Settings.Default.Remember == true)
                {

                    // If remember me checked auto logins
                    timer1.Stop();
                    MainForm main = new MainForm();
                    main.LabelText = Properties.Settings.Default.UserName;
                    main.Show();
                    this.Hide();

                }
                else
                {
                    
                    timer1.Stop();
                    login log = new login();
                    log.Show();
                    this.Hide();
                }

            }
        }
    }
}
