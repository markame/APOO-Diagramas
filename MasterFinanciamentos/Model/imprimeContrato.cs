using System;
using System.Collections.Generic;
using System.Text;

namespace MasterFinanciamentos.Model
{
    public class imprimeContrato
    {
         static private DateTime data = DateTime.Now.Date;

    public imprimeContrato(Financiamento financiamento, Carro carro, Cliente cliente)
        {
           string contrato = $"Contrato de Financiamento\n\n" +
                $"Data: {data.ToShortDateString()}\n\n" +
                $"Cliente: {cliente.Nome}\n" +
                $"CPF: {cliente.Cpf}\n" +
                $"Data de Nascimento: {cliente.DataNascimento.ToShortDateString()}\n" +
                $"Endereço: {cliente.Endereco}\n" +
                $"Telefone: {cliente.Telefone}\n\n" +
                $"Carro: {carro.Marca} {carro.Modelo}\n" +
                $"Chassi: {carro.Chassi}\n" +
                $"Cor: {carro.Cor}\n\n" +
                $"Valor do Financiamento: R$ {financiamento.Valor:F2}\n" +
                $"Juros: {financiamento.Juros}%\n"+"assinatura:\n"+"________________________";
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Marcos\\Desktop\\contrato\\contrato.txt");
                sw.WriteLine(contrato);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

}
