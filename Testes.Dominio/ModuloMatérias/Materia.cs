using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes.Dominio.Compartilhado;

namespace Testes.Dominio.ModuloMatérias
{
    public class Materia : EntidadeBase<Materia>
    {
        public string nome { get; set; }
        //public Disciplina disciplina { get; set; }
        //public List<Questao> questoes { get; set; }

        public Materia()
        {
        }

        public override void Atualizar(Materia registro)
        {
            throw new NotImplementedException();
        }
        
    }
}
