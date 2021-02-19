namespace CalcAreaPOO
{
    public class Classe Retangulo : Forma
    {
        public double lado { get; set; }
        public override double CalcularArea => this.lado * this.lado;
    }
}