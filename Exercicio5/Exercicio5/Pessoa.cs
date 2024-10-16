namespace Exercicio5
{
    public class Pessoa
    {
        public string nome { get; set; }

        public int idade { get; set;}

        public void Envelhecer(int anos)
        {
            idade += anos;
        }

        public void AguaDaVida (int anos)
        {
            idade -= anos;
        }
    }

    public class funcionario : Pessoa 
    {
        
    }
}
