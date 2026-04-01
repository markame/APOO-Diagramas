using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MasterFinanciamentos.Model
{
    public class Financiamento
    {
        private DateOnly dataFinanciamento;
        private double valor;
        private double juros;

        public DateOnly DataFinanciamento { get => dataFinanciamento; set => dataFinanciamento = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Juros { get => juros; set => juros = value; }
        public string jsonConvert(Financiamento financiamento)
        {
            string json = JsonConvert.SerializeObject(financiamento);
            return json;
        }
    }
}
