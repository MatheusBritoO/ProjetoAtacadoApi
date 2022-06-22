using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapper.Auxiliar
{
    public class AreaConhecimentoMapper :  BaseAncestralMapper
    {
        public AreaConhecimentoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AreaConhecimento, AreaConhecimentoPoco>();

                cfg.CreateMap<AreaConhecimentoPoco, AreaConhecimento>();

            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
