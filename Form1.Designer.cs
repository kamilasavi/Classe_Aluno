namespace Classe_Aluno
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDtNasc = new System.Windows.Forms.Label();
            this.lbNota1 = new System.Windows.Forms.Label();
            this.txbNota1 = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbClasse = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbNota2 = new System.Windows.Forms.Label();
            this.txbNota2 = new System.Windows.Forms.TextBox();
            this.lbNota3 = new System.Windows.Forms.Label();
            this.txbNota3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClasseAluno = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(43, 315);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 44);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 274);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 23);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lbDtNasc
            // 
            this.lbDtNasc.AutoSize = true;
            this.lbDtNasc.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDtNasc.Location = new System.Drawing.Point(49, 274);
            this.lbDtNasc.Name = "lbDtNasc";
            this.lbDtNasc.Size = new System.Drawing.Size(155, 21);
            this.lbDtNasc.TabIndex = 21;
            this.lbDtNasc.Text = "Data Nascimento:";
            // 
            // lbNota1
            // 
            this.lbNota1.AutoSize = true;
            this.lbNota1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNota1.Location = new System.Drawing.Point(49, 146);
            this.lbNota1.Name = "lbNota1";
            this.lbNota1.Size = new System.Drawing.Size(64, 21);
            this.lbNota1.TabIndex = 20;
            this.lbNota1.Text = "Nota1:";
            // 
            // txbNota1
            // 
            this.txbNota1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota1.Location = new System.Drawing.Point(145, 143);
            this.txbNota1.Name = "txbNota1";
            this.txbNota1.Size = new System.Drawing.Size(186, 29);
            this.txbNota1.TabIndex = 19;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEndereco.Location = new System.Drawing.Point(49, 103);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(91, 21);
            this.lbEndereco.TabIndex = 18;
            this.lbEndereco.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEndereco.Location = new System.Drawing.Point(145, 100);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(327, 29);
            this.txbEndereco.TabIndex = 17;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(49, 60);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(61, 21);
            this.lbNome.TabIndex = 16;
            this.lbNome.Text = "Nome:";
            // 
            // lbClasse
            // 
            this.lbClasse.AutoSize = true;
            this.lbClasse.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbClasse.Location = new System.Drawing.Point(43, 9);
            this.lbClasse.Name = "lbClasse";
            this.lbClasse.Size = new System.Drawing.Size(244, 27);
            this.lbClasse.TabIndex = 15;
            this.lbClasse.Text = "Exemplo Classe Aluno";
            this.lbClasse.Click += new System.EventHandler(this.lbClasse_Click);
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(145, 57);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(327, 29);
            this.txbNome.TabIndex = 14;
            // 
            // lbNota2
            // 
            this.lbNota2.AutoSize = true;
            this.lbNota2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNota2.Location = new System.Drawing.Point(49, 188);
            this.lbNota2.Name = "lbNota2";
            this.lbNota2.Size = new System.Drawing.Size(64, 21);
            this.lbNota2.TabIndex = 29;
            this.lbNota2.Text = "Nota2:";
            // 
            // txbNota2
            // 
            this.txbNota2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota2.Location = new System.Drawing.Point(145, 185);
            this.txbNota2.Name = "txbNota2";
            this.txbNota2.Size = new System.Drawing.Size(186, 29);
            this.txbNota2.TabIndex = 28;
            // 
            // lbNota3
            // 
            this.lbNota3.AutoSize = true;
            this.lbNota3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNota3.Location = new System.Drawing.Point(49, 234);
            this.lbNota3.Name = "lbNota3";
            this.lbNota3.Size = new System.Drawing.Size(64, 21);
            this.lbNota3.TabIndex = 31;
            this.lbNota3.Text = "Nota3:";
            // 
            // txbNota3
            // 
            this.txbNota3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNota3.Location = new System.Drawing.Point(145, 231);
            this.txbNota3.Name = "txbNota3";
            this.txbNota3.Size = new System.Drawing.Size(186, 29);
            this.txbNota3.TabIndex = 30;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(193, 314);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 44);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClasseAluno);
            this.groupBox1.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 304);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classe Aluno";
            // 
            // lblClasseAluno
            // 
            this.lblClasseAluno.AutoSize = true;
            this.lblClasseAluno.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClasseAluno.Location = new System.Drawing.Point(17, 27);
            this.lblClasseAluno.Name = "lblClasseAluno";
            this.lblClasseAluno.Size = new System.Drawing.Size(0, 14);
            this.lblClasseAluno.TabIndex = 17;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(345, 314);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 44);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 699);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbNota3);
            this.Controls.Add(this.txbNota3);
            this.Controls.Add(this.lbNota2);
            this.Controls.Add(this.txbNota2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbDtNasc);
            this.Controls.Add(this.lbNota1);
            this.Controls.Add(this.txbNota1);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbClasse);
            this.Controls.Add(this.txbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private DateTimePicker dateTimePicker1;
        private Label lbDtNasc;
        private Label lbNota1;
        private TextBox txbNota1;
        private Label lbEndereco;
        private TextBox txbEndereco;
        private Label lbNome;
        private Label lbClasse;
        private TextBox txbNome;
        private Label lbNota2;
        private TextBox txbNota2;
        private Label lbNota3;
        private TextBox txbNota3;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private Label lblClasseAluno;
        private Button btnLimpar;
    }
}