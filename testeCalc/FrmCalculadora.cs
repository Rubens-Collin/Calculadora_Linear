using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //declarando biblioteca de entrada e saida de arquivos

namespace testeCalc
{
    public partial class FrmCalculadora : Form
    {
        public int materialId;
        public double coeficiente;
        public double resultadoLargura;
        public double resultadoAltura;
        public double resultadoComprimento;

        public FrmCalculadora(int materialId)
        {
            InitializeComponent();
            this.materialId = materialId;
            Material material = GerenciadorMateriais.ObterMaterial(materialId);
        }

        private bool ValidarMedidas()
        {
            // Verifica se pelo menos um dos campos de medida possui um valor válido maior que zero.
            if (!string.IsNullOrEmpty(txtAltura.Text) && float.TryParse(txtAltura.Text, out float altura) && altura > 0 ||
                !string.IsNullOrEmpty(txtLargura.Text) && float.TryParse(txtLargura.Text, out float largura) && largura > 0 ||
                !string.IsNullOrEmpty(txtComprimento.Text) && float.TryParse(txtComprimento.Text, out float comprimento) && comprimento > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Insira pelo menos uma medida válida (altura, largura ou comprimento).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private string FormatarResultado()
        {
            // Pega os valores das TextBoxes
            if (!float.TryParse(txtLargura.Text, out float largura))
                largura = 0;
            if (!float.TryParse(txtAltura.Text, out float altura))
                altura = 0;
            if (!float.TryParse(txtComprimento.Text, out float comprimento))
                comprimento = 0;
            float.TryParse(txtTempInicial.Text, out float tempInicial);

            float.TryParse(txtTempFinal.Text, out float tempFinal);

            // Obtém o coeficiente do material
            Material material = GerenciadorMateriais.ObterMaterial(materialId);
            double coeficiente = material.Coeficiente;

            // Calcula os resultados
            double resultadoLargura = material.CalculoMaterial(largura, coeficiente, tempInicial, tempFinal);
            double resultadoAltura = material.CalculoMaterial(altura, coeficiente, tempInicial, tempFinal);
            double resultadoComprimento = material.CalculoMaterial(comprimento, coeficiente, tempInicial, tempFinal);

            // Formata a saída dependendo dos campos preenchidos
            StringBuilder resultado = new StringBuilder();
            if (largura > 0)
                resultado.AppendLine($"Dilatação da Largura: {resultadoLargura:N2} mm\r\nSoma da Largura: {(largura + resultadoLargura):N2} mm");
                resultado.AppendLine($" ");
            if (altura > 0)
                resultado.AppendLine($"Dilatação da Altura: {resultadoAltura:N2} mm\r\nSoma da Altura: {(altura + resultadoAltura):N2} mm");
                resultado.AppendLine($" ");
            if (comprimento > 0)
                resultado.AppendLine($"Dilatação do Comprimento: {resultadoComprimento:N2} mm\r\nSoma do Comprimento: {(comprimento + resultadoComprimento):N2} mm");
                resultado.AppendLine($" ");

            return resultado.ToString();
        }

        private string FormatarSalvar()
        {
            // Pega os valores das TextBoxes
            if (!float.TryParse(txtLargura.Text, out float largura))
                largura = 0;
            if (!float.TryParse(txtAltura.Text, out float altura))
                altura = 0;
            if (!float.TryParse(txtComprimento.Text, out float comprimento))
                comprimento = 0;
            float.TryParse(txtTempInicial.Text, out float tempInicial);

            float.TryParse(txtTempFinal.Text, out float tempFinal);
                

            // Obtém o coeficiente do material
            Material material = GerenciadorMateriais.ObterMaterial(materialId);
            double coeficiente = material.Coeficiente;

            // Calcula os resultados
            double resultadoLargura = material.CalculoMaterial(largura, coeficiente, tempInicial, tempFinal);
            double resultadoAltura = material.CalculoMaterial(altura, coeficiente, tempInicial, tempFinal);
            double resultadoComprimento = material.CalculoMaterial(comprimento, coeficiente, tempInicial, tempFinal);

            // Formata a saída dependendo dos campos preenchidos


            StringBuilder resultado = new StringBuilder();

            resultado.AppendLine($"Material: {material.Nome}");
            resultado.AppendLine($" ");
            resultado.AppendLine($"Largura Inserida: {largura} mm \r\nAltura Inserida: {altura} mm\r\nComprimento Inserido: {comprimento} mm");
            resultado.AppendLine($" ");
            resultado.AppendLine($"Temperatura Inicial: {tempInicial} °C\r\nTemperatura Final: {tempFinal} °C");
            resultado.AppendLine($" ");



            if (largura > 0)
                resultado.AppendLine($"Dilatação da Largura: {resultadoLargura:N2} mm\r\nSoma da Largura: {(largura + resultadoLargura):N2} mm");
            resultado.AppendLine($" ");
            if (altura > 0)
                resultado.AppendLine($"Dilatação da Altura: {resultadoAltura:N2} mm\r\nSoma da Altura: {(altura + resultadoAltura):N2} mm");
            resultado.AppendLine($" ");
            if (comprimento > 0)
                resultado.AppendLine($"Dilatação do Comprimento: {resultadoComprimento:N2} mm\r\nSoma do Comprimento: {(comprimento + resultadoComprimento):N2} mm");
            resultado.AppendLine($" ");

            return resultado.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarMedidas() && !string.IsNullOrEmpty(txtTempInicial.Text) && !string.IsNullOrEmpty(txtTempFinal.Text))
            {
                txtExibirCalculo.Text = FormatarResultado();
            }
            else
            {
                MessageBox.Show("Verifique se todas as temperaturas foram inseridas corretamente.", "Erro ao calcular", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarMedidas() && !string.IsNullOrEmpty(txtTempInicial.Text) && !string.IsNullOrEmpty(txtTempFinal.Text))
            {
                SalvarCalculo();
            }
            else
            {
                MessageBox.Show("Verifique se todas as medidas e temperaturas foram inseridas corretamente.", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarCalculo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Salvar Como",
                FileName = $"Historico_Calculadora_{DateTime.Now:dd_MM_yyyy_HH_mm_ss}.txt",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                File.WriteAllText(saveFileDialog.FileName, FormatarSalvar());
                MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível salvar. Verifique o local escolhido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtLargura.Clear();
            txtComprimento.Clear();
            txtTempInicial.Clear();
            txtTempFinal.Clear();
            txtExibirCalculo.Clear();
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja voltar? Seus dados serão perdidos", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            //mensagem de confirmacao para encerrar o programa
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process meuProcesso = System.Diagnostics.Process.Start("notepad.exe");
            meuProcesso.WaitForExit();
            //comando para abrir o bloco de notas
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process meuProcesso = System.Diagnostics.Process.Start("calc.exe");
            meuProcesso.WaitForExit();
            //comando para abrir a calculadora
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorico destino = new FrmHistorico();
            destino.ShowDialog();
        }

        public static void DecNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
                e.Handled = true;
        }
        //colocando para que insira apenas numeros e uma virgula(substitui o ponto por virgula)
        //nao aceita letras

        private void txtLargura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtLargura.Text.Contains(","))
                {
                    TextBox txt = (TextBox)sender;
                    if (txt.Text.Contains(","))
                        e.Handled = true; // Caso exista, nao deixa adicionar mais
                }

            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Você deve utilizar apenas numeros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtAltura.Text.Contains(","))
                {
                    TextBox txt = (TextBox)sender;
                    if (txt.Text.Contains(","))
                        e.Handled = true; // Caso exista, nao deixa adicionar mais
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Você deve utilizar apenas numeros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtComprimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtComprimento.Text.Contains(","))
                {
                    TextBox txt = (TextBox)sender;
                    if (txt.Text.Contains(","))
                        e.Handled = true; // Caso exista, nao deixa adicionar mais
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Você deve utilizar apenas numeros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtTempInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtTempInicial.Text.Contains(","))
                {
                    TextBox txt = (TextBox)sender;
                    if (txt.Text.Contains(","))
                        e.Handled = true; // Caso exista, nao deixa adicionar mais
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                // Se não for um número, um sinal de menos, ou a tecla de retrocesso, ignora a entrada de teclado
                e.Handled = true;
            }

            // Verifica se o sinal de menos é o primeiro caractere e está na posição inicial
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1 || (sender as TextBox).SelectionStart > 0))
            {
                // Se já existe um sinal de menos ou se não está no início do texto, ignora a entrada de teclado
                e.Handled = true;
            }


            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && (e.KeyChar != '-'))
            {
                MessageBox.Show("Você deve utilizar apenas numeros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtTempFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtTempFinal.Text.Contains(","))
                {
                    TextBox txt = (TextBox)sender;
                    if (txt.Text.Contains(","))
                        e.Handled = true; // Caso exista, nao deixa adicionar mais
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                // Se não for um número, um sinal de menos, ou a tecla de retrocesso, ignora a entrada de teclado
                e.Handled = true;
            }

            // Verifica se o sinal de menos é o primeiro caractere e está na posição inicial
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1 || (sender as TextBox).SelectionStart > 0))
            {
                // Se já existe um sinal de menos ou se não está no início do texto, ignora a entrada de teclado
                e.Handled = true;
            }


            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && (e.KeyChar != '-'))
            {
                MessageBox.Show("Você deve utilizar apenas numeros", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            //pre selecionando os combobox como cm e °C
            CarregaDados();

        }
        private void CarregaDados()
        {
            Material material = GerenciadorMateriais.ObterMaterial(materialId);
            if (material != null)
            {
                lblNomeMaterial.Text = material.Nome;
                lblCoeficiente.Text = material.Coeficiente.ToString("F6");
                lblPontoFusao.Text = material.PontoDeFusao;

                try
                {
                    string imagePath = Path.Combine(Application.StartupPath, material.Imagem);
                    picMaterial.Image = Image.FromFile(imagePath);
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
