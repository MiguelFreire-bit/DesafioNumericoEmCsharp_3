/*Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para 
que você desenvolva um programa que calcule e imprima a média semestral. Faça com que o algoritmo só 
aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada 
separadamente.*/

using System;

class minhaClasse
{

    static void Main(string[] args)
    {
        double nota1;
        double nota2;
        double media;
        do
        {
            nota1 = double.Parse(Console.ReadLine());
            if ((nota1 > 10 || nota1 < 0))
            {
                Console.WriteLine("nota invalida");
            }
        }

        while ((nota1 > 10 || nota1 < 0));
        do
        {
            nota2 = double.Parse(Console.ReadLine());
            if ((nota2 > 10 || nota2 < 0))
            {
                Console.WriteLine("nota invalida");
            }
        }

        while ((nota2 > 10 || nota2 < 0));

        media = ((nota1 + nota2) / 2);
        Console.WriteLine("media = " + (media).ToString("N2"));



    }


}