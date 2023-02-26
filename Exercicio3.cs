using System;

class Exercicio3 {
    static void Main(string[] args) {
        int numPessoas = 10;
        int soma = 0;

        for (int i = 1; i <= numPessoas; i++) {
            Console.WriteLine("Digite a nota da Pessoa " + i + " :");
            int idade = int.Console.ReadLine();
            if (idade > 18){
                soma += 1;
            }
        }
        Console.WriteLine("O número de pessoas com mais de 18 é: " + soma);
    }
}
    