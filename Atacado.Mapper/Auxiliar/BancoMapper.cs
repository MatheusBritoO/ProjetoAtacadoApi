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
    public class BancoMapper : BaseAncestralMapper
    {
        public BancoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Banco, BancoPoco>();

                cfg.CreateMap<BancoPoco, Banco>();

            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
