/*Exercício 6: Faça um programa que leia a idade de uma pessoa e classifique-o de acordo com as regras:
crianças até 12 anos; adolescentes de 13 a 17; adultos de 18 a 59; idosos 60+.*/

int age = 0;

Console.Write("Digite sua idade: ");
age = int.Parse(Console.ReadLine());

if (age <= 12)
    Console.Write("Você é uma criança.");
else if (age > 12 && age < 18)
    Console.Write("Você é adolescente.");
else if (age > 17 && age < 60)
    Console.Write("Você é adulto.");
else
    Console.Write("Você está na melhor idade.");