namespace P2
{
    partial class pedidos
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
            components = new System.ComponentModel.Container();
            text_cpf = new TextBox();
            text_nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            select_produtos = new ComboBox();
            label4 = new Label();
            data_itens = new DataGridView();
            btn_add = new Button();
            btn_finalizar = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label_total = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_itens).BeginInit();
            SuspendLayout();
            // 
            // text_cpf
            // 
            text_cpf.Location = new Point(132, 86);
            text_cpf.Name = "text_cpf";
            text_cpf.Size = new Size(162, 23);
            text_cpf.TabIndex = 0;
            // 
            // text_nome
            // 
            text_nome.Location = new Point(132, 128);
            text_nome.Name = "text_nome";
            text_nome.Size = new Size(162, 23);
            text_nome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 68);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 112);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // select_produtos
            // 
            select_produtos.FormattingEnabled = true;
            select_produtos.Location = new Point(396, 83);
            select_produtos.Name = "select_produtos";
            select_produtos.Size = new Size(142, 23);
            select_produtos.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 65);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "Produto";
            // 
            // data_itens
            // 
            data_itens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_itens.Location = new Point(396, 150);
            data_itens.Name = "data_itens";
            data_itens.RowTemplate.Height = 25;
            data_itens.Size = new Size(304, 150);
            data_itens.TabIndex = 6;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(625, 121);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 7;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Location = new Point(625, 318);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(75, 23);
            btn_finalizar.TabIndex = 8;
            btn_finalizar.Text = "Finalizar";
            btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(557, 68);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 10;
            label3.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 326);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 11;
            label5.Text = "Total:";
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Location = new Point(440, 326);
            label_total.Name = "label_total";
            label_total.Size = new Size(38, 15);
            label_total.TabIndex = 12;
            label_total.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 24);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "Pedidos";
            // 
            // pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label_total);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btn_finalizar);
            Controls.Add(btn_add);
            Controls.Add(data_itens);
            Controls.Add(label4);
            Controls.Add(select_produtos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_nome);
            Controls.Add(text_cpf);
            Name = "pedidos";
            Text = "pedidos";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_itens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_cpf;
        private TextBox text_nome;
        private Label label1;
        private Label label2;
        private BindingSource bindingSource1;
        private ComboBox select_produtos;
        private Label label4;
        private DataGridView data_itens;
        private Button btn_add;
        private Button btn_finalizar;
        private TextBox textBox1;
        private Label label3;
        private Label label5;
        private Label label_total;
        private Label label6;
    }
}