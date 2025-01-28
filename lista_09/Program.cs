/* Ex. 09 - Um cliente deseja saber o total de suas compras em um supermercado.O aluno deverá pedir para que o
usuário insira o valor de cada compra até que ele digite 0. A soma dos valores deve ser implementada usando
as três estruturas de repetição. */

//usando while
double totalCompras = 0;
double valorCompras;
    Console.WriteLine("Insira o valor de cada compra: (0 para sair):");
while (true)
{
    valorCompras = Convert.ToDouble(Console.ReadLine());
    if (valorCompras == 0) break;
    totalCompras += valorCompras;
}
Console.WriteLine($"Total de compras: {totalCompras}.");

//usando do while
totalCompras = 0;
    do
{
    Console.WriteLine("digite o valor de cada compra: (0 para sair): ");
        valorCompras = Convert.ToDouble(Console.ReadLine());
    if (valorCompras != 0) totalCompras += valorCompras;
}
while (valorCompras != 0);
    Console.WriteLine($"Total de compras: {totalCompras}.");

//usando for
totalCompras = 0;
for (; ;)
{
    Console.WriteLine("digite o valor de cada compra: (0 para sair): ");
    valorCompras = Convert.ToDouble(Console.ReadLine());
    if (valorCompras == 0) break;
    totalCompras += valorCompras;
}
Console.WriteLine($"Total de compras: {totalCompras} minutos: ");