using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupow
{
    class Koszyk
    {

        List<Produkt> MojKosz = new List<Produkt>();

        public void DodajDoKoszyka(Produkt dodawanyProdukt)
        {
            MojKosz.Add(dodawanyProdukt);
        }

        public void UsunZKoszyka()
        {


        }

        public void ZawartoscKoszyka()
        {
            int i = 0;
            foreach (var MojKosz in MojKosz)
            {
                ++i;
                Console.WriteLine($"{i} Produkt : {MojKosz.NazwaProduktu} ; ID: {MojKosz.NumerProduktu}; Cena: {MojKosz.Cena} zł");
            }





        }


    }
}
