

namespace Hotel
{
    internal class Quarto
    {
        public int Id { get; private set; }
        public Proprietario Proprietario { get; private set; }  
        
        public Quarto(int id, string nome, string email) {
            Id = id;
            Proprietario = new Proprietario(nome, email);
        }

        public override string ToString()
        {
            return $"Quarto com id {Id} e número {Id + 1} com o proprietário: { Proprietario }";
        }
    }
}
