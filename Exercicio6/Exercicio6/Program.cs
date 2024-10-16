namespace Exercicio2
{

    public abstract class Animal
    {
        public string Nome { get; set; }

        public string Especie { get; set; }


        public abstract void EmitirSom();
    }

    public class Capivara : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Som: Grrr");
        }
    }
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("\nSom: Miauu");
        }
    }
    public class Porco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("\nSom: Roinc, Roinc");
        }
    }
}