using System;
using System.Windows.Forms;


public static class Validacoes
{ 
    public static bool ValidaCPF(string cpf)
    {
        //Alteração para verificar git e github//
        //Alteração 2 - verificar//
        //se eu quiser adicionar mensagens aqui: MessageBox.Show();

        cpf = cpf.Replace(".", "");//remove os pontos do cpf
        cpf = cpf.Replace("-", "");//remove os traços do cpf


        if (cpf.Length == 11)//se for diferente(!=) já para e retorna false
        {
            int soma1 = 0;
            int cont1 = 10;

            for(int i = 0; i < 9; i++)//xxx.xxx.xxx-00
            {
                
                soma1 += Convert.ToInt32(cpf[i].ToString()) * cont1 ;
                cont1--;
            }

            //digito verificador 1

            int digito1 = soma1 % 11;

            if (digito1 < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - digito1;
            }

            //dígito 1 é igual ao cálculo? Não? INVALIDO
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }

            ////////////////////////////////////////////////////////           
            int soma2 = 0;
            int cont2 = 11;

            for (int i = 0; i < 10; i++)//xxx.xxx.xxx-x0
            {
                soma2 += Convert.ToInt32(cpf[i].ToString()) * cont2;
                cont2--;
            }

            //dígito verificador 2          
                  
            int digito2 = soma2 % 11;

            if (digito2 < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - digito2;
            }

            //dígito 2 é igual ao cálculo? Não? INVALIDO
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
            {
                return false;
            }

            //se tudo der certo o cpf é valido!! FINALMENTE CONGRATULATIONS                  
            return true;
        }
        else
        {          
            return false;          
        }
    }                  
}


