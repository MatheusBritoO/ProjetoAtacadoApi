using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapper.Ancestral
{
    public abstract class BaseAncestralMapper
    {
        protected IMapper getMapper;

        public IMapper Mapper { get => this.getMapper; }

        public BaseAncestralMapper()
        { }
    }
}
