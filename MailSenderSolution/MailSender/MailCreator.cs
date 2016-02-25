using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class MailCreator : Form
    {
        public AttachmentCollection Attachments { get; set; }
        private SmtpClient client;
        private bool AttachmentStatus;
        private string file, userName;
        
        public MailCreator(SmtpClient client, string userName): 
            this()
        {

            this.client = client;
            this.userName = userName;
            textBox1.Text = userName;
        }

        public MailCreator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress(userName);
                MailAddress toAddress = new MailAddress(textBox2.Text);

                message = new MailMessage(fromAddress, toAddress);
                if (AttachmentStatus)
                {
                    message.Attachments.Add(new Attachment(file));
                }

                message.Subject = textBox3.Text;
                message.Body = textBox4.Text;
                this.client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            //Attachment button
            try{
            
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                file = openFileDialog1.FileName;
                }
            }catch(Exception ex){}
            
            AttachmentStatus = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
