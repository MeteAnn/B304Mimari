using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace B304Mimari.ORM
{
    public class Tools
    {

        private SqlConnection baglanti;

        public SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }



        }




    }
}
