using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dal.Ancestral
{
    public abstract class BaseAncestralDao<T> where T : class
    {
        public abstract T Create(T obj);

        public abstract T Read(int id);

        public abstract List<T> ReadAll();

        public abstract T Update(T obj);

        public abstract T Delete(int id);

        public abstract T Delete(T obj);
    }

}
