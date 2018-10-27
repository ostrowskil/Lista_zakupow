using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupow
{
    class Produkt: ICena    
    {

        public string NazwaProduktu { get; private set; }
        public decimal NumerProduktu { get; private set; }
        public string Opis { get; set; }
        public uint Cena { get; set; }

        public Produkt(string nazwaproduktu, decimal numerproduktu, string opis, uint cena)
        {
            NazwaProduktu = nazwaproduktu;
            NumerProduktu = numerproduktu;
            Opis = opis;
            Cena = cena;
        }

        public void WyswietlCene()
        {
            Console.WriteLine($"Cena {NazwaProduktu} wynosi: {Cena} zł"); 
        }
    }
}
