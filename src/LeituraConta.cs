using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Contas_de_Energia.src
{
    [Serializable]
    public class LeituraConta
    {
        private int periodo;
        private int exercicio;
        private float consumo_kWh;

        public int Periodo { get => periodo; set => periodo = value; }
        public int Exercicio { get => exercicio; set => exercicio = value; }
        public float Consumo_kWh { get => consumo_kWh; set => consumo_kWh = value; }
    }
}
