using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CompraModels
{
    public class Vendas

    {
        public string Geladeira { get; set; } = string.Empty;
        public string Lavadora { get; set; } = string.Empty;
        public string MicroOndas { get; set; } = string.Empty;

        public void MenuComprar()
        {
            Menu();
            string opcao = Console.ReadLine()!;
            if (opcao == "1")
            {
                Geladeiras();
                string opcaoGeladeira = Console.ReadLine()!;
                if (opcaoGeladeira == "1")
                {
                    Console.WriteLine("Você escolheu a Geladeira Consul Duplex – R$ 2.600");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }

                }
                else if (opcaoGeladeira == "2")
                {
                    Console.WriteLine("Você escolheu a Geladeira Eletrolux Frost Free – R$ 3.200");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }
                }
                else if (opcaoGeladeira == "3")
                {
                    Console.WriteLine("Você escolheu a Geladeira Eletrolux Inverse – R$ 4.200");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }
                }
                else if (opcaoGeladeira == "4")
                {
                    MenuComprar();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    MenuComprar();
                }
            }
            else if (opcao == "2")
            {
                Lavadoras();
                string opcaoLavadora = Console.ReadLine()!;
                if (opcaoLavadora == "1")
                {
                    Console.WriteLine("Você escolheu a Lavadora Eletrolux 12kg – R$ 1.900");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }

                }
                else if (opcaoLavadora == "2")
                {
                    Console.WriteLine("Você escolheu a Lavadora Consul 12kg – R$ 1.700");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }
                }
                else if (opcaoLavadora == "3")
                {
                    Console.WriteLine("Você escolheu a Lava e Seca LG 12 kg – R$ 4.300");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }
                }
                else if (opcaoLavadora == "4")
                {
                    MenuComprar();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    MenuComprar();
                }
            }
            else if (opcao == "3")
            {
                Microondas();
                string opcaoLavadora = Console.ReadLine()!;
                if (opcaoLavadora == "1")
                {
                    Console.WriteLine("Você escolheu o Micro-ondas Eletrolux – R$ 578");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }

                }
                else if (opcaoLavadora == "2")
                {
                    Console.WriteLine("Você escolheu o Micro-ondas Philco – R$ 668");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }
                }
                else if (opcaoLavadora == "3")
                {
                    Console.WriteLine("Você escolheu o Micro-ondas Midea – R$ 450");
                    Console.WriteLine("Você deseja finalizar sua compra? (S/N)");
                    string finalizarCompra = Console.ReadLine()!;
                    if (finalizarCompra?.ToUpper() == "S")
                    {
                        Console.WriteLine("Compra finalizada! Obrigado por comprar conosco.");
                    }
                    else
                    {
                        MenuComprar();
                    }
                }
                else if (opcaoLavadora == "4")
                {
                    MenuComprar();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    MenuComprar();
                }
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Saindo...");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                MenuComprar();
            }
        }

        private void Menu()
        {
            Console.WriteLine("Bem Vindo! \nEscolha o produto que deseja comprar: ");
            Console.WriteLine("1 - Geladeira");
            Console.WriteLine("2 - Lavadora");
            Console.WriteLine("3 - Microondas");
            Console.WriteLine("4 - Sair");
        }

        private void Geladeiras()
        {
            Console.WriteLine("Geladeiras: ");
            Console.WriteLine("1 - Geladeira Consul Duplex – R$ 2.600");
            Console.WriteLine("2 - Geladeira Eletrolux Frost Free – R$ 3.200");
            Console.WriteLine("3 - Geladeira Eletrolux Inverse – R$ 4.200");
            Console.WriteLine("4 - Menu Principal");
        }

        private void Lavadoras()
        {
            Console.WriteLine("Lavadoras: ");
            Console.WriteLine("1 - Lavadora Eletrolux 12kg – R$ 1.900");
            Console.WriteLine("2 - Lavadora Consul 12kg – R$ 1.700");
            Console.WriteLine("3 - Lava e Seca LG 12 kg – R$ 4.300");
            Console.WriteLine("4 - Menu Principal");
        }

        private void Microondas()
        {
            Console.WriteLine("Microondas: ");
            Console.WriteLine("1 - Micro-ondas Eletrolux – R$ 578");
            Console.WriteLine("2 - Micro-ondas Philco – R$ 668");
            Console.WriteLine("3 - Micro-ondas Midea – R$ 450");
            Console.WriteLine("4 - Menu Principal");
        }

    }

}