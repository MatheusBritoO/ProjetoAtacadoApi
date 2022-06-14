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
    public class SubcategoriaMapper : BaseAncestralMapper
    {
        public SubcategoriaMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Subcategoria, SubcategoriaPoco>();

                cfg.CreateMap<SubcategoriaPoco, Subcategoria>();
              
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
