using Atacado.Mapper.Ancestral;
using Atacado.EF.Database;
using Atacado.Poco.Estoque;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapper.Estoque
{
    public class CategoriaMapper : BaseAncestralMapper
    {
        public CategoriaMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categoria, CategoriaPoco>()
                    .ForMember(destPoco => destPoco.Codigo, m => m.MapFrom(dom => dom.IdCategoria))
                    .ForMember(destPoco => destPoco.Descricao, m => m.MapFrom(dom => dom.DescricaoCategoria));

                cfg.CreateMap<CategoriaPoco, Categoria>()
                    .ForMember(destDom => destDom.IdCategoria, map => map.MapFrom(poco => poco.Codigo))
                    .ForMember(destDom => destDom.DescricaoCategoria, map => map.MapFrom(poco => poco.Descricao));
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
