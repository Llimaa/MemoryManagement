
class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;

        Sum(x, y);
    }

    static void Sum(int param1, int param2)
    {
        int result = param1 + param2;
        ShowResult(result);
    }

    static void ShowResult(int result) =>
        Console.WriteLine($"The result is: {result}");
}

// Como fica a alocação dos recursos em tempo de execução.
// Cada bloco é um stack frame, e note que o primeiro a ser chamado foi o metodo main, mas ele fica no fim da nossa pilha,
// pois quando o sistema for liberar os recursos, o main será o ultimo a ser liberado da mémoria.
// Quando chamamos uma função que tem parâmetros, a primeira coisa a ser alocada no Stack Frame são os parâmetros passados,
// logo após é gravado o endereço para o onde o método deve retornar ao finalizar sua execução 
// e por fim as suas variáveis locais.

// [Stack]
// -------------
// | ShowResult |
// | result = 30|
// -------------
// | Sum        |
// | result = 30|
// | Return Main|
// | param2 = 20|
// | param1 = 10|
// -------------
// | Main       |
// | x = 10     |
// | y = 20     |
// -------------
