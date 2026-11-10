//Exercício 1: Faça um programa que receba um número inteiro e informe e ele é par ou ímpar.

int number = 0;


Console.Write("Digite um número: ");
number = int.Parse(Console.ReadLine());


if (number % 2 ==0)
        Console.Write("Seu número é par.");
else
        Console.Write("Seu número é ímpar.");


