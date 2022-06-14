using Atacado.Dal.Estoque;
using Atacado.EF.Database;
using Atacado.Mapper.Estoque;
using Atacado.Poco.Estoque;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Estoque
{
    public class SubcategoriaService : BaseAncestralService<SubcategoriaPoco>
    {
        private SubcategoriaDao dao; 
        private SubcategoriaMapper mapConfig;

        public SubcategoriaService()
        {
             this.dao = new SubcategoriaDao();
            this.mapConfig = new SubcategoriaMapper();
        }

        public override List<SubcategoriaPoco> Listar()
        {           
            List<Subcategoria> listDOM = dao.ReadAll();
            List<SubcategoriaPoco> listPOCO = new List<SubcategoriaPoco>();
            foreach (Subcategoria item in listDOM)
            {
                SubcategoriaPoco poco = this.mapConfig.Mapper.Map<SubcategoriaPoco>(item);
                listPOCO.Add(poco);
            }
            return listPOCO;
        }

        public override SubcategoriaPoco Selecionar(int id)
        {
            Subcategoria dom = this.dao.Read(id);
            SubcategoriaPoco poco = this.mapConfig.Mapper.Map<SubcategoriaPoco>(dom);
            return poco;
        }

    }
}
