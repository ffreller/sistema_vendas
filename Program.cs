using System;
using System.IO;

namespace sistema_vendas
{class Program

    {static void Main(string[] args)
        {string opcao1 = "";

        do
            
            {Console.WriteLine("Digite a opção");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Realizar Venda");
            Console.WriteLine("4 - Extrato Cliente");
            Console.WriteLine("9 - Sair");
            opcao1 = Console.ReadLine();
            
            switch(opcao1)
            
                {case "1": CadastrarCliente cliente1 = new CadastrarCliente();
                         cliente1.Cadastrarcliente(); 
                break;
                case "2":CadastrarProduto produto1 = new CadastrarProduto();
                         produto1.Cadastrarproduto();   
                break;
                case "3":RealizarVenda venda1 = new RealizarVenda();
                         venda1.Realizarvenda();   
                break;
                case "4": ExtratoCliente extrato1 = new ExtratoCliente();
                         extrato1.Extratocliente(); 
                break;
                case "9":
                        {Console.WriteLine("Deseja realmente sair(s ou n)");
                        string sair = Console.ReadLine();
                        if(sair.ToLower().Contains("s"))
                            Environment.Exit(0);
                        else if(!sair.ToLower().Contains("n"))    
                            {opcao1 = "0";
                            Console.WriteLine("Opção Inválida");
                            }
                        else
                            {opcao1 = "0";
                            }
                        }                 
                             
                break;
            }
        }
        while (opcao1 != "9");
        }
    } 
}       