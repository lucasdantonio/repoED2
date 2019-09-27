using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Livro {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public void adicionarExemplar(Exemplar exemplar) { }
        public int qtdeExemplares() { return 0; }
        public int qtdeDisponiveis() { return 0; }
        public int qtdeEmprestimos() { return 0; }
        public double percDisponibilidade() { return 0; }

    }
}
