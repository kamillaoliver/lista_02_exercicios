/*Ex. 10 - Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao
 usuário para inserir o valor das passagens vendidas até qie ele digite um valor negativo. O total das passagens
deve ser calculado e apresentado utilizando while, do while e for.*/

//usando while
int totalPassagens = 0;
double valorPassagens;
Console.WriteLine("digite o valor de cada passagem (negativo para sair): ");
while (true)
{ 
    valorPassagens = Convert.ToDouble(Console.ReadLine());
    if (valorPassagens < 0) break;
  totalPassagens++;
}
Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");

    //usando do while
    totalPassagens = 0;
do
{
    Console.WriteLine("digite o valor de cada passagem (negativo para sair): ");
     valorPassagens = Convert.ToDouble(Console.ReadLine());
    if (valorPassagens >= 0) totalPassagens++;
}
while (valorPassagens >= 0);
Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");

// usando for 
valorPassagens = 0;
for (; ; )
{
    Console.WriteLine("digite o valor de cada passagem (negativo para sair): ");
    valorPassagens = Convert.ToDouble(Console.ReadLine());
    if (valorPassagens < 0) break;
   totalPassagens++;
}
Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");


 