using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Estoque;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapper.Estoque
{
    public class ProdutoMapper : BaseAncestralMapper
    {
        public ProdutoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoPoco>();

                cfg.CreateMap<ProdutoPoco, Produto>();

            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
