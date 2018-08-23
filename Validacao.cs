    using System;
    using System.IO;
    
    public class Validacao {   
        public bool ValidarCPF(string cpf){
       
            bool cpfvalido = false;
            if(cpf.Length != 11)
        
                {Console.WriteLine("CPF Inválido"); 
                return cpfvalido;         
                }
            if(cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222"
             || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555"
             || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999"){
                 return false;}

            else
        
                {int[] multiplicador1 = new int[]{10,9,8,7,6,5,4,3,2};
                int[] multiplicador2 = new int[]{11,10,9,8,7,6,5,4,3,2};
                string cpf9, cpf10, cpfult2, digito, digito1, digito2;
                int soma1=0, resto1=0, soma2=0, resto2=0;
                cpf9 = cpf.Substring(0,9);
                cpfult2 = cpf.Substring(9,2);

            for(int i = 0; i < 9; i++)
            
                {soma1 += Convert.ToInt16(cpf9[i].ToString()) * multiplicador1[i];                     
                }
            resto1 = soma1%11;

            if(resto1 < 2)
            
                {resto1 = 0;
                }
            else
            
                {resto1 = 11 - resto1;
                }
                
            digito1 = resto1.ToString();
            cpf10 = cpf9 + digito1;
                              
                
            for(int i=0;i<10;i++)
            
                {soma2 += Convert.ToInt32(cpf10[i].ToString()) * multiplicador2[i]; 
                }
                
            resto2 = soma2%11;

            if(resto2 < 2)
            
                {resto2 = 0;
                }
            else
            
                {resto2 = 11 - resto2;
                }

            digito2 = resto2.ToString();
            digito = digito1 + digito2;

            if(digito==cpfult2.ToString())
            
                {Console.WriteLine("CPF Válido");
                cpfvalido = true;}
                
            else
            
                {Console.WriteLine("CPF Inválido");      
                }
            return cpfvalido;
            }
    
            }
        
        public bool ValidarCNPJ(string cnpj)
 
            {bool cnpjvalido = false;
            
            if(cnpj.Length != 14)
            {
                Console.WriteLine("CNPJ Inválido");
                return cnpjvalido;
            }
            else
            {
                int[] multiplicador1 = new int[]{5,4,3,2,9,8,7,6,5,4,3,2};
                int[] multiplicador2 = new int[]{6,5,4,3,2,9,8,7,6,5,4,3,2};
                string cnpj12, cnpj13, cnpjult2, digito, digito1, digito2;
                int soma1=0, resto1=0, soma2=0, resto2=0;
                cnpj12 = cnpj.Substring(0,12);
                cnpjult2 = cnpj.Substring(12,2);

            for(int i = 0; i < 12; i++)
            {
                soma1 += Convert.ToInt16(cnpj12[i].ToString()) * multiplicador1[i];                     
            }

            resto1 = soma1%11;

            if(resto1 < 2)
            {
                resto1 = 0;
            }
            else
            {
                resto1 = 11 - resto1;
            }
                
            digito1 = resto1.ToString();
            cnpj13 = cnpj12 + digito1;
                              
                
            for(int i=0;i<13;i++)
            {
                soma2 += Convert.ToInt16(cnpj13[i].ToString()) * multiplicador2[i]; 
            }
                
            resto2 = soma2%11;

            if(resto2 < 2)
            {
                resto2 = 0;
            }
            else
            {
                resto2 = 11 - resto2;
            }

            digito2 = resto2.ToString();
            digito = digito1 + digito2;

            if(digito==cnpjult2.ToString())
            {
                Console.WriteLine("CNPJ Válido");
                cnpjvalido = true;
            }
            else
            {
                Console.WriteLine("CNPJ Inválido");
            }
            return cnpjvalido;
            }
        
        }

        }
    