using System;
using System.Collections.Generic;
using System.Text;

namespace OdevDictonary
{
    class MyDictionary<A,P>
    {
        A[] Ad;
        P[] Puan;
        public MyDictionary()   //ctor 
        {
            Ad = new A[0];
            Puan = new P[0];
        }


        public void Add(A Ads, P Puans)
        {
            A[] tempAd = Ad;
            P[] tempPuan= Puan;
            Ad = new A[Ad.Length + 1];
            Puan = new P[Puan.Length + 1];

            for (int i = 0; i < tempAd.Length; i++)
            {
                Ad[i] = tempAd[i];
                Puan[i] = tempPuan[i];
            }

            Ad[Ad.Length - 1] = Ads;
            Puan[Puan.Length - 1] = Puans;
        }


    }
}
