using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace testeCalc
{
    public class Material
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string PontoDeFusao { get; set; }
        public string Simbolo { get; set; }
        public double Coeficiente { get; set; }
        public string Imagem { get; set; }

        public float Medida;
        public double CalcCoeficiente;
        public float TempInicial;
        public float TempFinal;
        public double Resultado;
        
        public double CalculoMaterial(float medida, double coeficiente, float tempInicial, float tempFinal)
        {
            Medida = medida;
            CalcCoeficiente = coeficiente;
            TempInicial = tempInicial;
            TempFinal = tempFinal;

            if(Medida == 0)
            {
                return 0;
            }
            else
            {
                Resultado = Medida * CalcCoeficiente * (TempFinal - TempInicial);
                return Resultado;
            }

        }
    }

    public static class GerenciadorMateriais
    {
        private static Dictionary<int, Material> materiais;

        static GerenciadorMateriais()
        {
            materiais = new Dictionary<int, Material>();

            string LocalPadrao = Path.Combine(Application.StartupPath, "..", "Media");


            Console.WriteLine(LocalPadrao);

            // Adicionar materiais ao dicionário
            AdicionarMaterial(1, "Ouro", "1.064 °C", "Au", 0.000014, Path.Combine(LocalPadrao, "ouro.png"));
            AdicionarMaterial(2, "Prata", "961.8 °C", "Ag", 0.000020, Path.Combine(LocalPadrao, "prata.png"));
            AdicionarMaterial(3, "Latão", "940 °C", "Cu+Zn", 0.000019, Path.Combine(LocalPadrao, "latao.png"));
            AdicionarMaterial(4, "Ferro", "1538 °C", "Fe", 0.000012, Path.Combine(LocalPadrao, "ferro.png"));
            AdicionarMaterial(5, "Concreto", "1350 °C", "NA", 0.000012, Path.Combine(LocalPadrao, "concreto.png"));
            AdicionarMaterial(6, "Chumbo", "1350 °C", "Pb", 0.000029, Path.Combine(LocalPadrao, "chumbo.png"));
            AdicionarMaterial(7, "Aço", "1500 °C", "Fe+C", 0.000012, Path.Combine(LocalPadrao, "aco.png"));
            AdicionarMaterial(8, "Bronze", "900 °C", "Cu+Sn", 0.000018, Path.Combine(LocalPadrao, "bronze.png"));
            AdicionarMaterial(9, "Alumínio", "660 °C", "AI", 0.000024, Path.Combine(LocalPadrao, "aluminio.png"));
        }

        private static void AdicionarMaterial(int id, string nome, string pontoDeFusao, string simbolo, double coeficiente, string imagem)
        {
            materiais.Add(id, new Material
            {
                Id = id,
                Nome = nome,
                PontoDeFusao = pontoDeFusao,
                Simbolo = simbolo,
                Coeficiente = coeficiente,
                Imagem = imagem
            });
        }

        public static Material ObterMaterial(int id)
        {
            if (materiais.ContainsKey(id))
            {
                return materiais[id];
            }
            else
            {
                return null;
            }
        }
        
    }
    
}
