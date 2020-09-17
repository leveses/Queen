using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Queen
{
    class Tabla
    {
        char[,] T;
        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

        public Tabla(char ch)
        {
            T = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i,j] = UresCella;  
                }
            }
        }
        public void Elhelyez(int N)
        {
            Random vel = new Random();
            
            for (int i = 0; i < N; i++)
            {
                int sor = vel.Next(0, 8);
                int oszlop = vel.Next(0, 8);

               while (T[sor, oszlop] == 'K')
                {
                    sor = vel.Next(0, 8);
                    oszlop = vel.Next(0, 8);
                }
                T[sor, oszlop] = 'K';
            }
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
                    Console.Write(T[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public bool UresOszlop(int oszlop)
        {
            //HF befejzni
        }
        static bool UresSor(int sor)
        {
            return true;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Tabla t = new Tabla('#');
            Console.WriteLine("Üres tábla");
            t.Megjelenit();
            t.Elhelyez(8);
            Console.WriteLine();
            t.Megjelenit();
            Console.WriteLine();
            t.UresOszlop();
            Console.ReadKey();
        }
    }
}
