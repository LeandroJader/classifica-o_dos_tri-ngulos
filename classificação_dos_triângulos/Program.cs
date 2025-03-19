using System;

namespace classificação_dos_triângulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirMenu();

                int ladox = LerLados("x");
                int ladoy = LerLados("y");
                int ladoz = LerLados("z");

                ExibirValoresInformados(ladox,ladoy,ladoz);
               
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

        public static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Classificador de triangulos");
            Console.ResetColor();
            Console.WriteLine("=========================");
        }
       static int LerLados (string nomelado)
        {

            int valor;

            while (true)
            {
                Console.WriteLine($"informe o lado {nomelado}");

                bool consegiuConverter = int.TryParse(Console.ReadLine(), out valor);
                if (consegiuConverter)
                {
                    break;
                }
            }
                return valor;
        }
        static void ExibirValoresInformados(int ladox,int ladoy,int ladoz)
        {

            Console.WriteLine("============================");
            Console.WriteLine("exibir valores ");
            Console.WriteLine("lado x " + ladox);
            Console.WriteLine("lado y " + ladoy);
            Console.WriteLine("lado z " + ladoz);

        }






    }
}
