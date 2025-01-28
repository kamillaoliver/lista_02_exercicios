/* ex.01 - Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. Para isso, ele deve inserir
os dias trabalhados (de 1 a 31) até que  digite 0, que indica que terminou de informar os dias. O aluno deve
implementar, essa contagem  utilizando as estruturas de repetição while, do while e for.*/

//usando while
int diasTrabalhados = 0;
int dia;
Console.WriteLine("Digite os dias trabalhados (0 para sair)");

while (true)
{
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia == 0) break;
    diasTrabalhados++;
}
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");

//usando do while
diasTrabalhados = 0;

do
{
    Console.WriteLine("Digite os dias trabalhados (0 para sair)");
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia != 0) diasTrabalhados++;
}
while(dia != 0);
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");

// usando for
diasTrabalhados = 0;

for (; ; )
{
    Console.WriteLine("Digite os dias trabalhados (0 para sair)");
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia == 0) break;
    diasTrabalhados++;
}
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");
