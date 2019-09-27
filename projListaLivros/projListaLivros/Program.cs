using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projListaLivros {
    class Program {
        static void Main(string[] args) {
            carregaMenu();
        }
        private static void exibeMenu() {
            Console.WriteLine(
                "--------------------------------------\n" +
                "| 0. Sair                            |\n" +
                "| 1. Adicionar livro                 |\n" +
                "| 2. Pesquisar livro (sintético)     |\n" +
                "| 3. Pesquisar livro (analítico)     |\n" +
                "| 4. Adicionar exemplar              |\n" +
                "| 5. Registrar empréstimo            |\n" +
                "| 6. Registrar devolução             |\n" +
                "--------------------------------------");
        }
        private static void carregaMenu() {
            int opcao;

            exibeMenu();

            Console.Write("Digite a opção: ");
            opcao = Int16.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    // Adicionar Livro
                    break;
                case 2:
                    // Pesquisar Livro Sintético
                    break;
                case 3:
                    // Pesquisar Livro Analítico
                    break;
                case 4:
                    // Adicionar Exemplar
                    break;
                case 5:
                    // Registrar Empréstimo
                    break;
                case 6:
                    // Registrar Devolução
                    break;
                default:
                    // Sair
                    break;
            }

        }
        private void adicionaLivro() {
            int isbn; string titulo, autor, editora;

            Console.Write("Digite o isbn: ");
            Console.Write("Digite o titulo: ");
            Console.Write("Digite o autor: ");
            Console.Write("Digite o editora: ");
        }
        private void pesquisaLivroSintetico() {
            
        }
        private void pesquisaLivroAnalitico() { }
        private void adicionaExemplar() {
            int tombo;

            Console.Write("Digite o tombo: ");
        }
        private void registraEmprestimo() {
            int tombo;

            Console.Write("Digite o tombo: ");
        }
        private void registraDevolucao() { }
    }
}
