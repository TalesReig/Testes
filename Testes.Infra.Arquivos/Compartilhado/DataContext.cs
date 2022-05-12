using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes.Infra.Arquivos.Compartilhado.Serializadores;
using Testes.Dominio.ModuloMatérias;

namespace Testes.Infra.Arquivos.Compartilhado
{
    [Serializable]
    public class DataContext //Container
    {
        private readonly ISerializador serializador;
        public List<Materia> Materia { get; set; }

        //public List<Contato> Questao { get; set; }

        //public List<Compromisso> Teste { get; set; }

        public DataContext()
        {
            Materia = new List<Materia>();

            //Contatos = new List<Contato>();

            //Compromissos = new List<Compromisso>();

            //Despesas = new List<Despesa>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Materia.Any())
                this.Materia.AddRange(ctx.Materia);

            //if (ctx.Contatos.Any())
            //    this.Contatos.AddRange(ctx.Contatos);
            //
            //if (ctx.Compromissos.Any())
            //    this.Compromissos.AddRange(ctx.Compromissos);
            //
            //if (ctx.Despesas.Any())
            //    this.Despesas.AddRange(ctx.Despesas);
        }
    }
}
