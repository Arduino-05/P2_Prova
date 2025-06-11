namespace P2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            text_login = new TextBox();
            text_senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // text_login
            // 
            text_login.Location = new Point(57, 117);
            text_login.Name = "text_login";
            text_login.Size = new Size(266, 23);
            text_login.TabIndex = 0;
            // 
            // text_senha
            // 
            text_senha.Location = new Point(57, 206);
            text_senha.Name = "text_senha";
            text_senha.Size = new Size(266, 23);
            text_senha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 99);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 188);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "SENHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(109, 25);
            label3.Name = "label3";
            label3.Size = new Size(169, 37);
            label3.TabIndex = 4;
            label3.Text = "BEM VINDO";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaptionText;
            btn_login.ForeColor = SystemColors.Control;
            btn_login.Location = new Point(153, 285);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "ENTRAR";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(380, 450);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_senha);
            Controls.Add(text_login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_login;
        private TextBox text_senha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_login;
    }
}
