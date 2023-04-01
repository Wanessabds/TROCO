
decimal valorCompra, valorPago, valorTroco;

Console.WriteLine("--- NOTA DA COMPRA ---\n");

Console.Write("Digite o valor da compra (R$): ");
valorCompra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor pago pelo cliente (R$): ");
valorPago = Convert.ToDecimal(Console.ReadLine());

valorTroco = valorPago - valorCompra;

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"\n Valor do Troco: {valorTroco:C}");