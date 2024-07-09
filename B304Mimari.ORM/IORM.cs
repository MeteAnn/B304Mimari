using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace B304Mimari.ORM
{
    public interface IORM<T>
    {

        DataTable Listele();
        bool Ekle(T entity);

        bool Guncelle(T entity);

        bool Sil(int id);




    }
}