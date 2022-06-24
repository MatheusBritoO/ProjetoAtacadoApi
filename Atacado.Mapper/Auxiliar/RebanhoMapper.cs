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
    public class RebanhoMapper : BaseAncestralMapper
    {
        public RebanhoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Rebanho, RebanhoPoco>();

                cfg.CreateMap<RebanhoPoco, Rebanho>();

            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
