using projFilaAtendimento.controller;
using projFilaAtendimento.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projFilaAtendimento {
    public partial class FormAtendimento : Form {

        private Guiches listaGuiches;
        private Guiche guiche;
        private int numGuiche;
        private int numChamaGuiche;

        private Senhas listaSenhas;
        private Senha senha;
        private int numSenha;

        public FormAtendimento() {
            InitializeComponent();
            numGuiche = 0; numSenha = 1;
            listaSenhas = new Senhas();
            listaGuiches = new Guiches();
            guiche = new Guiche();
        }

        private void ButtonGerar_Click(object sender, EventArgs e) {
            // Gerar Senha
            listaSenhas.gerar();
        }

        private void ButtonListarSenhas_Click(object sender, EventArgs e) {
            // Listar Senhas
            listBoxSenhas.Items.Clear();

            if (listaSenhas.FilaSenhas.Count >= 1) {
                foreach (Senha s in listaSenhas.FilaSenhas) {
                    listBoxSenhas.Items.Add(s.dadosParciais());
                }
            } else listBoxSenhas.Items.Add("Lista de Senhas Vazia");
        }

        private void ButtonAdicionarGuiche_Click(object sender, EventArgs e) {
            // Adicionar Guichê
            listaGuiches.adicionar(new Guiche(numSenha));
            numGuiche += 1; ++numSenha;

            labelQuantidadeGuiches.Text = numGuiche.ToString();
        }

        private void ButtonChamar_Click(object sender, EventArgs e) {
            // Chamar Senha para tal Guichê
            numChamaGuiche = int.Parse(textBoxGuiche.Text);

            guiche.chamar(listaSenhas.FilaSenhas);            
        }

        private void ButtonListarAtendimentos_Click(object sender, EventArgs e) {
            // Listar Atendimentos
            listBoxAtendimentos.Items.Clear();

            if (guiche.Atendimentos.Count >= 1) {
                foreach (Senha s in guiche.Atendimentos) {
                    listBoxAtendimentos.Items.Add(s.dadosCompletos());
                }
            } else listBoxAtendimentos.Items.Add("Lista de Atendimentos Vazia");
        }
    }
}
