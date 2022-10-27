namespace VenexaExchangeForm
{
    partial class Cadastro
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
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbLocalidade = new System.Windows.Forms.TextBox();
            this.lbLocalidade = new System.Windows.Forms.Label();
            this.tbAssociacao = new System.Windows.Forms.TextBox();
            this.lbAssociacao = new System.Windows.Forms.Label();
            this.gbPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.lbCp = new System.Windows.Forms.Label();
            this.btProx = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(75, 114);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(60, 21);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome: ";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(146, 116);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(140, 23);
            this.tbNome.TabIndex = 1;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // tbLocalidade
            // 
            this.tbLocalidade.Location = new System.Drawing.Point(146, 149);
            this.tbLocalidade.Name = "tbLocalidade";
            this.tbLocalidade.Size = new System.Drawing.Size(140, 23);
            this.tbLocalidade.TabIndex = 3;
            this.tbLocalidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbLocalidade
            // 
            this.lbLocalidade.AutoSize = true;
            this.lbLocalidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocalidade.Location = new System.Drawing.Point(40, 149);
            this.lbLocalidade.Name = "lbLocalidade";
            this.lbLocalidade.Size = new System.Drawing.Size(95, 21);
            this.lbLocalidade.TabIndex = 2;
            this.lbLocalidade.Text = "Localidade:  ";
            // 
            // tbAssociacao
            // 
            this.tbAssociacao.Location = new System.Drawing.Point(146, 184);
            this.tbAssociacao.Name = "tbAssociacao";
            this.tbAssociacao.Size = new System.Drawing.Size(140, 23);
            this.tbAssociacao.TabIndex = 5;
            // 
            // lbAssociacao
            // 
            this.lbAssociacao.AutoSize = true;
            this.lbAssociacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAssociacao.Location = new System.Drawing.Point(42, 182);
            this.lbAssociacao.Name = "lbAssociacao";
            this.lbAssociacao.Size = new System.Drawing.Size(93, 21);
            this.lbAssociacao.TabIndex = 4;
            this.lbAssociacao.Text = "Associação: ";
            // 
            // gbPessoa
            // 
            this.gbPessoa.Controls.Add(this.rbJuridica);
            this.gbPessoa.Controls.Add(this.rbFisica);
            this.gbPessoa.Location = new System.Drawing.Point(378, 114);
            this.gbPessoa.Name = "gbPessoa";
            this.gbPessoa.Size = new System.Drawing.Size(193, 88);
            this.gbPessoa.TabIndex = 6;
            this.gbPessoa.TabStop = false;
            this.gbPessoa.Text = "Tipo de pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(33, 53);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(104, 19);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Pessoa Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Location = new System.Drawing.Point(33, 28);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(93, 19);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // tbCp
            // 
            this.tbCp.Location = new System.Drawing.Point(146, 222);
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(140, 23);
            this.tbCp.TabIndex = 8;
            this.tbCp.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbCp
            // 
            this.lbCp.AutoSize = true;
            this.lbCp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCp.Location = new System.Drawing.Point(49, 224);
            this.lbCp.Name = "lbCp";
            this.lbCp.Size = new System.Drawing.Size(86, 21);
            this.lbCp.TabIndex = 7;
            this.lbCp.Text = "CPF/CNPJ: ";
            this.lbCp.Click += new System.EventHandler(this.label1_Click);
            // 
            // btProx
            // 
            this.btProx.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btProx.Location = new System.Drawing.Point(49, 303);
            this.btProx.Name = "btProx";
            this.btProx.Size = new System.Drawing.Size(202, 84);
            this.btProx.TabIndex = 9;
            this.btProx.Text = "Próximo";
            this.btProx.UseVisualStyleBackColor = true;
            this.btProx.Click += new System.EventHandler(this.btProx_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancel.Location = new System.Drawing.Point(378, 303);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(202, 84);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastre-se na Veneza Exchange";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btProx);
            this.Controls.Add(this.tbCp);
            this.Controls.Add(this.lbCp);
            this.Controls.Add(this.gbPessoa);
            this.Controls.Add(this.tbAssociacao);
            this.Controls.Add(this.lbAssociacao);
            this.Controls.Add(this.tbLocalidade);
            this.Controls.Add(this.lbLocalidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.gbPessoa.ResumeLayout(false);
            this.gbPessoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNome;
        private TextBox tbNome;
        private TextBox tbLocalidade;
        private Label lbLocalidade;
        private TextBox tbAssociacao;
        private Label lbAssociacao;
        private GroupBox gbPessoa;
        private RadioButton rbJuridica;
        private RadioButton rbFisica;
        private TextBox tbCp;
        private Label lbCp;
        private Button btProx;
        private Button btCancel;
        private Label label1;
    }
}