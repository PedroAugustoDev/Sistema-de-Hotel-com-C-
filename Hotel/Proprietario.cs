
namespace Hotel
{
    internal class Proprietario
    {
 
        public string Nome {  get; set; }
        public string Email { get; set; }

        public Proprietario( string nome, string email )
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}
