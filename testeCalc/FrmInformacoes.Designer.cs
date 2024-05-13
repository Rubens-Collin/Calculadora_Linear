namespace testeCalc
{
    partial class FrmInformacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacoes));
            lblElementos = new Label();
            imageList1 = new ImageList(components);
            btnAvancar = new Button();
            txtInformacoes = new TextBox();
            txtNomeMaterial = new TextBox();
            picImagemMaterial = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImagemMaterial).BeginInit();
            SuspendLayout();
            // 
            // lblElementos
            // 
            lblElementos.Cursor = Cursors.No;
            lblElementos.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblElementos.ImageAlign = ContentAlignment.MiddleLeft;
            lblElementos.ImageKey = "(nenhum)";
            lblElementos.ImageList = imageList1;
            lblElementos.Location = new Point(223, 26);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(436, 70);
            lblElementos.TabIndex = 1;
            lblElementos.Text = "Informações do material ";
            lblElementos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Latao.jpeg");
            imageList1.Images.SetKeyName(1, "menu.png");
            imageList1.Images.SetKeyName(2, "Ouro.jpeg");
            imageList1.Images.SetKeyName(3, "Prata.jpeg");
            imageList1.Images.SetKeyName(4, "Aluminio.jpeg");
            imageList1.Images.SetKeyName(5, "Bronze.jpeg");
            imageList1.Images.SetKeyName(6, "Chumbo.jpeg");
            imageList1.Images.SetKeyName(7, "concreto 2.jpeg");
            imageList1.Images.SetKeyName(8, "Ferro.jpeg");
            imageList1.Images.SetKeyName(9, "icon-calc.ico");
            // 
            // btnAvancar
            // 
            btnAvancar.Location = new Point(751, 567);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(86, 40);
            btnAvancar.TabIndex = 8;
            btnAvancar.Text = "Avancar";
            btnAvancar.UseVisualStyleBackColor = true;
            btnAvancar.Click += btnAvancar_Click;
            // 
            // txtInformacoes
            // 
            txtInformacoes.BackColor = Color.AliceBlue;
            txtInformacoes.BorderStyle = BorderStyle.FixedSingle;
            txtInformacoes.Cursor = Cursors.No;
            txtInformacoes.Enabled = false;
            txtInformacoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInformacoes.Location = new Point(238, 377);
            txtInformacoes.Multiline = true;
            txtInformacoes.Name = "txtInformacoes";
            txtInformacoes.ReadOnly = true;
            txtInformacoes.Size = new Size(407, 160);
            txtInformacoes.TabIndex = 9;
            txtInformacoes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeMaterial
            // 
            txtNomeMaterial.BackColor = Color.AliceBlue;
            txtNomeMaterial.BorderStyle = BorderStyle.None;
            txtNomeMaterial.Cursor = Cursors.No;
            txtNomeMaterial.Enabled = false;
            txtNomeMaterial.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNomeMaterial.Location = new Point(238, 309);
            txtNomeMaterial.Name = "txtNomeMaterial";
            txtNomeMaterial.ReadOnly = true;
            txtNomeMaterial.Size = new Size(407, 43);
            txtNomeMaterial.TabIndex = 10;
            txtNomeMaterial.TextAlign = HorizontalAlignment.Center;
            // 
            // picImagemMaterial
            // 
            picImagemMaterial.Cursor = Cursors.No;
            picImagemMaterial.Location = new Point(362, 121);
            picImagemMaterial.Name = "picImagemMaterial";
            picImagemMaterial.Size = new Size(159, 147);
            picImagemMaterial.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagemMaterial.TabIndex = 11;
            picImagemMaterial.TabStop = false;
            // 
            // FrmInformacoes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(870, 631);
            Controls.Add(picImagemMaterial);
            Controls.Add(txtNomeMaterial);
            Controls.Add(txtInformacoes);
            Controls.Add(btnAvancar);
            Controls.Add(lblElementos);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(870, 631);
            MinimizeBox = false;
            MinimumSize = new Size(870, 631);
            Name = "FrmInformacoes";
            Text = "frmCalculo";
            WindowState = FormWindowState.Maximized;
            Load += FrmInformacoes_Load;
            ((System.ComponentModel.ISupportInitialize)picImagemMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblElementos;
        private ImageList imageList1;
        private Button btnAvancar;
        private TextBox txtInformacoes;
        private TextBox txtNomeMaterial;
        private PictureBox picImagemMaterial;
    }
}