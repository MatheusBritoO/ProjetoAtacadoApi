using Atacado.Mapper.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public abstract class BaseAncestralService<TPoco, TDom> 
        where TPoco : class
        where TDom : class
   
    {
        protected MapeadorGenerico<TPoco, TDom> mapeador;
    
        public virtual List<TPoco> Listar()
        {
            throw new NotImplementedException();
        }
        
        public virtual TPoco Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    
        
        public virtual TPoco Criar(TPoco obj)
        {
            throw new NotImplementedException();
        }

        public virtual TPoco Atualizar(TPoco obj)
        {
            throw new NotImplementedException();
        }
    
        public virtual TPoco Excluir (TPoco obj)
        {
            throw new NotImplementedException();
        }
        public virtual TPoco Excluir(int id)
        {
            throw new NotImplementedException();
        }

        protected virtual List<TPoco> ProcessarListaDOM(List<TDom> listDOM)
        {
            throw new NotImplementedException();
        }
    }
}
