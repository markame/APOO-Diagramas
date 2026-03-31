using System;
using System.Collections.Generic;
using System.Text;

namespace MasterFinanciamentos.Model
{
    public class Financiamento
    {
        private DateOnly data;
        private double valor;
        private double juros;

        public DateOnly Data { get => data; set => data = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Juros { get => juros; set => juros = value; }

        public string jsonConvert(Financiamento financiamento)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(financiamento);
            return json;
        }
    }
}
