using System;
using System.IO;
    
public class CadastrarCliente
{
    public void Cadastrarcliente(){
        Console.WriteLine("Cadastro");
        Console.WriteLine("Qual é seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual é seu e-mail?");
        string email = Console.ReadLine();
        Console.WriteLine("Pessoa física (digite 1), pessoa jurídica (digite 2)");
        string opcao2 = Console.ReadLine();
        switch(opcao2)
        
            {case "1":
                    bool cpfvalido = false; 
                    Console.WriteLine("Qual é seu CPF?");
                    string cpf = Console.ReadLine();
                    Validacao cliente1 = new Validacao();
                    cliente1.ValidarCPF(cpf);
                    cpfvalido = cliente1.ValidarCPF(cpf);
                    if (cpfvalido==true)
                    {
                        StreamWriter cadastro = new StreamWriter ("Cadastro.txt", true);
                        FileInfo cabecalho = new FileInfo("Cadastro.txt");
                        if(cabecalho.Length == 0)
                        {
                            cadastro.WriteLine ("NOME; E-MAIL; CPF/CNPJ; DATA E HORA");
                        }
                        cadastro.WriteLine(nome + ";" + email + ";" + cpf + ";" + DateTime.Now);
                        cadastro.Close();           
                    }
                    
            break;
            case "2":
                    bool cnpjvalido = false; 
                    Console.WriteLine("Qual é seu CNPJ?");
                    string cnpj = Console.ReadLine(); 
                    Validacao cliente2 = new Validacao();
                    cnpjvalido = cliente2.ValidarCNPJ(cnpj);
                    if (cnpjvalido==true)
                    {
                        StreamWriter cadastro = new StreamWriter ("Cadastro.txt", true);
                        FileInfo cabecalho = new FileInfo("Cadastro.txt");
                        if(cabecalho.Length == 0)
                        {
                            cadastro.WriteLine ("NOME; E-MAIL; CPF/CNPJ; DATA E HORA");
                        }
                        cadastro.WriteLine(nome + ";" + email + ";" + cnpj + ";" + DateTime.Now);
                        cadastro.Close();
                                                
                    }

            break;
            default: 
                    Cadastrarcliente();
            break;
            }
    }
}          