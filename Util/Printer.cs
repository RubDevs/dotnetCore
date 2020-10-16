using static System.Console;
namespace CoreEscuela.Util
{
    //El modificador de acceso static hace que la clase no permita hacer instancias
    //sus metodos se usan invocando directamente a la clase, se comporta como un objeto
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            //Padleft rellena el string con el caracter indicado y el tamano indicado
            var linea = "".PadLeft(tam,'=');
            WriteLine(linea);
        }

        public static void writeTitle(string titulo)
        {
            DibujarLinea(titulo.Length);
            WriteLine(titulo);
            DibujarLinea(titulo.Length);
        }
    }
}