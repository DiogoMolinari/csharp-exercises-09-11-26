//Exercício 5: Faça um programa que leia o ano informado pelo usuário e mostra se foi ou é um ano bissexto.

int year = 0;

Console.Write("Digite o ano que deseja saber se é bissexto: ");
year = int.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    Console.Write("O ano escolhido é bissexto.");
else
    Console.Write("O ano escolhido não é bissexto.");