namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        private const decimal Desconto = 0.10M;

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
            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (hospedes.Count > Suite.Capacidade)
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public (decimal valor, decimal desconto) CalcularValorDiaria()
        {
            // Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = 0;

            if (DiasReservados >= 10)
            {
                desconto = (valor * Desconto);
                valor = valor - desconto;
            }

            return (valor, desconto);
        }
    }
}