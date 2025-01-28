/* Ex. 08 - Um atendente de suporte técnico deseja contar quantas chamada
atendeu em um dia. O aluno deverá pedir que o usuário insira o tempo de duração
de cada chamada em minutos até que ele digite 0. O programa deve calcular o total
de minutos atendidos,utilizando while, do while e for.*/

//usando while
int totalChamadas = 0;
int duracao;
Console.WriteLine("digite a duração das chamadas( 0 para sair)");
while (true)
{
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao == 0) break;
    totalChamadas += duracao;
}
Console.WriteLine($"Total de minutos atendidos: {totalChamadas} minutos.");

//usando do while
totalChamadas = 0;
do
{
    Console.WriteLine("digite a duração das chamadas( 0 para sair)");
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao != 0) totalChamadas += duracao;
}
while (duracao != 0);
Console.WriteLine($"Total de minutos atendidos: {totalChamadas} minutos.");

//usando for
totalChamadas = 0;
for (; ;)
{ 
    Console.WriteLine("digite a duração das chamadas( 0 para sair)");
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao == 0) break;
    totalChamadas += duracao;
}
Console.WriteLine($"Total de minutos atendidos: {totalChamadas} minutos.");