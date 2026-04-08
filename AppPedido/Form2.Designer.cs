namespace AppPedido
{
    partial class Form2
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
            cbClientes = new ComboBox();
            cbItens = new ComboBox();
            numQuantidade = new NumericUpDown();
            btnSalvar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(75, 66);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(121, 23);
            cbClientes.TabIndex = 0;
            // 
            // cbItens
            // 
            cbItens.FormattingEnabled = true;
            cbItens.Location = new Point(75, 114);
            cbItens.Name = "cbItens";
            cbItens.Size = new Size(121, 23);
            cbItens.TabIndex = 0;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(234, 114);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(63, 23);
            numQuantidade.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(75, 172);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(222, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 450);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(numQuantidade);
            Controls.Add(cbItens);
            Controls.Add(cbClientes);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbClientes;
        private ComboBox cbItens;
        private NumericUpDown numQuantidade;
        private Button btnSalvar;
        private Button button1;
    }
}