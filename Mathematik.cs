using System;
using System.Collections.Generic;
using System.Text;

namespace Aufg_Matherechner
{
    class Mathematik
    {
        //Attribute deklarieren
        public ulong radius;                         //wenn Wert mit Nachkommastellen, dann double
        public double seiteA;
        public double seiteB;
        public ulong riesenzahl;
        public float flaecheKreis;
        public float flaecheRechteck;
        public float umfangKreis;
        public float volumenKugel;
        public float durchmesser;
        public short rest19;

        //Konstrukter: Die Parameter die gleichbleiben werden übergeben anstatt die Attribute in der Mainmethode zu ?definieren?
        public Mathematik(ulong pRadius, double pSeiteA, double pSeiteB, ulong pRiesenzahl)
        {
            radius = pRadius;
            seiteA = pSeiteA;
            seiteB = pSeiteB;
            riesenzahl = pRiesenzahl;
        
        }

    }
}
