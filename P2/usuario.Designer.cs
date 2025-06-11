namespace P2
{
    partial class usuario
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
            data_usuarios = new DataGridView();
            btn_deletar = new Button();
            btn_editar = new Button();
            btn_salvar = new Button();
            text_email = new TextBox();
            label1 = new Label();
            text_senha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)data_usuarios).BeginInit();
            SuspendLayout();
            // 
            // data_usuarios
            // 
            data_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_usuarios.Location = new Point(33, 256);
            data_usuarios.Name = "data_usuarios";
            data_usuarios.RowTemplate.Height = 25;
            data_usuarios.Size = new Size(324, 150);
            data_usuarios.TabIndex = 0;
            // 
            // btn_deletar
            // 
            btn_deletar.Location = new Point(282, 227);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(75, 23);
            btn_deletar.TabIndex = 1;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(201, 227);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 2;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(151, 174);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 3;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            // 
            // text_email
            // 
            text_email.Location = new Point(103, 90);
            text_email.Name = "text_email";
            text_email.Size = new Size(161, 23);
            text_email.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "USUARIOS";
            // 
            // text_senha
            // 
            text_senha.Location = new Point(103, 132);
            text_senha.Name = "text_senha";
            text_senha.Size = new Size(161, 23);
            text_senha.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 72);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 116);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(text_senha);
            Controls.Add(label1);
            Controls.Add(text_email);
            Controls.Add(btn_salvar);
            Controls.Add(btn_editar);
            Controls.Add(btn_deletar);
            Controls.Add(data_usuarios);
            Name = "usuario";
            Text = "usuario";
            ((System.ComponentModel.ISupportInitialize)data_usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_usuarios;
        private Button btn_deletar;
        private Button btn_editar;
        private Button btn_salvar;
        private TextBox text_email;
        private Label label1;
        private TextBox text_senha;
        private Label label2;
        private Label label3;
    }
}