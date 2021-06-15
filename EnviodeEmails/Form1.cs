using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Envio_de_Emails
{
    public partial class txt_Para : Form
    {
        public txt_Para()
        {
            InitializeComponent();
        }

        private void EnviaEmails(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDe_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress Rementente = new MailAddress(text_De.Text, Txt_Remetente.Text);
            MailAddress Destinatario = new MailAddress(text_Para.Text, Txt_Destinatario.Text);

            MailMessage Msg = new MailMessage(Rementente, Destinatario);
            Msg.Subject = txt_assunto.Text;
            Msg.Body = txt_Mensagem.Text;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(Rementente.Address, "!Ca05121991");

            smtp.Send(Msg);


        }

        private void Txt_Remetente_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Destinatario_Click(object sender, EventArgs e)
        {

        }
    }
}
