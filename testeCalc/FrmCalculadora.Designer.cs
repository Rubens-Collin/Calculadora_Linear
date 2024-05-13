namespace testeCalc
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            btnCancelar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            atalhoToolStripMenuItem = new ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            excelToolStripMenuItem = new ToolStripMenuItem();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            lblLargura = new Label();
            lblAltura = new Label();
            lblComprimento = new Label();
            lblTempInicial = new Label();
            txtLargura = new TextBox();
            txtAltura = new TextBox();
            txtComprimento = new TextBox();
            txtTempInicial = new TextBox();
            txtTempFinal = new TextBox();
            lblTempFinal = new Label();
            txtExibirCalculo = new TextBox();
            btnCalcular = new Button();
            btnSalvar = new Button();
            pnItens = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnLimpar = new Button();
            label4 = new Label();
            lblNomeMaterial = new Label();
            label5 = new Label();
            lblCoeficiente = new Label();
            picMaterial = new PictureBox();
            label6 = new Label();
            lblPontoFusao = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMaterial).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.AliceBlue;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(12, 584);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 35);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 66);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(396, 14);
            label2.Name = "label2";
            label2.Size = new Size(249, 32);
            label2.TabIndex = 2;
            label2.Text = "Insira os parametros";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { atalhoToolStripMenuItem, opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(870, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // atalhoToolStripMenuItem
            // 
            atalhoToolStripMenuItem.BackColor = Color.AliceBlue;
            atalhoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blocoDeNotasToolStripMenuItem, toolStripMenuItem1, excelToolStripMenuItem });
            atalhoToolStripMenuItem.Name = "atalhoToolStripMenuItem";
            atalhoToolStripMenuItem.Size = new Size(59, 20);
            atalhoToolStripMenuItem.Text = "Atalhos";
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.BackColor = Color.Transparent;
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new Size(152, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco de notas";
            blocoDeNotasToolStripMenuItem.Click += blocoDeNotasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.Transparent;
            toolStripMenuItem1.ForeColor = SystemColors.ActiveBorder;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(149, 6);
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.BackColor = Color.Transparent;
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(152, 22);
            excelToolStripMenuItem.Text = "Calculadora";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.BackColor = Color.AliceBlue;
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(67, 20);
            opçõesToolStripMenuItem.Text = "Historico";
            opçõesToolStripMenuItem.Visible = false;
            opçõesToolStripMenuItem.Click += opçõesToolStripMenuItem_Click;
            // 
            // lblLargura
            // 
            lblLargura.AutoSize = true;
            lblLargura.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLargura.Location = new Point(56, 17);
            lblLargura.Name = "lblLargura";
            lblLargura.Size = new Size(62, 20);
            lblLargura.TabIndex = 3;
            lblLargura.Text = "Largura:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 11.25F);
            lblAltura.Location = new Point(240, 17);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(52, 20);
            lblAltura.TabIndex = 4;
            lblAltura.Text = "Altura:";
            // 
            // lblComprimento
            // 
            lblComprimento.AutoSize = true;
            lblComprimento.Font = new Font("Segoe UI", 11.25F);
            lblComprimento.Location = new Point(426, 17);
            lblComprimento.Name = "lblComprimento";
            lblComprimento.Size = new Size(104, 20);
            lblComprimento.TabIndex = 5;
            lblComprimento.Text = "Comprimento:";
            // 
            // lblTempInicial
            // 
            lblTempInicial.AutoSize = true;
            lblTempInicial.Font = new Font("Segoe UI", 11.25F);
            lblTempInicial.Location = new Point(152, 96);
            lblTempInicial.Name = "lblTempInicial";
            lblTempInicial.Size = new Size(139, 20);
            lblTempInicial.TabIndex = 6;
            lblTempInicial.Text = "Temperatura Inicial:";
            // 
            // txtLargura
            // 
            txtLargura.Location = new Point(56, 45);
            txtLargura.MaxLength = 6;
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(100, 23);
            txtLargura.TabIndex = 7;
            txtLargura.KeyPress += txtLargura_KeyPress;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(240, 45);
            txtAltura.MaxLength = 6;
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 8;
            txtAltura.KeyPress += txtAltura_KeyPress;
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(426, 45);
            txtComprimento.MaxLength = 6;
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(100, 23);
            txtComprimento.TabIndex = 9;
            txtComprimento.KeyPress += txtComprimento_KeyPress;
            // 
            // txtTempInicial
            // 
            txtTempInicial.Location = new Point(162, 128);
            txtTempInicial.MaxLength = 8;
            txtTempInicial.Name = "txtTempInicial";
            txtTempInicial.Size = new Size(100, 23);
            txtTempInicial.TabIndex = 10;
            txtTempInicial.KeyPress += txtTempInicial_KeyPress;
            // 
            // txtTempFinal
            // 
            txtTempFinal.Location = new Point(359, 126);
            txtTempFinal.MaxLength = 8;
            txtTempFinal.Name = "txtTempFinal";
            txtTempFinal.Size = new Size(100, 23);
            txtTempFinal.TabIndex = 11;
            txtTempFinal.KeyPress += txtTempFinal_KeyPress;
            // 
            // lblTempFinal
            // 
            lblTempFinal.AutoSize = true;
            lblTempFinal.Font = new Font("Segoe UI", 11.25F);
            lblTempFinal.Location = new Point(355, 96);
            lblTempFinal.Name = "lblTempFinal";
            lblTempFinal.Size = new Size(131, 20);
            lblTempFinal.TabIndex = 12;
            lblTempFinal.Text = "Temperatura Final:";
            // 
            // txtExibirCalculo
            // 
            txtExibirCalculo.Enabled = false;
            txtExibirCalculo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExibirCalculo.Location = new Point(41, 223);
            txtExibirCalculo.Multiline = true;
            txtExibirCalculo.Name = "txtExibirCalculo";
            txtExibirCalculo.Size = new Size(559, 259);
            txtExibirCalculo.TabIndex = 18;
            txtExibirCalculo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F);
            btnCalcular.Location = new Point(41, 182);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(83, 35);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 11.25F);
            btnSalvar.Location = new Point(281, 493);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(83, 35);
            btnSalvar.TabIndex = 20;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pnItens
            // 
            pnItens.Controls.Add(label9);
            pnItens.Controls.Add(label8);
            pnItens.Controls.Add(label7);
            pnItens.Controls.Add(label3);
            pnItens.Controls.Add(label1);
            pnItens.Controls.Add(btnLimpar);
            pnItens.Controls.Add(btnSalvar);
            pnItens.Controls.Add(btnCalcular);
            pnItens.Controls.Add(txtExibirCalculo);
            pnItens.Controls.Add(lblTempFinal);
            pnItens.Controls.Add(txtTempFinal);
            pnItens.Controls.Add(txtTempInicial);
            pnItens.Controls.Add(txtComprimento);
            pnItens.Controls.Add(txtAltura);
            pnItens.Controls.Add(txtLargura);
            pnItens.Controls.Add(lblTempInicial);
            pnItens.Controls.Add(lblComprimento);
            pnItens.Controls.Add(lblAltura);
            pnItens.Controls.Add(lblLargura);
            pnItens.Location = new Point(210, 91);
            pnItens.Name = "pnItens";
            pnItens.Size = new Size(637, 528);
            pnItens.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(346, 48);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 26;
            label9.Text = "mm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(532, 48);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 25;
            label8.Text = "mm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(162, 48);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 24;
            label7.Text = "mm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(465, 126);
            label3.Name = "label3";
            label3.Size = new Size(26, 21);
            label3.TabIndex = 23;
            label3.Text = "°C";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 128);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 22;
            label1.Text = "°C";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 11.25F);
            btnLimpar.Location = new Point(517, 182);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(83, 35);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(6, 228);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 23;
            label4.Text = "Material: ";
            // 
            // lblNomeMaterial
            // 
            lblNomeMaterial.AutoSize = true;
            lblNomeMaterial.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeMaterial.Location = new Point(85, 225);
            lblNomeMaterial.Name = "lblNomeMaterial";
            lblNomeMaterial.Size = new Size(0, 20);
            lblNomeMaterial.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(6, 255);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 25;
            label5.Text = "Coeficiente: ";
            // 
            // lblCoeficiente
            // 
            lblCoeficiente.AutoSize = true;
            lblCoeficiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoeficiente.Location = new Point(85, 252);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(0, 20);
            lblCoeficiente.TabIndex = 26;
            // 
            // picMaterial
            // 
            picMaterial.Location = new Point(50, 108);
            picMaterial.Name = "picMaterial";
            picMaterial.Size = new Size(108, 99);
            picMaterial.SizeMode = PictureBoxSizeMode.StretchImage;
            picMaterial.TabIndex = 27;
            picMaterial.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(6, 282);
            label6.Name = "label6";
            label6.Size = new Size(102, 17);
            label6.TabIndex = 28;
            label6.Text = "Ponto de Fusão:";
            // 
            // lblPontoFusao
            // 
            lblPontoFusao.AutoSize = true;
            lblPontoFusao.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPontoFusao.Location = new Point(114, 282);
            lblPontoFusao.Name = "lblPontoFusao";
            lblPontoFusao.Size = new Size(0, 20);
            lblPontoFusao.TabIndex = 25;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(870, 631);
            Controls.Add(lblPontoFusao);
            Controls.Add(label6);
            Controls.Add(picMaterial);
            Controls.Add(lblCoeficiente);
            Controls.Add(label5);
            Controls.Add(lblNomeMaterial);
            Controls.Add(label4);
            Controls.Add(pnItens);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            MinimumSize = new Size(870, 631);
            Name = "FrmCalculadora";
            Text = "Calculo";
            WindowState = FormWindowState.Maximized;
            FormClosing += Calculo_FormClosing;
            Load += FrmCalculadora_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnItens.ResumeLayout(false);
            pnItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Panel panel1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atalhoToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private Label lblLargura;
        private Label lblAltura;
        private Label lblComprimento;
        private Label lblTempInicial;
        private TextBox txtLargura;
        private TextBox txtAltura;
        private TextBox txtComprimento;
        private TextBox txtTempInicial;
        private TextBox txtTempFinal;
        private Label lblTempFinal;
        private TextBox txtExibirCalculo;
        private Button btnCalcular;
        private Button btnSalvar;
        private Panel pnItens;
        private Button btnLimpar;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblNomeMaterial;
        private Label label5;
        private Label lblCoeficiente;
        private PictureBox picMaterial;
        private Label label6;
        private Label lblPontoFusao;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}