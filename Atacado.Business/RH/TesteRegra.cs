using Atacado.Business.Ancestral;

namespace Atacado.Business.RH
{
    public class TesteRegra : IRule
    {

        private List<string> ruleMessages;
        public List<string> RuleMessages => this.ruleMessages;

        public TesteRegra()
        {
            this.ruleMessages = new List<string>();
        }
        public bool Process()
        {
            throw new NotImplementedException();
        }
        
        private bool Regra1()
        { 
            
        }

        private bool Regra2()
        { }

        private bool Regra3()
        { }

        private bool Regra4()
        { }

        private bool Regra5()
        { }

    }
}
