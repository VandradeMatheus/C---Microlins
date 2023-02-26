using System;

class Exercicio4 {
    static void Main(string[] args)
    {
        int numFuncionario = 10;

        for (int i = 1; i <= numFuncionario; i++)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("Digite o salário do Funcionário " + i + ":");
            float salario = float.Parse(Console.ReadLine());

            if (salario <= 300)
            {
                double reajuste = salario * 0.5;
                float valor_para_reajuste = (float)reajuste;
                float salario_reajustado = salario + valor_para_reajuste;
                Console.WriteLine("O salário do Funcionário " + i + " com reajuste é de: " + salario_reajustado);
            }
            else
            {
                double reajuste = salario * 0.3;
                float valor_para_reajuste = (float)reajuste;
                float salario_reajustado = salario + valor_para_reajuste;
                Console.WriteLine("O salário do Funcionário " + i + " com reajuste é de: " + salario_reajustado);
            }

        }
    }
}