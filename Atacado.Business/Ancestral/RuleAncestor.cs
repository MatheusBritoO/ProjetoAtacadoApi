using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Business.Ancestral
{
    public class RuleAncestor<TPoco> : IRule where TPoco : class
    {
        protected List<string> ruleMessages;
        protected TPoco poco;


        public List<string> RuleMessages => this.ruleMessages;
        public TPoco Poco
        {
            set => this.poco = value;
        }

        public RuleAncestor()
        { 
            this.ruleMessages = new List<string>();
        }

        public RuleAncestor(TPoco poco)
        {
            this.ruleMessages = new List<string>();
            this.poco = poco;

        }

        public virtual bool Process()
        {
            throw new NotImplementedException();
        }
    }
}
