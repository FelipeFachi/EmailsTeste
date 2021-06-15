using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.Threading;
using System.Data.SqlClient;
using System.Net;

namespace Envio_de_Emails
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ThreadStart start = new ThreadStart(VerificarEmailPendente);
            Thread thread = new Thread(start);

            thread.Start();
            
        }

        protected override void OnStop()
        {
        }

        public void VerificarEmailPendente()
        {
            while (true)
            {
                Thread.Sleep(5000);

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BancoParaTeste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("Select * from Emails where status 'n' ", conn);
                
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    EnviarEmail(
                    reader["EmailOrigem"].ToString(),
                    reader["EmailDestino"].ToString(),
                    reader["NomeOrigem"].ToString(),
                    reader["NomeDestino"].ToString(),
                    reader["Assunto"].ToString(),
                    reader["Mensagem"].ToString());


                    AtualizarEmail(Convert.ToInt32(reader["id"].ToString()));

                }

                reader.Close();
                conn.Close();
            }

        }

        private void EnviarEmail(string EmailOrigem, string EmailDestino, string NomeOrigem, string NomeDestino , string Assunto , string Mensagem)
        {
            MailAddress Rementente = new MailAddress(EmailOrigem, NomeOrigem);
            MailAddress Destinatario = new MailAddress(EmailDestino, NomeDestino);

            MailMessage Msg = new MailMessage(Rementente, Destinatario);
            Msg.Subject = Assunto;
            Msg.Body = Mensagem;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential(Rementente.Address, "felipeluiz05");

            smtp.Send(Msg);

        }
        private void AtualizarEmail(int id)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BancoParaTeste; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand CmdUpdate = new SqlCommand("update Emails set status = 'S' where id=@ID", conn);

            CmdUpdate.Parameters.Add(new SqlParameter("@ID", id));

            conn.Open();
            CmdUpdate.ExecuteNonQuery();
            conn.Close();
        }
    }
}
