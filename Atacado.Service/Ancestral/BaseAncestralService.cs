using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public abstract class BaseAncestralService<TPoco> where TPoco : class
    {
        public virtual List<TPoco> Listar()
        {
            throw new NotImplementedException();
        }
        
        public virtual TPoco Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    
    }
}
