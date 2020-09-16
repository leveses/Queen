using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Queen
{
    class Tabla
    {
        char[,] tomb;
        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

        public Tabla(char ch)
        {
            tomb = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tomb[i,j] = UresCella;  
                }
            }
        }
        static void Elhelyez()
        { 
            
        }
        static void FajlbaIr()
        { 
        
        }
        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    Console.Write(tomb[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static int UresOszlop()
        {
            return 0;
        }
        static int UresSor()
        {
            return 0;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Tabla t = new Tabla('#');
            Console.WriteLine("Üres tábla");
            t.Megjelenit();
            Console.ReadKey();
        }
    }
}
