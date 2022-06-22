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
    public class ProfissaoMapper : BaseAncestralMapper
    {
        public ProfissaoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Profissao, ProfissaoPoco>();

                cfg.CreateMap<ProfissaoPoco, Profissao>();

            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
