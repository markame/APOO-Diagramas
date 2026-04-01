using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MasterFinanciamentos.Model
{
    public class Carro
    {
        private string modelo;
        private string marca;
        private string chassi;
        private string cor;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Chassi { get => chassi; set => chassi = value; }
        public string Cor { get => cor; set => cor = value; }

        public string jsonConvert(Carro carro)
        {
           string json = JsonConvert.SerializeObject(carro);
            return json;
        }
            
            
     }
}
