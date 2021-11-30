using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine -> escreve algo na tela

            /*
            várias
            linhas
            */

            /*
            // Variáveis -> Guardam na memória RAM
            // 1ª - tipo da informação (em alguns casos, podemos substituir por 'var')
            // 2ª - o que aquela informação representa
            // 3ª - a informação em si
            */

            // instrução finaliza com ';'
            //String - "aspas duplas"

            
            //Exemplo 1            
            /*
            string nome = "Meu Nome";
            Console.WriteLine(nome);
            */

            // Exemplo 2

            /*
            string nome = "Nome";
            string sobrenome = "Sobrenome";
            
            Console.WriteLine(nome + " " + sobrenome);
            */

            // Exemplo 3
            // Formatação de strings

            /*
            string nome = "Nome";
            string sobrenome = "Sobrenome";
            string nomeCompleto = $"Olá, {nome} {sobrenome}!";
            Console.WriteLine(nomeCompleto);
            */

            // Exemplo 4
            /*
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}!");
            */
            // Exemplo 5

            var nome = "Nome";
            var idade = 00;
            var altura = 0.0;

            Console.WriteLine($"$Olá, {nome}, você possui {idade} anos de idade e mede {altura}cm.");

            var soma = 10 + 5;

            Console.WriteLine($"10 + 5 = {soma}");

            

            // Desafio 1
            // Calculadora com 10% do garçon
            // Valor da conta, valor da taxa adicional, resultado

            var valorConta = 45.35;
            var taxaGarcon = 0.1 * valorConta;
            var contaTotal = valorConta + taxaGarcon;

            Console.WriteLine($"Valor: R{valorConta:C}, Taxa: R{taxaGarcon:C}, Total: {contaTotal:C}.");

            /*
            Desafio para depois:

            Nome: Catapulta
            Objetivo: Receber o número de baterias e duração da bateria e calcular a quantidade de pedras que a catapulta irá soltar.
            Dificuldade: Principiante

            1 - Uma catapulta lançou 300 pedras em 5 baterias de 15 minutos, cada.

            2 - Quantas pedras ela lançaria em 8 baterias de 7 minutos, cada?

            3 - Crie um programa que receba os valores base para que a aplicação funcione de forma que, se alterarmos o número de baterias e a duração de cada bateria, o programa funcione sem precisar de mais modificações.

            */
        }
    }
}
