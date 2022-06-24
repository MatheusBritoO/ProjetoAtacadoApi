using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Auxiliar;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapper.Auxiliar
{
    public class TipoRebanhoMapper : BaseAncestralMapper
    {
        public TipoRebanhoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoRebanho, TipoRebanhoPoco>();

                cfg.CreateMap<TipoRebanhoPoco, TipoRebanho>();

            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
