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
                
                Console.WriteLine("informe o lado x do triangulo");

                int ladox = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("informe o lado y");
                int ladoy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("informe o lado z");
                int ladoz = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("============================");
                Console.WriteLine("exibir valores ");
                Console.WriteLine("lado x " +ladox);
                Console.WriteLine("lado y " + ladoy);
                Console.WriteLine("lado z" + ladoz);

                //verificar validade do triangulo
                Console.Write("==========================");
                
                bool medidasTrianguloValida =
                    ladox+ladoy>ladoz &&
                    ladox+ladoz>ladoy &&
                    ladoy +ladoz>ladox;

                if (medidasTrianguloValida ==true)
                {
                    Console.WriteLine("triangulo e válido");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("======================================");
                    Console.WriteLine( " os valores informados nao formam um triangulo");
                    Console.ResetColor();
                }



                    string opcaoContinuar = Console.ReadLine()!.ToUpper();







                Console.Write("deseja continuar s/n");
                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
