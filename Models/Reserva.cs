namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor do que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
    return Hospedes.Count;
}

       public decimal CalcularValorDiaria()
{
    // Calcula o valor total, multiplicando os dias reservados pelo valor da diária da suíte
    decimal valorTotal = DiasReservados * Suite.ValorDiaria;

    // Regra: Concede um desconto de 10% se a reserva for de 10 ou mais dias
    if (DiasReservados >= 10)
    {
        // Calcula o valor do desconto (10% do valor total)
        decimal desconto = valorTotal * 0.10M;
        
        // Subtrai o desconto do valor total
        valorTotal -= desconto;
    }

    // Retorna o valor final, com ou sem o desconto aplicado
    return valorTotal;
}
    }
}