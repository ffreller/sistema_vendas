using System;
using System.IO;
    
    public class CadastrarProduto{
    
        public void Cadastrarproduto()
        
            {Console.WriteLine("Qual o nome do produto?");
            string nomeproduto = Console.ReadLine();
            Console.WriteLine("Qual o código do produto?");
            string codigoproduto = Console.ReadLine();
            Console.WriteLine("Descrição do produto:");
            string descricaoproduto = Console.ReadLine();
            Console.WriteLine("Qual o preço do produto?");
            string precoproduto = Console.ReadLine();

            StreamWriter cadastroproduto = new StreamWriter ("Cadastroproduto.txt", true);
            cadastroproduto.Write(nomeproduto + ";" + codigoproduto + ";" + descricaoproduto + ";" + precoproduto + ";");
            cadastroproduto.Close();
            FileInfo cabecalho = new FileInfo("Cadastroproduto.txt");
            if(cabecalho.Length == 0)
            {
                cadastroproduto.WriteLine ("NOME DO PRODUTO; CÓDIGO DO PRODUO; DESCRIÇÃO DO PRODUTO; PREÇO;");
            }
        }
            }