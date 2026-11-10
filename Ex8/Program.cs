/*Exercício 8: Faça um programa que baseado no salário informado calcule o aumento salarial de acordo com as regras a seguir:
até 2.000 - aumento de 15%; entre 2.000,01 até 4.000 - aumento de 10%; acima de 4.000 - aumento de 5%.*/

float salary = 0;

Console.Write("Para descobrir a % de aumento que terá, digite seu salário: \n");
salary = float.Parse(Console.ReadLine());

if (salary <= 2000)
    Console.WriteLine("Parabéns, você terá um aumento de 15%! Seu sálário era de " + salary + " e agora você receberá " + salary * 1.15);
else if (salary > 2000 && salary <= 4000)
    Console.WriteLine("Parabéns, você terá um aumento de 10%! Seu sálário era de " + salary + " e agora você receberá " + salary * 1.10);
else
    Console.WriteLine("Parabéns, você terá um aumento de 5%! Seu sálário era de " + salary + " e agora você receberá " + salary * 1.05);
