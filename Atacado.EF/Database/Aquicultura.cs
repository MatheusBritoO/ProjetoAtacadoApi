using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
	[Table("Aquicultura")]
	public partial class Aquicultura
	{
		[Key]
		[Column("Id_Aquicultura")]
		public int IdAquicultura { get; set; }

		[Column("Ano")]
		public int Ano { get; set; }

		[Column("Id_Municipio")]
		public int IdMunicipio { get; set; }

		[Column("Id_Tipo_Aquicultura")]
		public int IdTipoAquicultura { get; set; }

		[Column("Producao")]
		public int? Producao { get; set; }

		[Column("Valor_Producao")]
		public int? ValorProducao { get; set; }

		[Column("Proporcao_Valor_Producao")]
		public double? ProporcaoValorProducao { get; set; }

		[Column("Moeda")]
		[Unicode(false)]
		public string Moeda { get; set; }
	}
}
