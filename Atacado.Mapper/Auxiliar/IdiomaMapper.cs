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
    public class IdiomaMapper : BaseAncestralMapper
    {
        public IdiomaMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Idioma, IdiomaPoco>();

                cfg.CreateMap<IdiomaPoco, Idioma>();

            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
