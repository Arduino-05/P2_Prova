namespace P2
{
    partial class consultar_pedidos
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
            text_cpf = new TextBox();
            label1 = new Label();
            label2 = new Label();
            list_pedidos = new ListView();
            list_itens = new ListView();
            label_total = new Label();
            label3 = new Label();
            btn_buscar = new Button();
            SuspendLayout();
            // 
            // text_cpf
            // 
            text_cpf.Location = new Point(33, 91);
            text_cpf.Name = "text_cpf";
            text_cpf.Size = new Size(209, 23);
            text_cpf.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 73);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 19);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "CONSULTAR PEDIDOS";
            // 
            // list_pedidos
            // 
            list_pedidos.Location = new Point(33, 194);
            list_pedidos.Name = "list_pedidos";
            list_pedidos.Size = new Size(245, 119);
            list_pedidos.TabIndex = 3;
            list_pedidos.UseCompatibleStateImageBehavior = false;
            list_pedidos.SelectedIndexChanged += list_pedidos_SelectedIndexChanged;
            // 
            // list_itens
            // 
            list_itens.Location = new Point(376, 194);
            list_itens.Name = "list_itens";
            list_itens.Size = new Size(267, 119);
            list_itens.TabIndex = 4;
            list_itens.UseCompatibleStateImageBehavior = false;
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Location = new Point(378, 172);
            label_total.Name = "label_total";
            label_total.Size = new Size(37, 15);
            label_total.TabIndex = 5;
            label_total.Text = "ITENS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 172);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Pedidos";
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = SystemColors.ActiveCaptionText;
            btn_buscar.ForeColor = SystemColors.ControlLight;
            btn_buscar.Location = new Point(104, 120);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 7;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // consultar_pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(688, 450);
            Controls.Add(btn_buscar);
            Controls.Add(label3);
            Controls.Add(label_total);
            Controls.Add(list_itens);
            Controls.Add(list_pedidos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_cpf);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "consultar_pedidos";
            Text = "consultar_pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_cpf;
        private Label label1;
        private Label label2;
        private ListView list_pedidos;
        private ListView list_itens;
        private Label label_total;
        private Label label3;
        private Button btn_buscar;
    }
}