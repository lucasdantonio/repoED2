﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaAtendimento.model {
    class Guiche {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }
        
        public Guiche() {
            this.Atendimentos = new Queue<Senha>();
            this.Id = 0;
        }
        public Guiche(int id) {
            this.Atendimentos = new Queue<Senha>();
            this.Id = id;
        }
        public bool chamar(Queue<Senha> filaSenhas) {
            if (filaSenhas.Count > 0) {
                Atendimentos.Enqueue(filaSenhas.First());
                filaSenhas.Dequeue();
                return true;
            } else return false;
        }
    }
}
