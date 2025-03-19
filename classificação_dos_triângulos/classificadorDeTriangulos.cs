
namespace classificação_dos_triângulos;

public static class classificadorDeTriangulos
{
    public static bool MedidasFormamTrianguloValido(int ladox, int ladoy, int ladoz)
    {

        bool medidasTrianguloValida =
             ladox + ladoy > ladoz &&
             ladox + ladoz > ladoy &&
             ladoy + ladoz > ladox;
        return medidasTrianguloValida;
    }
     public  static string ClassificarTriangulo(int ladox, int ladoy, int ladoz)
    {
        string TipoTriangulo = "nao classificado";


        if (ladox == ladoy && ladoy == ladoz)
            TipoTriangulo = "Equilátero";



        else if (ladox != ladoy && ladoy != ladoz && ladox != ladoz)
            TipoTriangulo = "Escaleno";


        else
            TipoTriangulo = "isósceles";

        return TipoTriangulo;
    }


}
