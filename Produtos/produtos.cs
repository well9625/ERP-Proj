namespace produtos;


public class produto
{

    private string nomeProduto;
    private float precoProduto = 0F;
    private string descricaoProduto;
    private static int idProduto = 0;
    private DateTime dataCriacao;

    // ========PUBLIC========
    public string Nome { get; private set; }
    public float Preco { get; private set; }
    public string Descricao { get; private set; }
    public int Id { get; private set; }
    public DateTime DataCriacao { get; private set; }





    public void CriarProduto(string Nome, float Preco, string Descricao)
    {
        if (string.IsNullOrEmpty(Nome) || Nome.Length < 2)
        {
            throw new ArgumentException("Nome e preço são obrigatórios e o preço deve ser um valor positivo.");

        }

        if (Preco < 0)
        {
            throw new ArgumentException("O preço deve ser um valor positivo.");
        }

    if (Descricao.Length >= 0)
        {
            
        }

        this.Id = ++idProduto;
        this.nomeProduto = Nome;
        this.Nome = Nome;
        this.precoProduto = Preco;
        this.Preco = Preco;
        this.descricaoProduto = string.IsNullOrWhiteSpace(Descricao) ? "Descrição não fornecida" : Descricao;
        this.Descricao=Descricao;
        this.dataCriacao = DateTime.Now;
        this.DataCriacao = this.DataCriacao;

    }

    public class ConsultarProdutos
    {
        public string produtoConsultado;
        public float precoConsultado;
        public DateTime dataConsultado;
        public ConsultarProdutos(string nome, float Preco)
        {
            produtoConsultado = nome;
            precoConsultado = Preco;
            dataConsultado = DateTime.Now;
        }



    }


}



