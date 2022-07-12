using Atacado.Dal.Auxiliar;
using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
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
        public class AreaConhecimentoService : BaseAncestralService<AreaConhecimentoPoco, AreaConhecimento>
        {
            private AreaConhecimentoRepository repositorio;
            

            public AreaConhecimentoService()
            {
                this.repositorio = new AreaConhecimentoRepository(new AtacadoContext());
            this.mapeador = new MapeadorGenerico<AreaConhecimentoPoco, AreaConhecimento>();
            }

        public AreaConhecimentoService(AtacadoContext contexto)
        {
            this.repositorio = new AreaConhecimentoRepository(contexto);
            this.mapeador = new MapeadorGenerico<AreaConhecimentoPoco, AreaConhecimento>();
        }



        public override List<AreaConhecimentoPoco> Listar()
            {
            List<AreaConhecimento> listDOM = this.repositorio.Read().ToList();
            return this.ProcessarListaDOM(listDOM);
            }
           
            public List<AreaConhecimentoPoco> Listar(int pular, int exibir)
            {
            List<AreaConhecimento> listDOM = this.repositorio.Read(pular, exibir).ToList();
            return ProcessarListaDOM(listDOM);
            }


        public override AreaConhecimentoPoco Selecionar(int id)
            {
                AreaConhecimento dom = this.repositorio.Read(id);
                AreaConhecimentoPoco poco = this.mapeador.Mecanismo.Map<AreaConhecimentoPoco>(dom);
                return poco;
            }

            public override AreaConhecimentoPoco Criar(AreaConhecimentoPoco obj)
            {
                AreaConhecimento dom = this.mapeador.Mecanismo.Map<AreaConhecimento>(obj);
                AreaConhecimento criado = this.repositorio.Add(dom);
                AreaConhecimentoPoco poco = this.mapeador.Mecanismo.Map<AreaConhecimentoPoco>(criado);
                return poco;
            }

            public override AreaConhecimentoPoco Atualizar(AreaConhecimentoPoco obj)
            {
                AreaConhecimento dom = this.mapeador.Mecanismo.Map<AreaConhecimento>(obj);
                AreaConhecimento atualizado = this.repositorio.Edit(dom);
                AreaConhecimentoPoco poco = this.mapeador.Mecanismo.Map<AreaConhecimentoPoco>(atualizado);
                return poco;
            }

            public override AreaConhecimentoPoco Excluir(AreaConhecimentoPoco obj)
            {
                return this.Excluir(obj.IdArea);
            }
            public override AreaConhecimentoPoco Excluir(int id)
            {
                AreaConhecimento excluido = this.repositorio.DeleteById(id);
                AreaConhecimentoPoco poco = this.mapeador.Mecanismo.Map<AreaConhecimentoPoco>(excluido);
                return poco;
            }
        }
    } 

