/*Exercício 9: Faça um programa que receba o valor de três lados de um triângulo e informe o tipo do triângulo (equilátero, isósceles ou escaleno).
Obs.: os lados informados devem formar um triângulo.*/

float FirstSide = 0;
float SecondSide = 0;
float ThirdSide = 0;

Console.Write("Digite o valor do primeiro lado: ");
FirstSide = float.Parse(Console.ReadLine());

Console.Write("Digite o valor do segundo lado: ");
SecondSide = float.Parse(Console.ReadLine());

Console.Write("Digite o valor do terceiro lado: ");
ThirdSide = float.Parse(Console.ReadLine());

if (((FirstSide + SecondSide) > ThirdSide) && ((FirstSide + ThirdSide) > SecondSide) && ((SecondSide + ThirdSide) > FirstSide))
    if ((FirstSide != SecondSide) && (FirstSide != ThirdSide) && (SecondSide != ThirdSide))
        Console.Write("Seu triângulo é escaleno.");
    else if ((FirstSide == SecondSide) && (FirstSide != ThirdSide) || (FirstSide == ThirdSide) && (FirstSide != SecondSide) || (SecondSide == ThirdSide) && (SecondSide != FirstSide))
        Console.Write("Seu triângulo é isósceles.");
    else
        Console.Write("Seu triânculo é equilátero.");
else
    Console.Write("Os números passados não formam um triângulo.");

