using System;
using System.Collections.Generic;

namespace CompraModels
{
    public class Vendas
    {
        // Dictionary maps option numbers to products - easier to maintain than hardcoded if-else
        private readonly Dictionary<int, Produto> geladeiras = new()
        {
            { 1, new Produto("Geladeira Consul Duplex", 2600m) },
            { 2, new Produto("Geladeira Eletrolux Frost Free", 3200m) },
            { 3, new Produto("Geladeira Eletrolux Inverse", 4200m) }
        };

        private readonly Dictionary<int, Produto> lavadoras = new()
        {
            { 1, new Produto("Lavadora Eletrolux 12kg", 1900m) },
            { 2, new Produto("Lavadora Consul 12kg", 1700m) },
            { 3, new Produto("Lava e Seca LG 12 kg", 4300m) }
        };

        private readonly Dictionary<int, Produto> microondas = new()
        {
            { 1, new Produto("Micro-ondas Eletrolux", 578m) },
            { 2, new Produto("Micro-ondas Philco", 668m) },
            { 3, new Produto("Micro-ondas Midea", 450m) }
        };

        // Loop instead of recursion prevents stack overflow
        public void IniciarVendas()
        {
            Console.WriteLine("Bem-vindo à nossa loja!");
            
            bool continuar = true;
            while (continuar)
            {
                ExibirMenuPrincipal();
                continuar = ProcessarOpcaoMenuPrincipal();
                Console.WriteLine();
            }
            
            Console.WriteLine("Obrigado pela visita!");
        }

        private void ExibirMenuPrincipal()
        {
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.WriteLine("Escolha o produto que deseja comprar:");
            Console.WriteLine("1 - Geladeiras");
            Console.WriteLine("2 - Lavadoras");
            Console.WriteLine("3 - Microondas");
            Console.WriteLine("4 - Sair");
            Console.Write("Digite sua opção: ");
        }

        // Switch expression replaces nested if-else statements
        private bool ProcessarOpcaoMenuPrincipal()
        {
            // ?. and ?? handle null input safely
            string opcao = Console.ReadLine()?.Trim() ?? "";
            
            return opcao switch
            {
                "1" => ProcessarCategoria("Geladeiras", geladeiras),
                "2" => ProcessarCategoria("Lavadoras", lavadoras),
                "3" => ProcessarCategoria("Microondas", microondas),
                "4" => false, // Exit program
                _ => TratarOpcaoInvalida() // Default case for invalid input
            };
        }

        // Generic method works for any category - eliminates code duplication
        private bool ProcessarCategoria(string nomeCategoria, Dictionary<int, Produto> produtos)
        {
            while (true)
            {
                ExibirProdutos(nomeCategoria, produtos);
                string opcao = Console.ReadLine()?.Trim() ?? "";

                // Check if user wants to return to main menu
                if (opcao == (produtos.Count + 1).ToString())
                {
                    return true;
                }

                // TryParse safely converts string to int without exceptions
                if (int.TryParse(opcao, out int escolha) && produtos.ContainsKey(escolha))
                {
                    var produto = produtos[escolha];
                    if (ProcessarCompra(produto))
                    {
                        return false; // Exit after purchase
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                }
            }
        }

        private void ExibirProdutos(string categoria, Dictionary<int, Produto> produtos)
        {
            Console.WriteLine($"=== {categoria.ToUpper()} ===");
            
            // Loop through dictionary entries (key-value pairs)
            foreach (var kvp in produtos)
            {
                var produto = kvp.Value;
                // :C formats as currency (R$ 1.000,00)
                Console.WriteLine($"{kvp.Key} - {produto.Nome} — {produto.Preco:C}");
            }
            
            Console.WriteLine($"{produtos.Count + 1} - Voltar ao Menu Principal");
            Console.Write("Digite sua opção: ");
        }

        // Single method handles all purchase confirmations - DRY principle
        private bool ProcessarCompra(Produto produto)
        {
            Console.WriteLine($"\nVocê escolheu: {produto.Nome} — {produto.Preco:C}");
            Console.Write("Deseja finalizar sua compra? (S/N): ");
            
            string resposta = Console.ReadLine()?.Trim().ToUpper() ?? "";
            
            if (resposta == "S")
            {
                FinalizarCompra(produto);
                return true;
            }
            
            Console.WriteLine("Compra cancelada. Retornando ao menu...\n");
            return false;
        }

        private void FinalizarCompra(Produto produto)
        {
            Console.WriteLine($"\n✅ COMPRA FINALIZADA!");
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Valor: {produto.Preco:C}");
            Console.WriteLine("Obrigado por comprar conosco!");
            // ReadKey pauses until user presses any key
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private bool TratarOpcaoInvalida()
        {
            Console.WriteLine("Opção inválida. Tente novamente.\n");
            return true;
        }
    }

    // Simple product class - better than tuples for readability
    public class Produto
    {
        // Get-only properties prevent accidental changes after creation
        public string Nome { get; }
        public decimal Preco { get; } // decimal for accurate money calculations

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}