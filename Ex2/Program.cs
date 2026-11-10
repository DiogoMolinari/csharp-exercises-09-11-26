//Exercício 2: Faça um programa e informe dois números decimais e informe se eles são maior, menor ou iguais. 

float number1 = 0;
float number2 = 0;


Console.Write("Digite um número: ");
number1 = float.Parse(Console.ReadLine());

Console.Write("Digite um número: ");
number2 = float.Parse(Console.ReadLine());

if (number1 > number2)
    Console.Write(number1 + " é maior que " + number2);
else if (number1 < number2)
    Console.Write(number1 + " é menor que " + number2);
else
    Console.Write(number1 + " e " + number2 + " são iguais");

