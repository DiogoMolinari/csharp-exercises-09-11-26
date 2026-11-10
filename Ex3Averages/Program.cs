/*Exercício 3: Faça um programa que receba 4 notas de um aluno. Calcule a média aritmética e informe o status baseado nas seguintes condições: Aprovado se a média for maior
 ou igual a 7; Recuperação se a média for entre 5.1 e 6.9; Reprovado se a média for menor ou igual a 5.*/

float grade1 = 0;
float grade2 = 0;
float grade3 = 0;
float grade4 = 0;
float average = 0;

Console.Write("Digite um número: ");
grade1 = float.Parse(Console.ReadLine());

Console.Write("Digite um número: ");
grade2 = float.Parse(Console.ReadLine());

Console.Write("Digite um número: ");
grade3 = float.Parse(Console.ReadLine());

Console.Write("Digite um número: ");
grade4 = float.Parse(Console.ReadLine());

average = (grade1 + grade2 + grade3 + grade4) / 4;
Console.Write("Sua média final foi: " +  average + "\n"); 


if (average >= 7)
    Console.Write("Parabéns, você foi aprovado!");
else if (average > 5 && average < 7)
    Console.Write("Você está de recuperação.");
else
    Console.Write("Você foi reprovado.");