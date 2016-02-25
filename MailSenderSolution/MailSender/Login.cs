using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class Login1 : Form
    {

        public SmtpClient Client { get; set; }
        private bool radioStatus;
        private String username;

        public Login1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioStatus == true)
                {
                    Client.Credentials = new NetworkCredential(userName.Text, password.Text);
                    Client.EnableSsl = checkBox1.Checked;
                    MailCreator mailCreator = new MailCreator(Client, username);
                    mailCreator.Show();
                }
                else
                {
                    MessageBox.Show("Check SMTP server");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }   

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //GMAIL
            Client = new SmtpClient("smtp.gmail.com", 587);
            radioStatus = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //HOTMAIL
            Client = new SmtpClient("smtp.live.com", 465);
            radioStatus = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //WP
            Client = new SmtpClient("smtp.wp.pl", 465);
            radioStatus = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //TLEN
            Client = new SmtpClient("poczta.o2.pl", 465);
            radioStatus = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //YAHOO
            Client = new SmtpClient("smtp.mail.yahoo.com", 465);
            radioStatus = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //ONET
            Client = new SmtpClient("smtp.poczta.onet.pl", 465);
            radioStatus = true;
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            username = userName.Text;
        }
    }
}
