//Exercício 4: Faça um programa que receba 2 números e executa as 4 operações básicas matemáticas.

float number1 = 0;
float number2 = 0;
float addition = 0;
float subtraction = 0;
float multiplication = 0;
float division = 0;

Console.Write("Digite um número: ");
number1 = float.Parse(Console.ReadLine());

Console.Write("Digite outro número: ");
number2 = float.Parse(Console.ReadLine());


addition = number1 + number2;
Console.Write("Resultado da adição: " + addition + "\n");

subtraction = number1 - number2;
Console.Write("Resultado da subtração: " + subtraction + "\n");

multiplication = number1 * number2;
Console.Write("Resultado da multiplicação: " + multiplication + "\n");

if (number2 != 0)
    Console.Write("Resultado da divisão: " + (division = number1 / number2) + "\n");
else
    Console.Write("Não é possível realizar divisões por 0");
