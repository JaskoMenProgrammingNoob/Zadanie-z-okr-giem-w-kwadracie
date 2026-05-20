class program
{

    static void Main(string [] args)
    {
        double x;
        double y;
        double r = 1;
        double iloscpunktowi = 0;
         double n = 1000000 ;
        double pi;
        for (int i = 0; i <= n; i++)
        {
            Random random = new Random();
            x = random.NextDouble();
            y = random.NextDouble();
            /* Console.WriteLine($"{x}");
            Console.WriteLine(y); */
            if(x*x + y*y <= r*r)
            {
                iloscpunktowi += 1;
                
            }
        }

        Console.WriteLine($"Ilość x w obszarze: {iloscpunktowi}");
        
        r = iloscpunktowi / n;
        Console.WriteLine(r);
        pi = 4.0 * r;
        Console.WriteLine($"Pi = {pi}");
    }






}