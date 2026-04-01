using System;
using System.Collections.Generic;
using System.Text;

namespace MasterFinanciamentos.Model
{
    public class ImprimeContrato
    {
        private DateTime data = DateTime.Now;

        public ImprimeContrato(Cliente cliente, Carro carro, Financiamento financiamento)
        {
            string contrato = $"Contrato de Financiamento\n\n" +
                $"Cliente:\n" +
                $"Nome: {cliente.Nome}\n" +
                $"CPF: {cliente.Cpf}\n" +
                $"Telefone: {cliente.Telefone}\n" +
                $"Endereço: {cliente.Endereco}\n\n" +
                $"Carro:\n" +
                $"Modelo: {carro.Modelo}\n" +
                $"Marca: {carro.Marca}\n" +
                $"Chassi: {carro.Chassi}\n" +
                $"Cor: {carro.Cor}\n\n" +
                $"Financiamento:\n" +
                $"Data do Financiamento: {financiamento.DataFinanciamento.ToShortDateString()}\n" +
                $"Valor: R$ {financiamento.Valor:F2}\n" +
                $"Juros: {financiamento.Juros}%\n"+
                "Assinatura:\n"+"_______________________________\n"+
                $"Data: {data.ToShortDateString()}\n\n";
           Imprimir(contrato);
        }
        protected void Imprimir(string contrato)
        {
            try
            {
                string pathFile = @"C:\\Users\\Marcos\\Desktop\\contrato\\contratoFinanciamento.txt";
                StreamWriter sw = new StreamWriter(pathFile);
                sw.WriteLine(contrato);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.ToString() ); 
            }
        }
            
    }
}
