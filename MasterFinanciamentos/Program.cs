using MasterFinanciamentos.Model;
Cliente cliente = new Cliente();
Carro carro = new Carro();
Financiamento financiamento = new Financiamento();
cliente.Nome = "João Silva";
cliente.Cpf = "123.456.789-00";
cliente.Telefone = "(11) 98765-4321";
cliente.Endereco = "Rua das Flores, 123";
carro.Modelo = "Civic";
carro.Marca = "Honda";
carro.Chassi= "9BWZZZ377VT004251";
carro.Cor = "Preto";
financiamento.DataFinanciamento = new DateOnly(2024, 6, 1);
financiamento.Valor = 50000.00;
financiamento.Juros = 5.0;
ImprimeContrato imprimeContrato = new ImprimeContrato(cliente, carro, financiamento);



