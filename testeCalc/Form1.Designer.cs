namespace testeCalc
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            label2 = new Label();
            lblLogo = new Label();
            pictureBox1 = new PictureBox();
            panelForm = new Panel();
            llGithub = new LinkLabel();
            lblApresentacao = new Label();
            label3 = new Label();
            btnConcreto = new Button();
            btnFerro = new Button();
            label1 = new Label();
            btnPrata = new Button();
            btnLatao = new Button();
            panelPrincipal = new Panel();
            pnBotoes = new Panel();
            btnAluminio = new Button();
            btnBronze = new Button();
            btnAco = new Button();
            btnOuro = new Button();
            btnChumbo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelForm.SuspendLayout();
            panelPrincipal.SuspendLayout();
            pnBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bronze-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(1, "Chumbo-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(2, "aço-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(3, "aluminio-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(4, "concreto-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(5, "ferro-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(6, "gold-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(7, "Latao-Photoroom.png-Photoroom.png");
            imageList1.Images.SetKeyName(8, "silver-Photoroom.png-Photoroom.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Cursor = Cursors.No;
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 53);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(212, 30);
            label2.TabIndex = 0;
            label2.Text = "Selecione o Material";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Cursor = Cursors.No;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.ControlText;
            lblLogo.Location = new Point(85, 46);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(152, 21);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Calculadora Linear";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.AutoSize = true;
            panelForm.BackColor = Color.Transparent;
            panelForm.BackgroundImage = Properties.Resources.aaaaa;
            panelForm.BackgroundImageLayout = ImageLayout.Stretch;
            panelForm.Controls.Add(llGithub);
            panelForm.Controls.Add(lblApresentacao);
            panelForm.Controls.Add(label3);
            panelForm.Location = new Point(237, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(870, 631);
            panelForm.TabIndex = 4;
            // 
            // llGithub
            // 
            llGithub.AutoSize = true;
            llGithub.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llGithub.Location = new Point(399, 427);
            llGithub.Name = "llGithub";
            llGithub.Size = new Size(70, 25);
            llGithub.TabIndex = 2;
            llGithub.TabStop = true;
            llGithub.Text = "Github";
            llGithub.LinkClicked += llGithub_LinkClicked;
            // 
            // lblApresentacao
            // 
            lblApresentacao.AutoSize = true;
            lblApresentacao.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApresentacao.Location = new Point(49, 177);
            lblApresentacao.Name = "lblApresentacao";
            lblApresentacao.Size = new Size(769, 275);
            lblApresentacao.TabIndex = 1;
            lblApresentacao.Text = resources.GetString("lblApresentacao.Text");
            // 
            // label3
            // 
            label3.Cursor = Cursors.No;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.ImageKey = "menu.png";
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(870, 118);
            label3.TabIndex = 0;
            label3.Text = "Bem-Vindo ao Software de dilatação termica dos materiais.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConcreto
            // 
            btnConcreto.Cursor = Cursors.Hand;
            btnConcreto.FlatAppearance.BorderSize = 0;
            btnConcreto.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnConcreto.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnConcreto.FlatStyle = FlatStyle.Popup;
            btnConcreto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConcreto.ForeColor = SystemColors.ControlText;
            btnConcreto.ImageAlign = ContentAlignment.MiddleLeft;
            btnConcreto.ImageKey = "concreto-Photoroom.png-Photoroom.png";
            btnConcreto.ImageList = imageList1;
            btnConcreto.Location = new Point(2, 210);
            btnConcreto.Name = "btnConcreto";
            btnConcreto.Padding = new Padding(0, 0, 0, 1);
            btnConcreto.Size = new Size(232, 45);
            btnConcreto.TabIndex = 5;
            btnConcreto.Text = "Concreto\r\n";
            btnConcreto.TextAlign = ContentAlignment.MiddleRight;
            btnConcreto.UseVisualStyleBackColor = true;
            btnConcreto.Click += btnConcreto_Click;
            // 
            // btnFerro
            // 
            btnFerro.Cursor = Cursors.Hand;
            btnFerro.FlatAppearance.BorderSize = 0;
            btnFerro.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnFerro.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnFerro.FlatStyle = FlatStyle.Popup;
            btnFerro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFerro.ForeColor = SystemColors.ControlText;
            btnFerro.ImageAlign = ContentAlignment.MiddleLeft;
            btnFerro.ImageKey = "ferro-Photoroom.png-Photoroom.png";
            btnFerro.ImageList = imageList1;
            btnFerro.Location = new Point(2, 261);
            btnFerro.Name = "btnFerro";
            btnFerro.Size = new Size(232, 45);
            btnFerro.TabIndex = 4;
            btnFerro.Text = "Ferro\r\n(Fe)";
            btnFerro.TextAlign = ContentAlignment.MiddleRight;
            btnFerro.UseVisualStyleBackColor = true;
            btnFerro.Click += btnFerro_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 10);
            label1.TabIndex = 0;
            // 
            // btnPrata
            // 
            btnPrata.Cursor = Cursors.Hand;
            btnPrata.FlatAppearance.BorderSize = 0;
            btnPrata.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnPrata.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnPrata.FlatStyle = FlatStyle.Popup;
            btnPrata.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrata.ForeColor = SystemColors.ControlText;
            btnPrata.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrata.ImageKey = "silver-Photoroom.png-Photoroom.png";
            btnPrata.ImageList = imageList1;
            btnPrata.Location = new Point(2, 414);
            btnPrata.Name = "btnPrata";
            btnPrata.Size = new Size(232, 45);
            btnPrata.TabIndex = 2;
            btnPrata.Text = "Prata\r\n(Ag)";
            btnPrata.TextAlign = ContentAlignment.MiddleRight;
            btnPrata.UseVisualStyleBackColor = true;
            btnPrata.Click += btnPrata_Click;
            // 
            // btnLatao
            // 
            btnLatao.Cursor = Cursors.Hand;
            btnLatao.FlatAppearance.BorderSize = 0;
            btnLatao.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnLatao.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnLatao.FlatStyle = FlatStyle.Popup;
            btnLatao.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLatao.ForeColor = SystemColors.ControlText;
            btnLatao.ImageAlign = ContentAlignment.MiddleLeft;
            btnLatao.ImageKey = "Latao-Photoroom.png-Photoroom.png";
            btnLatao.ImageList = imageList1;
            btnLatao.Location = new Point(2, 312);
            btnLatao.Name = "btnLatao";
            btnLatao.Size = new Size(232, 45);
            btnLatao.TabIndex = 3;
            btnLatao.Text = "   Latão\r\n(CuZn)";
            btnLatao.TextAlign = ContentAlignment.MiddleRight;
            btnLatao.UseVisualStyleBackColor = true;
            btnLatao.Click += btnLatao_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Gray;
            panelPrincipal.Controls.Add(lblLogo);
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(pnBotoes);
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Dock = DockStyle.Left;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(237, 631);
            panelPrincipal.TabIndex = 3;
            // 
            // pnBotoes
            // 
            pnBotoes.BackColor = Color.Gray;
            pnBotoes.Controls.Add(btnAluminio);
            pnBotoes.Controls.Add(btnBronze);
            pnBotoes.Controls.Add(btnAco);
            pnBotoes.Controls.Add(btnConcreto);
            pnBotoes.Controls.Add(btnPrata);
            pnBotoes.Controls.Add(btnOuro);
            pnBotoes.Controls.Add(btnChumbo);
            pnBotoes.Controls.Add(btnLatao);
            pnBotoes.Controls.Add(btnFerro);
            pnBotoes.Location = new Point(0, 163);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(237, 468);
            pnBotoes.TabIndex = 7;
            // 
            // btnAluminio
            // 
            btnAluminio.Cursor = Cursors.Hand;
            btnAluminio.FlatAppearance.BorderSize = 0;
            btnAluminio.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnAluminio.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnAluminio.FlatStyle = FlatStyle.Popup;
            btnAluminio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAluminio.ForeColor = SystemColors.ControlText;
            btnAluminio.ImageAlign = ContentAlignment.MiddleLeft;
            btnAluminio.ImageKey = "aluminio-Photoroom.png-Photoroom.png";
            btnAluminio.ImageList = imageList1;
            btnAluminio.Location = new Point(2, 3);
            btnAluminio.Name = "btnAluminio";
            btnAluminio.Size = new Size(232, 45);
            btnAluminio.TabIndex = 7;
            btnAluminio.Text = "Alumínio";
            btnAluminio.TextAlign = ContentAlignment.MiddleRight;
            btnAluminio.UseVisualStyleBackColor = true;
            btnAluminio.Click += btnAluminio_Click;
            // 
            // btnBronze
            // 
            btnBronze.Cursor = Cursors.Hand;
            btnBronze.FlatAppearance.BorderSize = 0;
            btnBronze.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnBronze.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnBronze.FlatStyle = FlatStyle.Popup;
            btnBronze.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBronze.ForeColor = SystemColors.ControlText;
            btnBronze.ImageAlign = ContentAlignment.MiddleLeft;
            btnBronze.ImageKey = "bronze-Photoroom.png-Photoroom.png";
            btnBronze.ImageList = imageList1;
            btnBronze.Location = new Point(2, 108);
            btnBronze.Name = "btnBronze";
            btnBronze.Size = new Size(232, 45);
            btnBronze.TabIndex = 5;
            btnBronze.Text = "Bronze";
            btnBronze.TextAlign = ContentAlignment.MiddleRight;
            btnBronze.UseVisualStyleBackColor = true;
            btnBronze.Click += btnBronze_Click;
            // 
            // btnAco
            // 
            btnAco.Cursor = Cursors.Hand;
            btnAco.FlatAppearance.BorderSize = 0;
            btnAco.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnAco.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnAco.FlatStyle = FlatStyle.Popup;
            btnAco.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAco.ForeColor = SystemColors.ControlText;
            btnAco.ImageAlign = ContentAlignment.MiddleLeft;
            btnAco.ImageKey = "aço-Photoroom.png-Photoroom.png";
            btnAco.ImageList = imageList1;
            btnAco.Location = new Point(2, 57);
            btnAco.Name = "btnAco";
            btnAco.Size = new Size(232, 45);
            btnAco.TabIndex = 6;
            btnAco.Text = "Aço";
            btnAco.TextAlign = ContentAlignment.MiddleRight;
            btnAco.UseVisualStyleBackColor = true;
            btnAco.Click += btnAco_Click;
            // 
            // btnOuro
            // 
            btnOuro.Cursor = Cursors.Hand;
            btnOuro.FlatAppearance.BorderSize = 0;
            btnOuro.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnOuro.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnOuro.FlatStyle = FlatStyle.Popup;
            btnOuro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOuro.ForeColor = SystemColors.ControlText;
            btnOuro.ImageAlign = ContentAlignment.MiddleLeft;
            btnOuro.ImageKey = "gold-Photoroom.png-Photoroom.png";
            btnOuro.ImageList = imageList1;
            btnOuro.Location = new Point(2, 363);
            btnOuro.Name = "btnOuro";
            btnOuro.Size = new Size(232, 45);
            btnOuro.TabIndex = 0;
            btnOuro.Text = "Ouro\r\n";
            btnOuro.TextAlign = ContentAlignment.MiddleRight;
            btnOuro.UseVisualStyleBackColor = true;
            btnOuro.Click += btnOuro_Click;
            // 
            // btnChumbo
            // 
            btnChumbo.Cursor = Cursors.Hand;
            btnChumbo.FlatAppearance.BorderSize = 0;
            btnChumbo.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnChumbo.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnChumbo.FlatStyle = FlatStyle.Popup;
            btnChumbo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChumbo.ForeColor = SystemColors.Desktop;
            btnChumbo.ImageAlign = ContentAlignment.MiddleLeft;
            btnChumbo.ImageKey = "Chumbo-Photoroom.png-Photoroom.png";
            btnChumbo.ImageList = imageList1;
            btnChumbo.Location = new Point(2, 159);
            btnChumbo.Name = "btnChumbo";
            btnChumbo.Size = new Size(232, 45);
            btnChumbo.TabIndex = 5;
            btnChumbo.Text = "Chumbo";
            btnChumbo.TextAlign = ContentAlignment.MiddleRight;
            btnChumbo.UseVisualStyleBackColor = true;
            btnChumbo.Click += btnChumbo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1107, 631);
            Controls.Add(panelForm);
            Controls.Add(panelPrincipal);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1123, 670);
            MinimizeBox = false;
            MinimumSize = new Size(1123, 670);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Linear";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            pnBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label lblLogo;
        private Panel panel1;
        private Panel panelForm;
        private Label label3;
        private Button btnConcreto;
        private Button btnFerro;
        private Button btnLatao;
        private Button btnPrata;
        private Label label1;
        private Panel panelPrincipal;
        private Button btnOuro;
        public Panel pnBotoes;
        private Button btnBronze;
        private Button btnAco;
        private Button btnChumbo;
        private Button btnAluminio;
        private Label lblApresentacao;
        private LinkLabel llGithub;
        private Label label2;
    }
}
