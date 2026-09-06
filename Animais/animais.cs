namespace Animais
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public bool Vacinado { get; set; }
        public bool Castrado { get; set; }
        public string Observacoes { get; set; }
       
    }

public class Cachorro : Animal
    {
        public string Porte { get; set; }
       
    }

    public class Gato : Animal
    {
        public string Pelagem { get; set; }
        public string Comportamento { get; set; }
    }

}