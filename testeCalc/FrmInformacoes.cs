using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeCalc
{
    public partial class FrmInformacoes : Form
    {
        public event Action<Form> RequestFormChange;
        public int materialId;


        public int MaterialId { get; set; }

        public FrmInformacoes(int materialId)
        {
            InitializeComponent();
            CarregarDadosMaterial(materialId);
            this.materialId = materialId;
        }

         
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            RequestFormChange?.Invoke(new FrmCalculadora(materialId));
        }

        private void FrmInformacoes_Load(object sender, EventArgs e)
        {
             CarregarDadosMaterial(this.materialId);
        }
        public void CarregarDadosMaterial(int materialId)
        {
            Material material = GerenciadorMateriais.ObterMaterial(materialId);
            if (material != null)
            {
                txtNomeMaterial.Text = material.Nome;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" ");
                sb.AppendLine("Símbolo: " + material.Simbolo);
                sb.AppendLine("Coeficiente Linear: " + material.Coeficiente.ToString("F6"));
                sb.AppendLine("Ponto de Fusão: " + material.PontoDeFusao);

                txtInformacoes.Text = sb.ToString();

                try
                {
                    string imagePath = Path.Combine(Application.StartupPath, material.Imagem);
                    picImagemMaterial.Image = Image.FromFile(imagePath);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Imagem não encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Material não encontrado.");
            }
        }
    }
}
