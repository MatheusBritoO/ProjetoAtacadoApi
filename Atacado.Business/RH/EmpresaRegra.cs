using Atacado.Business.Ancestral;
using Atacado.Poco.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Business.RH
{
    public class EmpresaRegra : RuleAncestor<EmpresaPoco>, IRule
    {
        public EmpresaRegra(EmpresaPoco poco) : base(poco)
        {
        }
        public override bool Process()
        {
            return base.Process();
        }
    }
}
