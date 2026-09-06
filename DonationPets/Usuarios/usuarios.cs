namespace Usuarios
{
    
public abstract class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }

    public class Doador : Usuario
    {
        
    }

     public class Donatario : Usuario
    {
        public DateTime idade { get; set; }
        public string endereco { get; set; }
        

    }
}