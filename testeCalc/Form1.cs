using System.Diagnostics;
using System.Windows.Forms;

namespace testeCalc
{
    public partial class Form1 : Form
    {
        private Form frmAtivo;

        public Form1()
        {
            InitializeComponent();

        }

        public void InitializeButtons()
        {
            btnOuro.Tag = 1;      // ID do material Ouro
            btnPrata.Tag = 2;     // ID do material Prata
            btnLatao.Tag = 3;     // ID do material Latão
            btnFerro.Tag = 4;     // ID do material Ferro
            btnConcreto.Tag = 5;  // ID do material Concreto
            btnChumbo.Tag = 6;  // ID do material Concreto
            btnAco.Tag = 7;  // ID do material Concreto
            btnBronze.Tag = 8;  // ID do material Concreto
            btnAluminio.Tag = 9;  // ID do material Alumínio
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            if (frm is FrmInformacoes informacoesForm)
            {
                // Assina o evento
                informacoesForm.RequestFormChange += FormShow;
            }
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;  // Isso faz com que o formulário filho preencha o painel
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                if (frmAtivo is FrmInformacoes informacoesForm)
                {
                    // Desassina o evento
                    informacoesForm.RequestFormChange -= FormShow;
                }
                frmAtivo.Close();
            }
        }

        public void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in pnBotoes.Controls)
            {
                ctrl.BackColor = Color.Gray;
            }
            frmAtivo.BackColor = Color.DarkGray;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeButtons();

        }

        private void btnOuro_Click(object sender, EventArgs e)
        {
            ActiveButton(btnOuro);
            int materialId = Convert.ToInt32(btnOuro.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnPrata_Click(object sender, EventArgs e)
        {
            ActiveButton(btnPrata);
            int materialId = Convert.ToInt32(btnPrata.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnLatao_Click(object sender, EventArgs e)
        {
            ActiveButton(btnLatao);
            int materialId = Convert.ToInt32(btnLatao.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnFerro_Click(object sender, EventArgs e)
        {
            ActiveButton(btnFerro);
            int materialId = Convert.ToInt32(btnFerro.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnConcreto_Click(object sender, EventArgs e)
        {
            ActiveButton(btnConcreto);
            int materialId = Convert.ToInt32(btnConcreto.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnAluminio_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAluminio);
            int materialId = Convert.ToInt32(btnAluminio.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnChumbo_Click(object sender, EventArgs e)
        {
            ActiveButton(btnChumbo);
            int materialId = Convert.ToInt32(btnChumbo.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnAco_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAco);
            int materialId = Convert.ToInt32(btnAco.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void btnBronze_Click(object sender, EventArgs e)
        {
            ActiveButton(btnBronze);
            int materialId = Convert.ToInt32(btnBronze.Tag);
            FormShow(new FrmInformacoes(materialId));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            //mensagem de confirmacao para fechar janela
        }

        private void llGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/Rubens-Collin",
                    UseShellExecute = true // Garante que o URL será aberto no navegador padrão
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o URL: " + ex.Message);
            }
            llGithub.LinkVisited = true;
        }

    }
}

