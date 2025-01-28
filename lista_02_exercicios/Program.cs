/*Um usuário qur calcular suas despesas mensais. O exercicio consiste em solicitar ao usuário que insira suas despesas até que ele digite um valor 
negativo, sinalizando o fim da entrada. O aluno deve somar as depesas e apresentar o total utilizando while,
do while e for.*/

//usando while
double despesas = 0;
double despesa;
Console.WriteLine("Digite suas despesas: (valor negativo para sair)");
while (true)
{
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa < 0) break;
    despesas += despesa;
}
Console.WriteLine($"Total de despesas: {despesas}");

//do while
despesas = 0;
    do
{
    Console.WriteLine("Digite suas despesas: (valor negativo para sair)");
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa >= 0) despesas += despesa;
}
while (despesa >= 0);
Console.WriteLine($"Total de despesas: {despesas}");

//for
despesas = 0;
for (; ;)
{
    Console.WriteLine("Digite suas despesas: (valor negativo para sair)");
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa < 0) break;
    despesas += despesa;
    }
Console.WriteLine($"Total de despesas: {despesas}");

