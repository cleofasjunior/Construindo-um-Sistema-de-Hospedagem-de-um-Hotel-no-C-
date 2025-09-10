using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("--- SISTEMA DE RESERVAS DO HOTEL ---");
Console.WriteLine("--------------------------------------------------\n");

Console.WriteLine("--- TESTE 1: TENTATIVA DE RESERVA COM CAPACIDADE EXCEDIDA ---");
Console.WriteLine("Cenário: Cliente tenta reservar suíte para 3 pessoas. A suíte tem capacidade para 2.");

try
{
    // Cenário: tentar cadastrar 3 hóspedes em uma suíte com capacidade para apenas 2.
    List<Pessoa> hospedesExcedentes = new List<Pessoa>
    {
        new Pessoa("Hóspede A"),
        new Pessoa("Hóspede B"),
        new Pessoa("Hóspede C")
    };
    Suite suitePequena = new Suite(tipoSuite: "Quarto Standard", capacidade: 2, valorDiaria: 100);

    Reserva reservaInvalida = new Reserva(diasReservados: 3);
    reservaInvalida.CadastrarSuite(suitePequena);

    // Esta chamada deve lançar uma exceção
    reservaInvalida.CadastrarHospedes(hospedesExcedentes);

    // Se o código chegar aqui, o teste falhou
    Console.WriteLine("❌ FALHA: A reserva foi efetuada, mas a capacidade máxima foi excedida.");
}
catch (Exception ex)
{
    // Se a exceção for capturada, o teste passou
    Console.WriteLine("✅ SUCESSO: A reserva foi bloqueada corretamente.");
    Console.WriteLine($"Mensagem do Sistema: {ex.Message}");
}

Console.WriteLine("\n" + new string('-', 50) + "\n");

Console.WriteLine("--- TESTE 2: RESERVA COM DESCONTO POR LONGA ESTADIA ---");
Console.WriteLine("Cenário: Cliente faz uma reserva de 10 dias, garantindo um desconto.");

try
{
    // Cenário: cliente faz uma reserva de 10 dias, que é o limite para o desconto.
    List<Pessoa> hospedesParaDesconto = new List<Pessoa> { new Pessoa("Cliente VIP") };
    Suite suiteGrande = new Suite(tipoSuite: "Suíte Luxo", capacidade: 1, valorDiaria: 200);

    Reserva reservaComDesconto = new Reserva(diasReservados: 10);
    reservaComDesconto.CadastrarSuite(suiteGrande);
    reservaComDesconto.CadastrarHospedes(hospedesParaDesconto);

    decimal valorEsperado = (10 * 200) * 0.90M; // R$ 2000 - 10% = R$ 1800
    decimal valorCalculado = reservaComDesconto.CalcularValorDiaria();

    // Valida se o valor calculado é o mesmo que o valor esperado
    if (valorCalculado == valorEsperado)
    {
        Console.WriteLine("✅ SUCESSO: A reserva foi concluída com sucesso e o desconto foi aplicado.");
        Console.WriteLine($"Detalhes da Reserva:");
        Console.WriteLine($"- Total de diárias: 10");
        Console.WriteLine($"- Valor por diária: R$ 200,00");
        Console.WriteLine($"- Valor total sem desconto: R$ 2.000,00");
        Console.WriteLine($"- Valor com 10% de desconto: {valorCalculado:C}");
    }
    else
    {
        Console.WriteLine("❌ FALHA: O cálculo do desconto está incorreto.");
        Console.WriteLine($"Valor esperado: {valorEsperado:C}");
        Console.WriteLine($"Valor calculado: {valorCalculado:C}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"❌ FALHA: Ocorreu um erro inesperado ao tentar reservar: {ex.Message}");
}