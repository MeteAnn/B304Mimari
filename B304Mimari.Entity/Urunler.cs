using System;
using System.Collections.Generic;
using System.Text;

namespace B304Mimari.Entity
{
    public class Urunler
    {

        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public decimal BirimFiyati { get; set; }

        public short HedefStokDuzeyi { get; set; }

        public short YeniSatis { get; set; }
        public int EnAzYenidenSatisMikatari { get; set; }

        public bool Sonlandi { get; set; }

    }
}
