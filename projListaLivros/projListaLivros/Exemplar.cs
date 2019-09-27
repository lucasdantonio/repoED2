using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Exemplar {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public bool emprestar() { return false; }
        public bool devolver() { return false; }
        public bool disponivel() { return false; }
        public int qtdeEmprestimos() { return 0; }

    }
}
