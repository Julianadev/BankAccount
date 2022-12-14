using ContaJuwebs.Models;

internal class Program
{
  private static void Main(string[] args)
  {
      Console.WriteLine("Bem vindo ao Banco Juwebs!");
      ContaCorrente c1 = new ContaCorrente();
      {
        c1.TIPO = "CC";
        c1.NOME = "Juca";
        c1.CPF = "123.456.789-00";
        c1.AbrirConta();
      }
      while(true)
      {
        Console.WriteLine("Digite 1 - para ver os dados da conta");
        Console.WriteLine("Digite 2 - para depositar");
        Console.WriteLine("Digite 3 - para sacar");
        Console.WriteLine("Digite 4 - para pagar mensalidade");
        Console.WriteLine("Digite 5 - para encerrar conta");
        Console.WriteLine("Digite 0 - para sair");
        short opcao = short.Parse(Console.ReadLine());
        switch (opcao)
        {
          case 1:
            c1.MenuMetodo();
            break;
          case 2:
            Console.WriteLine("Digite o valor do depósito: ");
            double valor = double.Parse(Console.ReadLine());
            c1.Depositar(valor);
            break;
          case 3:
            Console.WriteLine("Digite o valor do saque: ");
            double valor2 = double.Parse(Console.ReadLine());
            c1.Sacar(valor2);
            break;
          case 4:
            c1.PagarMensal(0);
            break;
          case 5:
            c1.FecharConta();
            break;
          case 6:
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            break;
          default:
            Console.WriteLine("Opção inválida!");
            break;
        }
        Console.WriteLine("Deseja continuar? (S/N)");
        string resposta = Console.ReadLine();
        if (resposta == "N" || resposta == "n")
        {
          break;
        }
        else
        {
          Console.Clear();
        }
      }
  }
}