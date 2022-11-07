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
            // Implementado!
           if (Suite.Capacidade >= hospedes.Count) 
           {
                Hospedes = hospedes;
           }
            else
            {
                // Implementado!
                 throw new Exception("Capacidade menor do que o número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado!
             return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado!
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10) {
                valor -= Decimal.Divide(Decimal.Multiply(valor, 10), 100);
            }

            return valor;
        }
    }
}
    