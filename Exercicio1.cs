using System;

class Exercicio1 {
    static void Main(string[] args) {
        int numAlunos = 5;
        float soma = 0;

        for (int i = 1; i <= numAlunos; i++) {
            Console.Write("Digite a nota do aluno " + i + ": ");
            float nota = float.Parse(Console.ReadLine());
            soma += nota;
        }

        float media = soma  / numAlunos;
        Console.WriteLine("A média dos " + numAlunos + " alunos é: " + media);
    }
}