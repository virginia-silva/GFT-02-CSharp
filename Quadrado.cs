namespace gftstart02
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;
    }
}