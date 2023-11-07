namespace Examen__R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran  = new Random();
            Ejercicios ejercicios = new Ejercicios();
            
            ejercicios.Calificaciones();
            ejercicios.Vendedor();  
        }
    }
}