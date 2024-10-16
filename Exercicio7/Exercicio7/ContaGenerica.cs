namespace Exercicio7
{
    public abstract class ContaGenerica
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Saldo { get; set; }

        public abstract void Depositar();
        public abstract void Sacar();
    }

    public class ContaCorrente : ContaGenerica
    {
        public string limite { get; set; }
        public override void Depositar()
        {
            Console.WriteLine("Você fez um deposito de:R$28.600.000,00.");
        }

        public override void Sacar()
        {
            Console.WriteLine("Você está sacando:R$12.100.000,00. Confirme por meio do seu e-mail para termos certeza que é você.");
        }
    }
}