using MasterFinanciamentos.Model;
Cliente cliente = new Cliente();
Carro carro = new Carro();
Financiamento financiamento = new Financiamento();
cliente.Nome = "João Silva";
cliente.Cpf = "123.456.789-00";
cliente.Telefone = "(11) 98765-4321";
cliente.Endereco = "Rua das Flores, 123";   
carro.Marca = "Volkswagen";
carro.Modelo = "Gol";
carro.Chassi=("9BWZZZ377VT004251");
carro.Cor = "Prata";
financiamento.Valor = 50000;
financiamento.Juros = 5.5;
financiamento.Data = DateOnly.FromDateTime(DateTime.Now);
imprimeContrato contrato = new imprimeContrato(financiamento, carro, cliente);  

