namespace P2
{
    partial class Produtos
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
            text_nome = new TextBox();
            text_preco = new TextBox();
            text_descricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_salvar = new Button();
            data_produto = new DataGridView();
            btn_deletar = new Button();
            btn_editar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)data_produto).BeginInit();
            SuspendLayout();
            // 
            // text_nome
            // 
            text_nome.Location = new Point(121, 86);
            text_nome.Name = "text_nome";
            text_nome.Size = new Size(192, 23);
            text_nome.TabIndex = 0;
            // 
            // text_preco
            // 
            text_preco.Location = new Point(121, 128);
            text_preco.Name = "text_preco";
            text_preco.Size = new Size(192, 23);
            text_preco.TabIndex = 1;
            // 
            // text_descricao
            // 
            text_descricao.Location = new Point(121, 178);
            text_descricao.Name = "text_descricao";
            text_descricao.Size = new Size(192, 23);
            text_descricao.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 22);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 68);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 112);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Descrição";
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(179, 216);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 7;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // data_produto
            // 
            data_produto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_produto.Location = new Point(432, 102);
            data_produto.Name = "data_produto";
            data_produto.RowTemplate.Height = 25;
            data_produto.Size = new Size(290, 150);
            data_produto.TabIndex = 8;
            data_produto.CellClick += data_produto_CellClick;
            // 
            // btn_deletar
            // 
            btn_deletar.Location = new Point(647, 73);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(75, 23);
            btn_deletar.TabIndex = 9;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(566, 73);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 10;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(btn_editar);
            Controls.Add(btn_deletar);
            Controls.Add(data_produto);
            Controls.Add(btn_salvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_descricao);
            Controls.Add(text_preco);
            Controls.Add(text_nome);
            Name = "Produtos";
            Text = "Produtos";
            Load += Produtos_Load;
            ((System.ComponentModel.ISupportInitialize)data_produto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_nome;
        private TextBox text_preco;
        private TextBox text_descricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_salvar;
        private DataGridView data_produto;
        private Button btn_deletar;
        private Button btn_editar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}