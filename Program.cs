using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Catapulta 
    
            Recebe:     o número de baterias (n) e a duração da bateria(d)
            Calcula:    o número de pedras (q) que a catapulta irá soltar
            
            Assim, q = f(n,d), em que f é uma função desconhecida qualquer calculada em 
            função de n e d.
            
            Considere que a catapulta funcione com uma bateria por vez e que seja 
            desprezível o tempo entre trocas de baterias. Seja t o tempo total de 
            funcionamento da catapulta, isto é, t = n * d. Assim, q = f(n, d) = f(t)
            
            Considere também que o lançamento de pedra pela catapulta seja diretamente
            proporcional ao tempo de funcionamento dela. Assim, q = f(t) = alfa * t, em 
            que alfa é uma constante de operação da catapulta, ou seja, a taxa do número 
            de pedras lançadas por minuto.
            
            Nota - Análise Dimensional: 
                [q]    = número de pedras
                [t]    = minutos
                
                Se [q] = [alfa] *[t], então [alfa] = [q]/[t] = número de pedras/ minutos
            
            A taxa alfa pode ser dada por qualquer relação q/t. Adote que n0, d0 e q0 
            sejam informações iniciais que se tem a sobre o funcionamento da catapulta.
            
            Assim,
            
            alfa = q0/t0 = q0 / (n0 * d0)
            
            Sabemos, a priori, que a catapulta lançou 300 pedras (q0) com 5 baterias (n0) 
            com duração 15 minutos cada (d0). Logo, alfa = 300 / (5 * 15) = 4 pedras/min
            
            Portanto,
            
            q = alfa * t = 4 * t = 4 * n * d
            */
            
            var alfa = 4;
            
            Console.WriteLine("Digite o número de baterias (n): ");
            //var nString = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"n = {n}");
            
            Console.WriteLine("Digite a duração da bateria (d): ");
            //var nString = Console.ReadLine();
            var d = int.Parse(Console.ReadLine());
            //Console.WriteLine($"d = {d}");
            
            Console.WriteLine($"A catapulta lançará {alfa * n * d} com {n} baterias de {d} minutos de duração cada");
            
            /*
            Caso queira trocar as configuração da catapulta, troque var alfa = 4; por:
            
            Console.WriteLine("Digite o número de pedras lançadas (q0): ");
            var n0 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o número de baterias (n0): ");
            var n0 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a duração da bateria (d0): ");
            var d0 = int.Parse(Console.ReadLine());
            
            alfa = q0 / (n0 * d0);
            */
        }
    }
}
