Console.WriteLine("--- Troco ---");
Console.WriteLine();

Console.Write("Valor da compra: R$ ");
double valorCompra = Convert.ToDouble(Console.ReadLine());

Console.Write("Valor pago: R$ ");
double valorPago = Convert.ToDouble(Console.ReadLine());

double troco = valorPago - valorCompra;

Console.WriteLine();
Console.WriteLine($"Troco: R$ {troco:F2}");