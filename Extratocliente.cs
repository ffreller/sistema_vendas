using System;
using System.IO;
    
public class ExtratoCliente{
    public void Extratocliente(){
       {Console.WriteLine("Pessoa física (digite 1), pessoa jurídica (digite 2)");
        string opcao2 = Console.ReadLine();
        switch(opcao2)
            {
            case "1":
                bool cpfvalido = false; 
                Console.WriteLine("Qual é seu CPF?");
                string cpf = Console.ReadLine();
                Validacao cliente1 = new Validacao();
                cpfvalido = cliente1.ValidarCPF(cpf);
                if(cpfvalido == true)
                {
                    string[] compras = File.ReadAllLines("Cadastrovendas.txt");
                    foreach( string compra in compras)
                    {
                        if(compra.Contains(cpf))
                        {
                            Console.WriteLine(compra);
                        }
                    }
                }
                    break;
                    
            case "2":
                bool cnpjvalido = false; 
                Console.WriteLine("Qual é seu CNPJ?");
                string cnpj = Console.ReadLine(); 
                Validacao cliente2 = new Validacao();
                cliente2.ValidarCNPJ(cnpj);
                cnpjvalido = cliente2.ValidarCNPJ(cnpj);
                if(cnpjvalido == true)
                {
                    string[] compras = File.ReadAllLines("Cadastrovendas.txt");
                    foreach( string compra in compras)
                    {
                        if(compra.Contains(cnpj))
                        {
                            Console.WriteLine(compra);
                        }
                    }
                }
                    break;
                
            default: 
                    Extratocliente();
                    break;           
                
            }
        }
    } 
}        