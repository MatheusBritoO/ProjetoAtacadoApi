using Atacado.Business.Ancestral;
using Atacado.Poco.RH;

namespace Atacado.Business.RH
{
    /// <summary>
    /// 
    /// </summary>
    public class FuncionarioRegra :RuleAncestor<FuncionarioPoco>, IRule
    {
        public FuncionarioRegra() : base()
        { }
        public FuncionarioRegra(FuncionarioPoco poco) : base(poco)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public override bool Process()
        {
     
            bool resultado = true;        
            string mensagemProcessamento = string.Empty;
           
            if(RegrasGenericas.NomeRegra(this.poco.Nome, ref mensagemProcessamento) == false)
            {
                this.ruleMessages.Add(mensagemProcessamento);
                resultado = false;
            }


            if (RegrasGenericas.SobrenomeRegra(this.poco.Sobrenome, ref mensagemProcessamento) == false)
            {
                this.ruleMessages.Add(mensagemProcessamento);
                resultado = false;
            }
           
            if (RegrasGenericas.SexoRegra(this.poco.Sexo, ref mensagemProcessamento) == false)
            {
                this.ruleMessages.Add(mensagemProcessamento);
                resultado = false;
            }
            if (RegrasGenericas.EmailRegra(this.poco.Email, ref mensagemProcessamento) == false)
            {
                this.ruleMessages.Add(mensagemProcessamento);
                resultado = false;
            }
            return resultado;

        }
   
    }
}
