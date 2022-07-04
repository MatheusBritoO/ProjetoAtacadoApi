using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Auxiliar
{
    public class RebanhoPoco
    {
        public int IdRebanho { get; set; }

        public int AnoRef { get; set; }

        public int IdMunicipio { get; set; }

        public int IdTipoRebanho { get; set; }

        public string TipoRebanho { get; set; }

        public int? Quantidade { get; set; }

        public bool? Situacao { get; set; }

    }
}
