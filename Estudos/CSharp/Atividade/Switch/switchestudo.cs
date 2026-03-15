using System;

namespace CSharp
{
	public class switchestudo
	{
		public static void Main2(string[] args)
		{
		  // testando a função "Random"
		  Random aleatorio = new Random();
		  int cassino = aleatorio.Next(1,6);
			Console.WriteLine(cassino);
			
			// aprendendo swtich
			bool sucesso;
			int x;
			const double pocaoVida = 25.15;
			const double espadaAco = 150.25;
			const double escudoAco = 75.50;
			double carrinhoValor = 0;
			
			Console.WriteLine("Boas-vindas a lojinha!");
			Console.WriteLine("Estamos vendendo alguns itens!");
			Console.WriteLine("[1] Pocao de Vida [2] Espada de Aco [3] Escudo de Aco [0] Ir para o checkout/desistir.");
			
			    do
			{
			    do
			    {
			   sucesso = int.TryParse(Console.ReadLine(), out x);
			   if(!sucesso)
			   {
			     Console.WriteLine("Escreva um numero valido!");
			   }
			   }
			while(!sucesso);
			  switch(x)
			{
			  case 1:
			  carrinhoValor = carrinhoValor + 25.99;
			  Console.WriteLine("Voce adicionou ao carrinho uma Pocao de Vida!");
			  Console.WriteLine("Valor no carrinho total: R$"+ carrinhoValor);
			  Console.WriteLine("[1] Pocao de Vida [2] Espada de Aco [3] Escudo de Aco [0] Ir para o checkout/desistir.");
			  break;
			  
			  case 2:
			  carrinhoValor = carrinhoValor + 150.35;
			  Console.WriteLine("Voce adicionou ao carrinho uma Espada de Aco!");
			  Console.WriteLine("Valor no carrinho total: R$"+ carrinhoValor);
			  Console.WriteLine("[1] Pocao de Vida [2] Espada de Aco [3] Escudo de Aco [0] Ir para o checkout/desistir.");
			  break;
			  
			  case 3:
			  carrinhoValor = carrinhoValor + 75.50;
			  Console.WriteLine("Voce adicionou ao carrinho um Escudo de Aco!");
			  Console.WriteLine("Valor no carrinho total: R$"+ carrinhoValor);
			  Console.WriteLine("[1] Pocao de Vida [2] Espada de Aco [3] Escudo de Aco [0] Ir para o checkout/desistir.");
			  break;
			  
			  case 0:
			  break;
			  
			  default:
			  Console.WriteLine("Digite um numero de 1-3!");
			  break;
			}
			
			}
			while(x != 0);
			
			int c = 0;
			bool confirmar;
			
			Console.WriteLine("[1] Confirmar pagamento [2] Sair da lojinha.");
			
			do
			{
			do
			{
			   confirmar = int.TryParse(Console.ReadLine(), out c);
			   if(!confirmar)
			   {
			     Console.WriteLine("Escreva um numero valido!");
			   }
			}
			while(!confirmar);
			
			switch(c)
			{
			  case 1:
			  Console.WriteLine("Pagamento confirmado!");
			  Console.WriteLine($"Valor gasto: R$"+ carrinhoValor);
			  break;
			  
			  case 2:
			  Console.WriteLine("Voce saiu da lojinha!");
			  break;
			  
			  default:
			  Console.WriteLine("Digite um numero de 1-2!");
			  break;
			}
			}
			while(c != 1 && c != 2);
		}
	}
}