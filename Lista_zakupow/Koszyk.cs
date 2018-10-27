using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupow
{
    class Koszyk : ICena
    {

        List<Produkt> MojKosz = new List<Produkt>();

        public void DodajDoKoszyka(Produkt dodawanyProdukt)
        {
            MojKosz.Add(dodawanyProdukt);
        }

        public void UsunZKoszyka(uint idUsuwanegoProduktu)
        {

            for (int i = 0; i < MojKosz.Count; i++)
            {
                if (MojKosz[i].NumerProduktu == idUsuwanegoProduktu)
                {
                    MojKosz.RemoveAt(i);
                }
            }

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



        public void WyswietlCene()
        {
            decimal saldo = 0;
            foreach (var MojKosz in MojKosz)
            {
                saldo = saldo + MojKosz.Cena;
            }

            Console.WriteLine($"Salod koszyka wynosi:  {saldo} zł");

        }


        public void PodsumowanieKoszyka()

        {
            ZawartoscKoszyka();
            WyswietlCene(); 

        }


    }

}
