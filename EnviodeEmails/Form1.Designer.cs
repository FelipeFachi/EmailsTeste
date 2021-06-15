
namespace Envio_de_Emails
{
    partial class txt_Para
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.text_De = new System.Windows.Forms.TextBox();
            this.Label_De = new System.Windows.Forms.Label();
            this.Label_Para = new System.Windows.Forms.Label();
            this.text_Para = new System.Windows.Forms.TextBox();
            this.label_Remetente = new System.Windows.Forms.Label();
            this.label_Destinatario = new System.Windows.Forms.Label();
            this.Txt_Remetente = new System.Windows.Forms.TextBox();
            this.Txt_Destinatario = new System.Windows.Forms.TextBox();
            this.label_assunto = new System.Windows.Forms.Label();
            this.label_mensagem = new System.Windows.Forms.Label();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.txt_Mensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(425, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar Email";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_De
            // 
            this.text_De.Location = new System.Drawing.Point(42, 34);
            this.text_De.Name = "text_De";
            this.text_De.Size = new System.Drawing.Size(255, 20);
            this.text_De.TabIndex = 1;
            this.text_De.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label_De
            // 
            this.Label_De.AutoSize = true;
            this.Label_De.Location = new System.Drawing.Point(12, 34);
            this.Label_De.Name = "Label_De";
            this.Label_De.Size = new System.Drawing.Size(24, 13);
            this.Label_De.TabIndex = 2;
            this.Label_De.Text = "De:";
            this.Label_De.Click += new System.EventHandler(this.txtDe_Click);
            // 
            // Label_Para
            // 
            this.Label_Para.AutoSize = true;
            this.Label_Para.Location = new System.Drawing.Point(12, 73);
            this.Label_Para.Name = "Label_Para";
            this.Label_Para.Size = new System.Drawing.Size(32, 13);
            this.Label_Para.TabIndex = 3;
            this.Label_Para.Text = "Para:";
            // 
            // text_Para
            // 
            this.text_Para.Location = new System.Drawing.Point(42, 70);
            this.text_Para.Name = "text_Para";
            this.text_Para.Size = new System.Drawing.Size(255, 20);
            this.text_Para.TabIndex = 4;
            // 
            // label_Remetente
            // 
            this.label_Remetente.AutoSize = true;
            this.label_Remetente.Location = new System.Drawing.Point(313, 34);
            this.label_Remetente.Name = "label_Remetente";
            this.label_Remetente.Size = new System.Drawing.Size(62, 13);
            this.label_Remetente.TabIndex = 5;
            this.label_Remetente.Text = "Remetente:";
            this.label_Remetente.Click += new System.EventHandler(this.Txt_Remetente_Click);
            // 
            // label_Destinatario
            // 
            this.label_Destinatario.AutoSize = true;
            this.label_Destinatario.Location = new System.Drawing.Point(313, 70);
            this.label_Destinatario.Name = "label_Destinatario";
            this.label_Destinatario.Size = new System.Drawing.Size(69, 13);
            this.label_Destinatario.TabIndex = 6;
            this.label_Destinatario.Text = "Destinatario :";
            this.label_Destinatario.Click += new System.EventHandler(this.Txt_Destinatario_Click);
            // 
            // Txt_Remetente
            // 
            this.Txt_Remetente.Location = new System.Drawing.Point(388, 34);
            this.Txt_Remetente.Name = "Txt_Remetente";
            this.Txt_Remetente.Size = new System.Drawing.Size(234, 20);
            this.Txt_Remetente.TabIndex = 7;
            // 
            // Txt_Destinatario
            // 
            this.Txt_Destinatario.Location = new System.Drawing.Point(388, 67);
            this.Txt_Destinatario.Name = "Txt_Destinatario";
            this.Txt_Destinatario.Size = new System.Drawing.Size(234, 20);
            this.Txt_Destinatario.TabIndex = 8;
            // 
            // label_assunto
            // 
            this.label_assunto.AutoSize = true;
            this.label_assunto.Location = new System.Drawing.Point(13, 133);
            this.label_assunto.Name = "label_assunto";
            this.label_assunto.Size = new System.Drawing.Size(48, 13);
            this.label_assunto.TabIndex = 9;
            this.label_assunto.Text = "Assunto:";
            // 
            // label_mensagem
            // 
            this.label_mensagem.AutoSize = true;
            this.label_mensagem.Location = new System.Drawing.Point(13, 194);
            this.label_mensagem.Name = "label_mensagem";
            this.label_mensagem.Size = new System.Drawing.Size(68, 13);
            this.label_mensagem.TabIndex = 10;
            this.label_mensagem.Text = "Mensagem : ";
            // 
            // txt_assunto
            // 
            this.txt_assunto.Location = new System.Drawing.Point(67, 130);
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(259, 20);
            this.txt_assunto.TabIndex = 11;
            // 
            // txt_Mensagem
            // 
            this.txt_Mensagem.Location = new System.Drawing.Point(87, 197);
            this.txt_Mensagem.Multiline = true;
            this.txt_Mensagem.Name = "txt_Mensagem";
            this.txt_Mensagem.Size = new System.Drawing.Size(410, 116);
            this.txt_Mensagem.TabIndex = 12;
            // 
            // txt_Para
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 370);
            this.Controls.Add(this.txt_Mensagem);
            this.Controls.Add(this.txt_assunto);
            this.Controls.Add(this.label_mensagem);
            this.Controls.Add(this.label_assunto);
            this.Controls.Add(this.Txt_Destinatario);
            this.Controls.Add(this.Txt_Remetente);
            this.Controls.Add(this.label_Destinatario);
            this.Controls.Add(this.label_Remetente);
            this.Controls.Add(this.text_Para);
            this.Controls.Add(this.Label_Para);
            this.Controls.Add(this.Label_De);
            this.Controls.Add(this.text_De);
            this.Controls.Add(this.button1);
            this.Name = "txt_Para";
            this.Text = "EnviaEmails";
            this.Load += new System.EventHandler(this.EnviaEmails);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_De;
        private System.Windows.Forms.Label Label_De;
        private System.Windows.Forms.Label Label_Para;
        private System.Windows.Forms.TextBox text_Para;
        private System.Windows.Forms.Label label_Remetente;
        private System.Windows.Forms.Label label_Destinatario;
        private System.Windows.Forms.TextBox Txt_Remetente;
        private System.Windows.Forms.TextBox Txt_Destinatario;
        private System.Windows.Forms.Label label_assunto;
        private System.Windows.Forms.Label label_mensagem;
        private System.Windows.Forms.TextBox txt_assunto;
        private System.Windows.Forms.TextBox txt_Mensagem;
    }
}