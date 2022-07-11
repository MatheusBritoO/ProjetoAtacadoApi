using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.EF.Database
{
	[Table("Tipo_Aquicultura")]
	public partial class TipoAquicultura
	{
		[Key]
		[Column("Id_Tipo_Aquicultura")]
		public int IdTipoAquicultura { get; set; }

		[Column("Descricao_Tipo_Aquicultura")]
		[Unicode(false)]
		public string DescricaoTipoAquicultura { get; set; }

		public bool? Situacao { get; set; }
	}
}
