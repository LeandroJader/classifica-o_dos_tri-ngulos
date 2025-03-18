namespace classificação_dos_triângulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {







                Console.Clear();
                Console.WriteLine("=========================") ;
                Console.WriteLine("Classificador de triangulos");
                Console.WriteLine("=========================");
                
                Console.WriteLine("informe o lado x do triangulo");

                int ladox = Convert.ToInt32(Console.ReadLine());
                Console.Write("informe o lado y");
                int ladoy = Convert.ToInt32(Console.ReadLine());
                Console.Write("informe o lado z");
                int ladoz = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("============================");
                Console.WriteLine("exibir valores ");
                Console.WriteLine("lado x "+ladox);
                Console.WriteLine("lado y "+ ladoy);
                Console.WriteLine("lado z"+ ladoz);

                Console.Write("==========================");

                string opcaoContinuar = Console.ReadLine().ToUpper();







                Console.Write("deseja continuar s/n");
                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
