using static System.Console;
namespace CoreEscuela.Util

{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
           {
                WriteLine("".PadLeft(tam, '='));
            }
             public static void WriteTitle(string titulo)
           {
               var tamaño = titulo.Length +4;
               DibujarLinea(tamaño);
               WriteLine($"| {titulo} |");
               DibujarLinea(tamaño);
            }
            public static void Beep(int Hz = 2000, int Tiempo=500, int Cantidad= 10 )
            {
               while (Cantidad-- > 0)
               {
                   System.Console.Beep(Hz, Tiempo);
                
               }
            }
    } 
}