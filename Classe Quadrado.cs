namespace CalcAreaPOO
{
    public class Classe Quadrado : forma
    {
        public double Lado { get; set;}
        public override double CalcularArea => this.Lado * this.Lado; 

    }
}