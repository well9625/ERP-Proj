using usuarios;
public class Program
{
    static void Main(string[] args)
    {

        Usuario.CriarUsuario criarUsuario = new Usuario.CriarUsuario("João", "joao@email.com", new DateTime(2008, 10, 01));
        Usuario usuario = criarUsuario.NovoUsuario;

        Console.WriteLine("Nome: " + usuario.Nome);
        Console.WriteLine("Email: " + usuario.Email);
        Console.WriteLine("Data de Nascimento: " + usuario.DataNascimento.ToShortDateString());
        Console.WriteLine("Data de Cadastro: " + Usuario.dataCadastro.ToString());
        Console.WriteLine(usuario.Idade);
    }
}