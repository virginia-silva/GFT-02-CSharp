
//Calculando area de um quadrado, retangulo e circulo.

using System;

namespace gftstart02
{
    class caixa
    {
        public enum OpcoesMenu
        {
            Sair = 0,
            quadrado  = 1,
            Retangulo = 2,
            Circulo = 4

        }
        static void Main(string[] args)
        {
           OpcoesMenu escolha = OpcoesMenu.quadrado;
           while ( (escolha = GetEscolha ()) != OpcoesMenu.Sair)
           {

               Forma forma = null;
               switch ( escolha)
               {
                   case OpcoesMenu.Quadrado:
                   forma = CriaQuadrado();
                   break;
                   case OpcoesMenu.Retangulo:
                   forma = CriaRetangulo();
                   break;
                   case OpcoesMenu.Circulo:
                   forma = CriaCirculo();
                   break;
                default:
                    break;                 

               }

               Console.writeline($"A área do {escolha} é {forma.CalcularArea}");
               Console.whiteline();
               
            }

            Environment.Exit (0);
        }

        public static OpcoesMenu GetEscolha()

        {
            Console.writeline(" Escolha a figura para qual deseja calcular a Area : ");
            Console.writeline("\t{0} - Quadrado", (int)OpcoesMenu.quadrado);
            Console.writeline("\t{0} - Retângulo", (int)OpcoesMenu.Retangulo);
            Console.writeline("\t{0} - Círculo", (int)OpcoesMenu.Circulo);
            Console.writeline("\t{0} - Sair", (int)OpcoesMenu.Sair);
            Console.write("escolha:");
            string valor = console.ReadLine();
            OpcoesMenu escolha;
            if (!Enum.TryParse(valor, out escolha) || ! Enum.IsDefine(typeof(opcoesMenu), escolha))
            {
                console.writeline("opcao invalida, escolha uma opcao valida");
                return GetEscolha();
            }

            return escolha;

            private static double getDouble(string prompt)    
            {
                bool isValid = false;
                double valor = 0;
                while (!isValid)
            }

            console.write(prompt);
            isValido = double.TryParse(console.ReadLine(), out valor);

        }

        return valor;

        private static Quadrado CriaQuadrado()

        {
            double lado = GetDouble ("lado do Quadrado: ");
            return new Quadrado() {lado = lado};
        }

        private static Retangulo CriaRetangulo()

        {
            double lado = GetDouble ("lado do Retangulo: ");
            return new Retangulo() {lado = lado};
        }

        private static Quadrado Circulo()

        {
            double Raio = GetDouble ("valor do raio do Circulo: ");
            return new Circulo()
        }

        Raio = raio

        };

    }
}
