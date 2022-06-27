﻿using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Mapper.Auxiliar;
using Atacado.Repository.Auxiliar;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Auxiliar
{
    public class ProfissaoService : BaseAncestralService<ProfissaoPoco, Profissao>
    {
        private ProfissaoRepository repositorio;
        private ProfissaoMapper mapConfig;

        public ProfissaoService()
        {
            this.repositorio = new ProfissaoRepository(new AtacadoContext());
            this.mapConfig = new ProfissaoMapper();
        }

        public override List<ProfissaoPoco> Listar()
        {
            List<Profissao> listDOM = this.repositorio.Read().ToList();
            return this.ProcessarListaDOM(listDOM);
        }

        public override ProfissaoPoco Selecionar(int id)
        {
            Profissao dom = this.repositorio.Read(id);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(dom);
            return poco;
        }

        public override ProfissaoPoco Criar(ProfissaoPoco obj)
        {
            Profissao dom = this.mapConfig.Mapper.Map<Profissao>(obj);
            Profissao criado = this.repositorio.Add(dom);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(criado);
            return poco;
        }

        public override ProfissaoPoco Atualizar(ProfissaoPoco obj)
        {
            Profissao dom = this.mapConfig.Mapper.Map<Profissao>(obj);
            Profissao atualizado = this.repositorio.Edit(dom);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(atualizado);
            return poco;
        }

        public override ProfissaoPoco Excluir(ProfissaoPoco obj)
        {
            return this.Excluir(obj.IdProfissao);
        }
        public override ProfissaoPoco Excluir(int id)
        {
            Profissao excluido = this.repositorio.DeleteById(id);
            ProfissaoPoco poco = this.mapConfig.Mapper.Map<ProfissaoPoco>(excluido);
            return poco;
        }
    }
}
