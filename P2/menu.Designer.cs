namespace P2
{
    partial class menu
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
            btn_clientes = new Button();
            btn_produto = new Button();
            btn_pedido = new Button();
            btn_usuario = new Button();
            label1 = new Label();
            btn_consultar = new Button();
            SuspendLayout();
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = SystemColors.ControlText;
            btn_clientes.Location = new Point(96, 104);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(169, 43);
            btn_clientes.TabIndex = 0;
            btn_clientes.Text = "CLIENTES";
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_produto
            // 
            btn_produto.BackColor = SystemColors.ControlText;
            btn_produto.Location = new Point(96, 153);
            btn_produto.Name = "btn_produto";
            btn_produto.Size = new Size(169, 43);
            btn_produto.TabIndex = 1;
            btn_produto.Text = "PRODUTOS";
            btn_produto.UseVisualStyleBackColor = false;
            btn_produto.Click += btn_produto_Click;
            // 
            // btn_pedido
            // 
            btn_pedido.BackColor = SystemColors.ControlText;
            btn_pedido.Location = new Point(96, 202);
            btn_pedido.Name = "btn_pedido";
            btn_pedido.Size = new Size(169, 43);
            btn_pedido.TabIndex = 2;
            btn_pedido.Text = "PEDIDOS";
            btn_pedido.UseVisualStyleBackColor = false;
            btn_pedido.Click += btn_pedido_Click;
            // 
            // btn_usuario
            // 
            btn_usuario.BackColor = SystemColors.ControlText;
            btn_usuario.Location = new Point(96, 251);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(169, 43);
            btn_usuario.TabIndex = 3;
            btn_usuario.Text = "USUARIOS";
            btn_usuario.UseVisualStyleBackColor = false;
            btn_usuario.Click += btn_usuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(134, 36);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 4;
            label1.Text = "MENU";
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ControlText;
            btn_consultar.Location = new Point(96, 300);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(169, 43);
            btn_consultar.TabIndex = 5;
            btn_consultar.Text = "CONSULTAR";
            btn_consultar.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(376, 450);
            Controls.Add(btn_consultar);
            Controls.Add(label1);
            Controls.Add(btn_usuario);
            Controls.Add(btn_pedido);
            Controls.Add(btn_produto);
            Controls.Add(btn_clientes);
            ForeColor = SystemColors.Control;
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clientes;
        private Button btn_produto;
        private Button btn_pedido;
        private Button btn_usuario;
        private Label label1;
        private Button btn_consultar;
    }
}