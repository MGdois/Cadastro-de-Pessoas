namespace Cadastro_de_Pessoas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Save1 = new Button();
            textBoxNumRua = new TextBox();
            textBoxNomeRua = new TextBox();
            textBoxNascimento = new TextBox();
            textBoxDocumento = new TextBox();
            textBoxNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            buttonDeleta = new Button();
            buttonBusca = new Button();
            textBoxBuscaDoc = new TextBox();
            labelNumRua = new Label();
            labelRua = new Label();
            labelNascimento = new Label();
            labelNome = new Label();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(23, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(592, 407);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Save1);
            tabPage1.Controls.Add(textBoxNumRua);
            tabPage1.Controls.Add(textBoxNomeRua);
            tabPage1.Controls.Add(textBoxNascimento);
            tabPage1.Controls.Add(textBoxDocumento);
            tabPage1.Controls.Add(textBoxNome);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(584, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Save1
            // 
            Save1.Location = new Point(31, 251);
            Save1.Name = "Save1";
            Save1.Size = new Size(103, 29);
            Save1.TabIndex = 10;
            Save1.Text = "Salvar";
            Save1.UseVisualStyleBackColor = true;
            Save1.Click += Save1_Click;
            // 
            // textBoxNumRua
            // 
            textBoxNumRua.Location = new Point(185, 198);
            textBoxNumRua.Name = "textBoxNumRua";
            textBoxNumRua.Size = new Size(254, 27);
            textBoxNumRua.TabIndex = 9;
            // 
            // textBoxNomeRua
            // 
            textBoxNomeRua.Location = new Point(185, 165);
            textBoxNomeRua.Name = "textBoxNomeRua";
            textBoxNomeRua.Size = new Size(254, 27);
            textBoxNomeRua.TabIndex = 8;
            // 
            // textBoxNascimento
            // 
            textBoxNascimento.Location = new Point(185, 129);
            textBoxNascimento.Name = "textBoxNascimento";
            textBoxNascimento.Size = new Size(254, 27);
            textBoxNascimento.TabIndex = 7;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Location = new Point(185, 93);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(254, 27);
            textBoxDocumento.TabIndex = 6;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(185, 60);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(254, 27);
            textBoxNome.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 201);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero da Rua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 168);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "Nome da Rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 132);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 96);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 63);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(buttonDeleta);
            tabPage2.Controls.Add(buttonBusca);
            tabPage2.Controls.Add(textBoxBuscaDoc);
            tabPage2.Controls.Add(labelNumRua);
            tabPage2.Controls.Add(labelRua);
            tabPage2.Controls.Add(labelNascimento);
            tabPage2.Controls.Add(labelNome);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(584, 374);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleta
            // 
            buttonDeleta.Location = new Point(455, 226);
            buttonDeleta.Name = "buttonDeleta";
            buttonDeleta.Size = new Size(94, 29);
            buttonDeleta.TabIndex = 21;
            buttonDeleta.Text = "Deletar";
            buttonDeleta.UseVisualStyleBackColor = true;
            buttonDeleta.Click += buttonDeleta_Click;
            // 
            // buttonBusca
            // 
            buttonBusca.Location = new Point(25, 226);
            buttonBusca.Name = "buttonBusca";
            buttonBusca.Size = new Size(94, 29);
            buttonBusca.TabIndex = 20;
            buttonBusca.Text = "Buscar";
            buttonBusca.UseVisualStyleBackColor = true;
            buttonBusca.Click += buttonBusca_Click;
            // 
            // textBoxBuscaDoc
            // 
            textBoxBuscaDoc.Location = new Point(213, 62);
            textBoxBuscaDoc.Name = "textBoxBuscaDoc";
            textBoxBuscaDoc.Size = new Size(292, 27);
            textBoxBuscaDoc.TabIndex = 19;
            // 
            // labelNumRua
            // 
            labelNumRua.AutoSize = true;
            labelNumRua.Location = new Point(213, 170);
            labelNumRua.Name = "labelNumRua";
            labelNumRua.Size = new Size(15, 20);
            labelNumRua.TabIndex = 18;
            labelNumRua.Text = "-";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Location = new Point(213, 137);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(15, 20);
            labelRua.TabIndex = 17;
            labelRua.Text = "-";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.Location = new Point(213, 101);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new Size(15, 20);
            labelNascimento.TabIndex = 16;
            labelNascimento.Text = "-";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(213, 28);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(15, 20);
            labelNome.TabIndex = 15;
            labelNome.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 28);
            label10.Name = "label10";
            label10.Size = new Size(121, 20);
            label10.TabIndex = 10;
            label10.Text = "Nome completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 170);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 25;
            label6.Text = "Numero da Rua:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 137);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 24;
            label7.Text = "Nome da Rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 101);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 23;
            label8.Text = "Data de Nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 65);
            label9.Name = "label9";
            label9.Size = new Size(148, 20);
            label9.TabIndex = 22;
            label9.Text = "Numero Documento:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxNumRua;
        private TextBox textBoxNomeRua;
        private TextBox textBoxNascimento;
        private TextBox textBoxDocumento;
        private TextBox textBoxNome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Save1;
        private Label labelNumRua;
        private Label labelRua;
        private Label labelData;
        private Label labelDocumento;
        private Label label10;
        private TextBox textBoxBuscaDoc;
        private Label label14;
        private Label label13;
        private Label labelNascimento;
        private Label labelNome;
        private Button buttonDeleta;
        private Button buttonBusca;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
