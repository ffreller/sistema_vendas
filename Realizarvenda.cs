using System;
using System.IO;
    
public class RealizarVenda
{
    public void Realizarvenda()
    
    {   Console.WriteLine("Pessoa física (digite 1), pessoa jurídica (digite 2)");
        string opcao2 = Console.ReadLine();
        bool cpfencontrado = false;
        bool cnpjencontrado = false;
        bool codigoencontrado = false;
        string linhacliente = "";
        switch(opcao2)
        {
            case "1":{
                    Console.WriteLine("Digite seu CPF");
                    string cpfvenda = Console.ReadLine();     
                    string[] linhas = File.ReadAllLines("Cadastro.txt");
                    foreach(string linha in linhas)
                    {
                        if(linha.Contains(cpfvenda) == true)
                        {
                            cpfencontrado = true;
                            linhacliente = linha;
                            break;
                        }
                        else
                        {
                            cpfencontrado = false;
                    
                        }            
            }
            break;
            }
            
            case "2":{ 
                    Console.WriteLine("Digite seu CNPJ");
                    string cnpjvenda = Console.ReadLine();     
                    string[] linhas = File.ReadAllLines("Cadastro.txt");
                    foreach(string linha in linhas)
                    {
                        if(linha.Contains(cnpjvenda) == true)
                        {
                            cnpjencontrado = true;
                            linhacliente = linha;
                            break;
                        }
                        else
                        {
                            cnpjencontrado = false;
                        }
                    }            
            break;
                    }
        } 
            
        if(cpfencontrado == true||cnpjencontrado == true)
        {
            string[] produtos = File.ReadAllLines("Cadastroproduto.txt");
            foreach(string produtovenda in produtos)
            {
                Console.WriteLine(produtovenda);
            }

            Console.WriteLine("Digite o código do produto");
            string codigoproduto = Console.ReadLine();
                    
            StreamWriter cadastrovendas = new StreamWriter ("Cadastrovendas.txt", true);
            FileInfo cabecalho = new FileInfo("Cadastrovendas.txt");
            if(cabecalho.Length == 0)
            {
                cadastrovendas.WriteLine ("NOME DO CLIENTE; E-MAIL; CPF DO CLIENTE; DATA E HORA DO CADASTRO; NOME DO PRODUTO; CÓDIGO DO PRODUTO; DESCRIÇÃO DO PRODUTO; PREÇO; DATA DA COMPRA;");
            }
                   
            foreach(string linhaproduto in produtos)
            {
                if(linhaproduto.Contains(codigoproduto) == true)
                {
                    cadastrovendas.WriteLine(linhacliente + ";" + linhaproduto + DateTime.Now + ";");
                    cadastrovendas.Close();
                    Console.WriteLine("Produto comprado com sucesso");
                    codigoencontrado = true;
                    break;
                } 
                                  
            }

            if(codigoencontrado == false)
            {
                Console.WriteLine("Código inválido");
            }
        }
        else
        {
            Console.WriteLine("CPF Inválido");
            CadastrarCliente cliente1 = new CadastrarCliente();
            cliente1.Cadastrarcliente();
        }
    }
}