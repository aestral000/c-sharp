namespace Banco {
    public class Cliente {
        private string nome;

        public string Nome { get {return nome; } set { this.nome = value; } }

        public Cliente(string nome) {
            Nome = nome;
        }
    }
}