namespace Calculadora
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Qual operacao deseja fazer?");
      Console.WriteLine("1- Adicao");
      Console.WriteLine("2- Subtracao");
      Console.WriteLine("3- Multiplicacao");
      Console.WriteLine("4- Divisao \n");

      int operacao = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o primeiro numero: ");
      int num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo numero: ");
      int num2 = int.Parse(Console.ReadLine());

      int resultado = 0;
      string operacaoStr = "";

      switch (operacao)
      {
        case 1:
          resultado = num1 + num2;
          operacaoStr = "Adicao";
          break;
        case 2:
          resultado = num1 - num2;
          operacaoStr = "Subtracao";
          break;
        case 3:
          resultado = num1 * num2;
          operacaoStr = "Multiplicacao";
          break;
        case 4:
          if (num2 != 0)
          {
            resultado = num1 / num2;
            operacaoStr = "Divisao";
          }
          else
          {
            Console.WriteLine("Erro: Divisao por zero!");
            return;
          }
          break;
        default:
          Console.WriteLine("Operacao invalida!");
          return;
      }

      Console.WriteLine($"\nResultado da {operacaoStr}: {resultado}");
    }
  }
}