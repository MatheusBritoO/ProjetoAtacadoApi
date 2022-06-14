using Atacado.Poco.Estoque;
using Atacado.EF.Database;
using Atacado.Mapper.Estoque;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Estoque
{
    public class CategoriaService
    {
        private CategoriaMapper map;

        public CategoriaService()
        {
            this.map = new CategoriaMapper();
        }

        public void Testar(CategoriaPoco poco)
        {
            Categoria dom = new Categoria();
            dom = this.map.Mapper.Map<Categoria>(poco);
        }
    }
}
