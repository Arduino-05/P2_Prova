namespace P2
{
    partial class Clientes
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
            btn_cadastrar = new Button();
            label1 = new Label();
            text_nome = new TextBox();
            text_cpf = new TextBox();
            text_email = new TextBox();
            text_end = new TextBox();
            text_tele = new TextBox();
            text_zap = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.ControlText;
            btn_cadastrar.Location = new Point(88, 372);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(169, 43);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "CADASTRAR";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(99, 23);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 5;
            label1.Text = "Usuários";
            // 
            // text_nome
            // 
            text_nome.Location = new Point(62, 82);
            text_nome.Name = "text_nome";
            text_nome.Size = new Size(223, 23);
            text_nome.TabIndex = 6;
            // 
            // text_cpf
            // 
            text_cpf.Location = new Point(62, 128);
            text_cpf.Name = "text_cpf";
            text_cpf.Size = new Size(223, 23);
            text_cpf.TabIndex = 7;
            // 
            // text_email
            // 
            text_email.Location = new Point(62, 174);
            text_email.Name = "text_email";
            text_email.Size = new Size(223, 23);
            text_email.TabIndex = 8;
            // 
            // text_end
            // 
            text_end.Location = new Point(62, 220);
            text_end.Name = "text_end";
            text_end.Size = new Size(223, 23);
            text_end.TabIndex = 9;
            // 
            // text_tele
            // 
            text_tele.Location = new Point(62, 264);
            text_tele.Name = "text_tele";
            text_tele.Size = new Size(223, 23);
            text_tele.TabIndex = 10;
            // 
            // text_zap
            // 
            text_zap.Location = new Point(62, 310);
            text_zap.Name = "text_zap";
            text_zap.Size = new Size(223, 23);
            text_zap.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(65, 60);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(65, 110);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 13;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(65, 156);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(65, 202);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 15;
            label5.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(65, 246);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 16;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(65, 292);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 17;
            label7.Text = "WhatsApp";
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.ControlText;
            btn_voltar.Location = new Point(250, 12);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(104, 28);
            btn_voltar.TabIndex = 18;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(356, 450);
            Controls.Add(btn_voltar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(text_zap);
            Controls.Add(text_tele);
            Controls.Add(text_end);
            Controls.Add(text_email);
            Controls.Add(text_cpf);
            Controls.Add(text_nome);
            Controls.Add(label1);
            Controls.Add(btn_cadastrar);
            ForeColor = SystemColors.Control;
            Name = "Clientes";
            Text = "Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastrar;
        private Label label1;
        private TextBox text_nome;
        private TextBox text_cpf;
        private TextBox text_email;
        private TextBox text_end;
        private TextBox text_tele;
        private TextBox text_zap;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_voltar;
    }
}