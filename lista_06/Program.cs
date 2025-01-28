/* Ex.06 - Durante uma eleição um mesário deve contar os votos. O aluno deverá pedir para que o usuário inserir os votos (1 para candidato A, 2 para candidato B)
até que ele digite 0. O programa deve contar os votos que cada candidato recebeu implementando a solução com 
while, do while e for.*/

// usando while 
using System;

int votosA = 0; int votosB = 0;
int voto;
Console.WriteLine("Digite os votos ( 1 para o candidato A e 2 para o candidato B, 0 para sair): ");
while (true)
{
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0) break;
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;
}
Console.WriteLine($"Candidato A: {votosA} votos. Candidato B: {votosB} votos.");

// usando do while
votosA = 0;
votosB = 0;
do
{
    Console.WriteLine("Digite os votos ( 1 para o candidato A e 2 para o candidato B, 0 para sair): ");
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0) break;
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;
}
while (voto != 0);
Console.WriteLine($"Candidato A: {votosA} votos. Candidato B: {votosB} votos.");

// usando for
votosA = 0;
votosB = 0;
for (; ;)
{
    Console.WriteLine("Digite os votos ( 1 para o candidato A e 2 para o candidato B, 0 para sair)");
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0) break;
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;

}
Console.WriteLine($"Candidato A: {votosA} votos. Candidato B: {votosB} votos.");