using usuarios;
using produtos;

class MainClass
{

    public static void Main(string[] args)
    {



produto produto1 = new produto();
produto1.CriarProduto("Notebook", 1500F, "Notebook Gamer");

produto.ConsultarProdutos consulta = new produto.ConsultarProdutos(produto1.Nome, produto1.Preco);

Console.WriteLine(produto1.Nome);
Console.WriteLine(produto1.Preco);
Console.WriteLine(produto1.Descricao);


        // while (continuar)
        // {


        //     Console.WriteLine("=================================");
        //     Console.WriteLine("        BANCO DIGITAL C#         ");
        //     Console.WriteLine("=================================");
        //     Console.WriteLine(" 1 - Consultar Saldo             ");
        //     Console.WriteLine(" 2 - Depositar                   ");
        //     Console.WriteLine(" 3 - Sacar                       ");
        //     Console.WriteLine(" 0 - Sair                        ");
        //     Console.WriteLine("=================================");
        //     Console.Write("Escolha uma opção: ");
        //     usuarios.user usuario = new usuarios.user();
        //     Console.Write(usuario.pessoa);
        //     menu = Console.ReadLine() ?? "";

        //     switch (menu)
        //     {
        //         case "1":
        //             Console.WriteLine($"O saldo disponível é R${_Conta.GetSaldo():f2}");
        //             break;
        //         case "2":

        //             Console.WriteLine("Digite o valor de deseja depositar");
        //             Console.WriteLine("1 - R$100");
        //             Console.WriteLine("2 - R$200");
        //             Console.WriteLine("3 - R$300");
        //             Console.WriteLine("4 - Digite o valor manualmente.");
        //             menuDepositoRapido = Console.ReadLine() ?? "";
        //             switch (menuDepositoRapido)
        //             {
        //                 case "1":

        //                     _Conta.Depositar(100);
        //                     Console.WriteLine("Valor depositado com sucesso!");
        //                     break;
        //                 case "2":

        //                     _Conta.Depositar(200);
        //                     Console.WriteLine("Valor depositado com sucesso!");
        //                     break;
        //                 case "3":

        //                     _Conta.Depositar(300);
        //                     Console.WriteLine("Valor depositado com sucesso!");
        //                     break;
        //                 case "4":
        //                     valor = float.Parse(Console.ReadLine() ?? "0");
        //                     _Conta.Depositar(valor);
        //                     break;
        //             }
        //             break;
        //         case "3":
        //             Console.WriteLine("Digite o valor de deseja sacar");
        //             Console.WriteLine("1 - R$100");
        //             Console.WriteLine("2 - R$200");
        //             Console.WriteLine("3 - R$300");
        //             Console.WriteLine("4 - Digite o valor manualmente.");
        //             menuSaqueRapido = Console.ReadLine() ?? "";
        //             switch (menuSaqueRapido)
        //             {
        //                 case "1":
        //                     _Conta.Sacar(100);

        //                     break;
        //                 case "2":
        //                     _Conta.Sacar(100);

        //                     break;
        //                 case "3":
        //                     _Conta.Sacar(100);

        //                     break;
        //                 case "4":
        //                     Console.WriteLine("Digite o valor que deseja sacar.");
        //                     valor = float.Parse(Console.ReadLine() ?? "0");
        //                     _Conta.Sacar(valor);

        //                     break;
        //             }
        //             break;

        //     }
        // }
    }
}