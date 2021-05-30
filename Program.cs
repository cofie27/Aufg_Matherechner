using System;

namespace Aufg_Matherechner
{
    class Program
    {
        static void Main(string[] args)
        {
           //statt Konstruktor könnte man die Attribute hier definiere
           //long radius = 23;
           //double seiteA = 14,55;                             
           //double seiteB = 3,9434;
           //ulong riesenzahl = 12223175122789154358;
           

            double pi = 3.14159265359;                                                                      //Attribut pi deklariert (wichtig, um zu rechnen)
            Mathematik x = new Mathematik(23, 14.55, 3.9434, 12223175122789154358);                         //im neuen Obnjekt x der Klasse Mathematik werden die Parameter für die Attribute radius, seiteA, seiteB und riesenzahl gespeichert
            x.flaecheKreis = Convert.ToSingle(pi * (x.radius * x.radius));                                  //Attribut des Objektes x wird berechnet
            x.flaecheRechteck = Convert.ToSingle(x.seiteA * x.seiteB);                                      //Attribut des Objektes x wird berechnet
            x.umfangKreis = Convert.ToSingle((2 * pi) * x.radius);                                          //Attribut des Objektes x wird berechnet
            x.volumenKugel = Convert.ToSingle((4.0 / 3) * pi * (x.radius * x.radius * x.radius));             //Attribut des Objektes x wird berechnet
            x.durchmesser = 2 * x.radius;                                                                   //Attribut des Objektes x wird berechnet
            x.rest19 = Convert.ToInt16(x.riesenzahl % 19);                                                  //Attribut des Objektes x wird berechnet
            Console.WriteLine("Kreisflaeche: " + x.flaecheKreis);                                           //auf der Konsole ausgeben
            Console.WriteLine("Rechteckflaeche: " + x.flaecheRechteck);                                     //auf der Konsole ausgeben
            Console.WriteLine("Kreisumfang: " + x.umfangKreis);                                             //auf der Konsole ausgeben
            Console.WriteLine("Kugelvolumen: " + x.volumenKugel);                                           //auf der Konsole ausgeben
            Console.WriteLine("Durchmesser: " + x.durchmesser);                                             //auf der Konsole ausgeben
            Console.WriteLine("Rest 19: " + x.rest19);                                                      //auf der Konsole ausgeben

            Console.ReadKey();
        }

    }
}
