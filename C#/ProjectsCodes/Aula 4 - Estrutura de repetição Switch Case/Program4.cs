﻿class Program4{
    static void Main(string[] args)
    {
            Console.WriteLine("================================================================== ");

            Console.WriteLine("Bom dia! Digite o seu nome, caro investidor: \n");
            string? nomeInvestidor = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Olá, {nomeInvestidor} por gentileza digite o saldo de sua conta: ");
            double? saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("============================LÓGICA================================ =");

            double? desconto = (saldo / 100) * 0.05;
            // Console.WriteLine(desconto);

            double? valorFinal = saldo - desconto;
            // Console.WriteLine(valorFinal);

            Console.WriteLine("============================SAÍDA================================= =");

            Console.WriteLine("Deseja sacar o dinheiro? [S/N]");
            string? opc = Convert.ToString(Console.ReadLine());

            if(opc == "s" || opc == "S"){

                Console.WriteLine("Coloque o valor do saque: ");
                double? saldoInvestidor = Convert.ToDouble(Console.ReadLine());

                if(saldoInvestidor > valorFinal){
                    Console.WriteLine("Sua tentativa de saque ultrapassa seu saldo atual! Operação Anulada");

                }else{
                   double? saldoTotal = saldoInvestidor + valorFinal;
                        Console.WriteLine($"{nomeInvestidor} Saque atualizado com sucesso! Seu saldo atual é de R$: {saldoTotal}");
                }

            }else{
                Console.WriteLine("Operação Finalizada");
            }
            Console.WriteLine("================================================================== ");
    }
}
