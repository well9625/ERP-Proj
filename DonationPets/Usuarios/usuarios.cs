namespace usuarios
{

    public class Usuario
    {

        public static DateTime dataCadastro { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public int Idade
        {
            get
            {
                DateTime hoje = DateTime.Today;
                int idade = hoje.Year - DataNascimento.Year;
                if (DataNascimento.Date > hoje.AddYears(-idade))
                {
                    idade--;
                }
                return idade;
            }
        }


        public class CriarUsuario
        {
            public Usuario NovoUsuario { get; set; }

            public CriarUsuario(string nome, string email, DateTime dataNascimento)
            {


                if (dataNascimento > DateTime.Now.AddYears(-18))
                {

                    throw new ArgumentException("Data de nascimento inválida.");

                }

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email))
                {
                    throw new ArgumentException("Nome e email não podem ser nulos ou vazios.");
                }
                NovoUsuario = new Usuario()
                {

                    
                    Nome = nome,
                    Email = email,
                    DataNascimento = dataNascimento
                };
                Usuario.dataCadastro = DateTime.Now;

            }
        }
    }
}