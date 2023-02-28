using System;

while (true)
{
    try
    {
       
        //Menu
        Console.WriteLine($"Menu\n____________________\n1 addieren\n2 subtrahieren\n3 multiplizieren\n4 Dividieren\n5 Abbrechen");
        Console.Write($"____________________\nGeben sie die zahl ein: ");
        double eigabe = Convert.ToDouble(Console.ReadLine());
        Console.Clear();



        // zahlen
        if (eigabe > 0 && eigabe <= 4)
        {
            Console.Write($"Geben sie die erste zahl ein: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Geben sie die erste zahl ein: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"_______________");
            Console.Clear();




            // Ausgabe
            if (eigabe == 1)
            {
                Console.WriteLine($"Ergebniss = {addieren(x, y)}\n________________");
                
            }

            else if (eigabe == 2)
            {
                Console.WriteLine($"Ergebniss = {subtrahieren(x, y)}\n________________");
                break;
            }

            else if (eigabe == 3)
            {
                Console.WriteLine($"Ergebniss = {multiplizieren(x, y)}\n________________");
                break;
            }

            else if (eigabe == 4)
            {
                Console.WriteLine($"Ergebniss = {dividieren(x, y)} \n________________");
                break;
            }




            // Methoden
            static double subtrahieren(double x, double y)
            {

                return x - y;

            }
            static double multiplizieren(double x, double y)
            {

                return x * y;

            }

            static double addieren(double x, double y)
            {

                return x + y;

            }

            static string dividieren(double x, double y)
            {
                try
                {
                    if (y != 0)
                    {
                        return (x / y).ToString();

                    }

                    else
                    {
                        return "Error nicht durch 0 dividerbar";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString);
                    return "Error";
                }
            }
        }
        else if (eigabe == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine($"Falsche eingabe\n______________");
          
        }
    }



    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
