//Exercício 7: Faça um programa que receba o peso (em kg) e a altura (em cm) de uma pessoa e calcule o IMC. Com base no resultado, exiba a faixa correspondente.

Console.Write("Este programa faz o cálculo do IMC de adultos (19 anos para cima) O cálculo para menores possui outros valores de referência. \n \n");

float weight = 0;
int height = 0;
float heightConverted = 0;
float imc = 0;
int age = 0;

Console.Write("Por gentileza, digite seu peso (em kg): ");
weight = float.Parse(Console.ReadLine());
Console.Write("\n");

Console.Write("Agora, por gentileza, digite sua altura (em cm): ");
height = int.Parse(Console.ReadLine());
heightConverted = (float)height / 100;
Console.Write("\n");

Console.Write("Agora, por gentileza, digite sua idade: ");
age = int.Parse(Console.ReadLine());
Console.Write("\n");

imc = weight / (heightConverted * heightConverted);

if (age > 18 && age < 60)
    if (imc < 16.0)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Magreza grave.");
    else if (imc >= 16.0 && imc <= 16.9)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Magreza moderada.");
    else if (imc >= 17.0 && imc <= 18.4)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Magreza leve.");
    else if (imc >= 18.5 && imc <= 24.9)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Peso normal.");
    else if (imc >= 25.0 && imc <= 29.9)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Sobrepeso.");
    else if (imc >= 30.0 && imc <= 34.9)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Obesidade grau I.");
    else if (imc >= 35.0 && imc <= 39.9)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Obesidade grau II.");
    else
        Console.Write("Seu IMC é de " + imc + " e está classificado como Obesidade grau III.");
else if (age > 59)
    if (imc < 22.0)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Baixo peso.");
    else if (imc >= 22.0 && imc <= 27)
        Console.Write("Seu IMC é de " + imc + " e está classificado como Adequado.");
    else
        Console.Write("Seu IMC é de " + imc + " e está classificado como Sobrepeso.");
else
    Console.Write("Sua idade é inferior a 19 anos, procure um profissional da saúde para realizar o cálculo do seu IMC com base na tabela da OMS.");
