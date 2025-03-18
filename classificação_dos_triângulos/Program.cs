namespace classificação_dos_triângulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("=========================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Classificador de triangulos");
                Console.ResetColor();
                Console.WriteLine("=========================");


                int ladox;

                while (true)
                {
                    Console.WriteLine("informe o lado x do triangulo");

                    bool consegiuConverter = int.TryParse(Console.ReadLine(),out ladox);
                    if (consegiuConverter)
                    {
                        break;
                    }
                }

                int ladoy;
                while (true)
                {
                    Console.WriteLine("informe o lado y do triangulo");

                    bool consegiuConverter = int.TryParse(Console.ReadLine(), out ladoy);
                    if (consegiuConverter)
                    {
                        break;
                    }
                }
                int ladoz;
                while (true)
                {
                    Console.WriteLine("informe o lado z do triangulo");

                    bool consegiuConverter = int.TryParse(Console.ReadLine(), out ladoz);
                    if (consegiuConverter)
                    {
                        break;
                    }
                }

                Console.WriteLine("============================");
                Console.WriteLine("exibir valores ");
                Console.WriteLine("lado x " + ladox);
                Console.WriteLine("lado y " + ladoy);
                Console.WriteLine("lado z " + ladoz);

                //verificar validade do triangulo
                Console.Write("==========================");
                
                bool medidasTrianguloValida =
                    ladox+ladoy>ladoz &&
                    ladox+ladoz>ladoy &&
                    ladoy +ladoz>ladox;

                if (medidasTrianguloValida == true)
                {

                    string TipoTRiangulo = "nao classificado";


                    if (ladox == ladoy && ladoy == ladoz)
                        TipoTRiangulo = "equilatero";



                    else if (ladox != ladoy && ladoy != ladoz && ladox != ladoz)
                        TipoTRiangulo = "escaleno";


                    else 
                        TipoTRiangulo = "isosceles";

                        Console.WriteLine($"o triangulo e {TipoTRiangulo}"); 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("======================================");
                    Console.WriteLine( " os valores informados nao formam um triangulo");
                    Console.ResetColor();
                }


                Console.Write("deseja continuar S/N");
                 string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
