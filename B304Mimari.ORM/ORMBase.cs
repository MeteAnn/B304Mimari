using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace B304Mimari.ORM
{
    public class ORMBase<TT> : IORM<TT>
    {
        public bool Ekle(TT entity)
        {
            throw new NotImplementedException();
        }

        public bool Guncelle(TT entity)
        {
            throw new NotImplementedException();
        }

        public DataTable Listele()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}