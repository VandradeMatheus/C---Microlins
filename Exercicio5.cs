using System;

class Exercicio5 {
    static void Main(string[] args)
    {
        int matriculaAlunoMaisAlto = 0;
        double alturaAlunoMaisAlto = 0;
        int matriculaAlunoMaisBaixo = 0;
        double alturaAlunoMaisBaixo = double.MaxValue;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Digite a matrícula do aluno " + i + ":");
            int matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do aluno " + i + ":");
            float altura = float.Parse(Console.ReadLine());

            if (altura > alturaAlunoMaisAlto)
            {
                alturaAlunoMaisAlto = altura;
                matriculaAlunoMaisAlto = matricula;
            }

            if (altura < alturaAlunoMaisBaixo)
            {
                alturaAlunoMaisBaixo = altura;
                matriculaAlunoMaisBaixo = matricula;
            }
        }

        Console.WriteLine("A matrícula do aluno mais alto é: " + matriculaAlunoMaisAlto);
        Console.WriteLine("A matrícula do aluno mais baixo é: " + matriculaAlunoMaisBaixo);
    }
}