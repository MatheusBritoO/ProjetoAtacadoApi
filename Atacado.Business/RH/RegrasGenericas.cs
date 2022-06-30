namespace Atacado.Business.RH
{       /// <summary>
        /// Regras génericas para uso em qualquer unidade de regra.
        /// </summary>
    public static class RegrasGenericas
    {
        /// <summary>
        /// Validar se o campo NOME esta vazio.
        /// </summary>
        /// <param name="nome">Campo que será validado.</param>
        /// <param name="mensagem">Mensagem que será exibida em caso de erro.</param>
        /// <returns>Retorna True se for bem sucediso, do contrário, retornará False.</returns>
        public static bool NomeRegra(string nome, ref string mensagem)
        {
            if (string.IsNullOrEmpty(nome) == true)
            {
               mensagem = ("Nome nao pode ser vazio.");
                return false;
            }
            else return true;
        }
        /// <summary>
        /// Validar se o campo SOBRENOME esta vazio.
        /// </summary>
        /// <param name="Sobrenome">Campo que será validado.</param>
        /// <param name="mensagem">Mensagem que será exibida em caso de erro.</param>
        /// <returns>Retorna True se for bem sucediso, do contrário, retornará False.</returns>
        public static bool SobrenomeRegra(string Sobrenome, ref string mensagem)
        {
            if (string.IsNullOrEmpty(Sobrenome) == true)
            {
                mensagem = ("Sobrenome nao pode ser vazio.");
                return false;
            }
            else return true;
        }
        /// <summary>
        /// Validar se o campo SEXO esta vazio, ou no formato correto.
        /// </summary>
        /// <param name="sexo">Campo que será validado.</param>
        /// <param name="mensagem">Mensagem que será exibida em caso de erro.</param>
        /// <returns>Retorna True se for bem sucediso, do contrário, retornará False.</returns>
        public static bool SexoRegra(string sexo, ref string mensagem)
        {
            if (string.IsNullOrEmpty(sexo) == true)
            {
                mensagem = ("Sexo nao pode ser vazio.");
                return false;
            }
            else if ((sexo.Contains("F") == false) && (sexo.Contains("M") == false))
            {
                mensagem = ("Sexo deve conter a letra F ou M.");
                return false;
            }

            else return true;
        }
        /// <summary>
        /// Validar se o campo EMAIL esta vazio.
        /// - Regra para campo de e-mail vazio.
        /// - Regra de formato do e-mail.
        /// </summary>
        /// <param name="email">Campo que será validado.</param>
        /// <param name="mensagem">Mensagem que será exibida em caso de erro.</param>
        /// <returns>True se for bem sucediso, do contrário, retornará False</returns>
        public static bool EmailRegra(string email, ref string mensagem)
        { 
             if (EmailVazioRegra(email, ref mensagem) == false)
             {
                return false;
             }
             if (EmailFormatoRegra(email,ref mensagem) == false)
             {
                return false;
             }
             else
             {
                return true;
             }
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="mensagem"></param>
        /// <returns></returns>
        private static bool EmailVazioRegra(string email, ref string mensagem)
        {         
            
                if (string.IsNullOrEmpty(email) == true)
                {
                    mensagem = ("Email nao pode ser vazio.");
                    return false;
                }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="mensagem"></param>
        /// <returns></returns>
        private static bool  EmailFormatoRegra(string email, ref string mensagem)
        {
            bool ValidEmail = false;
            int indexArr = email.IndexOf("@");

            if (indexArr > 0)
            {
                int indexDot = email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
           if (ValidEmail == false)
            {
                mensagem = "Email em formato inválido.";
            }
            return ValidEmail;
        }
    
    }
}
