/*Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira
a quantidade de produtos recebidos e vendidos até que ele digite 0. Depois disso, o programa deve calcular o
total de produtos em estoque, utilizando as três estruturas de repetição.*/

// usando while 
int totalEstoque = 0;
int recebidos, vendidos;
Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos ( 0 para sair): ");
while (true)
{
    Console.Write("recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
}
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");

//usando do while
totalEstoque = 0;
do
{
    Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos ( 0 para sair): ");
    Console.Write("recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
}
while (true);
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");





//usando for
totalEstoque = 0;
for (; ; )
{
    Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos ( 0 para sair): ");
    Console.Write("recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;

}
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");