
namespace ExercicioTriangulo
{
    internal class Program
    {      
        static void ObterValoresDosLados(Triangulo triangulo)
        {
            Console.Write("Digite o primeiro Lado: ");
            triangulo.lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o segundo Lado: ");
            triangulo.lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o terceiro Lado: ");
            triangulo.lado3 = int.Parse(Console.ReadLine());
        }
        
        static void MensagemDaResposta(Triangulo triangulo)
        
        {

            if (triangulo.VerificarSeehUmTriangulo())
            {

                if (triangulo.equilatero)
                {
                    Console.WriteLine("É um triângulo Equilátero");
                }
                else if ( triangulo.escaleno) 
                {
                    Console.WriteLine("É um triângulo Escaleno");
                }
                else if ( triangulo.isoceles)
                {
                    Console.WriteLine(" É um triângulo Isósceles ");
                }
                else
                {
                    Console.WriteLine("Não é um triângulo");
                }

            }


            


            





        }

        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            ObterValoresDosLados(triangulo);
            triangulo.VerificarSeehUmTriangulo();
            Console.WriteLine();
            triangulo.VerTipoDoTriangulo();
            MensagemDaResposta(triangulo);
        }
    }
}