using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Exemplar {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo { get => tombo; set => tombo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }

        public Exemplar(int tombo) {
            this.Tombo = tombo;
            this.Emprestimos = new List<Emprestimo>();
        }

        public bool emprestar() {
            //if (emprestimos[qtdeEmprestimos()].DtDevolucao == null) return false;

            Emprestimos.Add(new Emprestimo(DateTime.Now));
            return true;
        }
        public bool devolver() {
            if (Emprestimos[qtdeEmprestimos() - 1].DtEmprestimo == null) return false;

            Emprestimos[qtdeEmprestimos() - 1].DtDevolucao = DateTime.Now;
            return true;
        }
        public bool disponivel() {
            //if (Emprestimos[qtdeEmprestimos() - 1].DtDevolucao != null) return true;

            return true;
        }
        public int qtdeEmprestimos() {
            if(Emprestimos == null) return 0;
            return Emprestimos.Count;
        }

    }
}
