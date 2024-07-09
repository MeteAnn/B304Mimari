using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using Microsoft.Data.SqlClient;


namespace B304Mimari.ORM
{
    public class Tools
    {
        //Singleton Pattern
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {

                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalBaglanti"].ConnectionString);


                }


                //baglanti = baglanti ?? new SqlConnection(); //baglantiya atama yap baglanti null sa newle


                return baglanti;



            }
            set { baglanti = value; }



        }




    }
}