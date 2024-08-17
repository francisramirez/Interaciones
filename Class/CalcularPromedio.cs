namespace Interaciones.Class
{
    public class CalcularPromedio
    {
        public void Calcular()
        {
            int suma = 0;
            decimal promedio = 0;
            int cantidad = 0;
            int valor = 0;


            Console.WriteLine("digite la cantidad que desea calcular: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"Digite el valor {i}: ");
                valor = Convert.ToInt32(Console.ReadLine());

                // suma += valor;

                suma = suma + valor;

            }

            promedio = (suma / cantidad);

            Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");

        }

        public void CalcularNotas()
        {
            int aprobado = 0;
            int reprobado = 0;
            int cantidad = 0;
            int calificacion = 0;

            Console.WriteLine("digite la cantidad que desea calcular: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"ingrese la calificacion {i}");

                calificacion = Convert.ToInt32(Console.ReadLine());


                if (calificacion >= 7)
                {
                    aprobado = aprobado + 1;
                    // aprobado++;
                }
                else
                {
                    reprobado = reprobado + 1;
                    //reprobado++;
                }
            }

            Console.WriteLine($"Aprobados: { aprobado } y reproprogrados: { reprobado } ");

        }

        public void CalcularPromerdioWhile()
        {
            int suma = 0;
            decimal promedio = 0;
            int cantidad = 0;
            int valor = 0;
            int index = 1;

            Console.WriteLine("digite la cantidad que desea calcular: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (index <= cantidad)
            {
                Console.WriteLine($"Digite el valor { index }: ");
                valor = Convert.ToInt32(Console.ReadLine());
                suma += valor;
                index++;
            }

            promedio = (suma / cantidad);

            Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");
        }

        public void CalcularLote() 
        {
            int cantidad = 0;
            int index = 1;
          
            double longitudBaja= 1.20;
            double longitudAlta = 1.30;
            float largo = 0;
            int cantPiezas = 0;
           

            Console.WriteLine("Cuantas piezas va a procesar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (index <= cantidad)
            {
                Console.WriteLine($"Digite la medida de la pieza { index } : ");
                
                largo = float.Parse(Console.ReadLine());

                if (largo >= longitudBaja && largo <= longitudAlta)
                {
                    cantPiezas++;
                }

                index++;
            }

            Console.WriteLine($"La cantidada de piezas a procesar: { cantidad } cantidad de piezas aptas: { cantPiezas }");


        }
        public void AgregarPiezasActas(int pieza) 
        {
            List<int> piezzas = new List<int>();
            piezzas.Add( pieza );
        }
    }
}
