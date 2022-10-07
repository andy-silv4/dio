using System.Text;
using DesafioProjetoHospedagem.Enums;
using DesafioProjetoHospedagem.Models;

Console.Clear();

Console.WriteLine($"----- {nameof(Test1)} -----");
Test1();
Console.WriteLine();

Console.WriteLine($"----- {nameof(Test2)} -----");
Test2();
Console.WriteLine();

Console.WriteLine($"----- {nameof(Test3)} -----");
Test3();
Console.WriteLine();

void Test1()
{
    // Cria os modelos de hóspedes e cadastra na lista de hóspedes
    var pessoas = new List<Pessoa>();

    pessoas.Add(new Pessoa(nome: "Hóspede 1"));
    pessoas.Add(new Pessoa(nome: "Hóspede 2"));

    Execute(pessoas, 5);
}

void Test2()
{
    var pessoas = new List<Pessoa>();

    pessoas.Add(new Pessoa(nome: "Hóspede 1"));
    pessoas.Add(new Pessoa(nome: "Hóspede 2"));

    Execute(pessoas, 10);
}

void Test3()
{
    var pessoas = new List<Pessoa>();

    pessoas.Add(new Pessoa(nome: "Hóspede 1"));
    pessoas.Add(new Pessoa(nome: "Hóspede 2"));
    pessoas.Add(new Pessoa(nome: "Hóspede 3"));

    Execute(pessoas, 15);

    Console.WriteLine();
}

void Execute(List<Pessoa> hospedes, int diasReservados)
{
    Console.OutputEncoding = Encoding.UTF8;

    // Cria a suíte
    var valorDiaria = 50.00M;
    Suite suite = new Suite(TipoSuite.Premium, capacidade: 2, valorDiaria);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    try
    {
        Reserva reserva = new Reserva(diasReservados);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        var calculo = reserva.CalcularValorDiaria();
        var textoDesconto = calculo.desconto > 0 ? $" - R$ {calculo.desconto.ToString("0.00")} de desconto" : "";

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.Write($"Valor diária: R$ {calculo.valor.ToString("0.00")} - ({diasReservados} dias X R$ {valorDiaria}");
        Console.WriteLine($"{textoDesconto})");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}