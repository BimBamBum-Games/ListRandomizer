using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityRandomizer {
    //Random classindan instance olustur. C# built-in random sinidir.
    public static System.Random rnd = new System.Random();

    //IList tipinde bir (interface) input alir ve metod C# extension olarak tanimlidir.
    public static void RandIt<T>(this IList<T> list) {
        //Liste uzunlugunu al.
        int listCount = list.Count;
        while(listCount > 1) {
            //n sayisini her dongude azaltar n sayisina kadarlık olan sayilar random olarak secilebilir.
            listCount--;
            //n sayisina kadar olan sayilardan random olarak secileb index anlamina gelir.
            int k_zero_to_n = rnd.Next(listCount + 1);
            //k artik random index ve degeri depolanir.
            T kval = list[k_zero_to_n];
            //n degeri artik random indexe tasinir.
            list[k_zero_to_n] = list[listCount];
            //Yedeklenen k index degeri n indexine tasinir.
            list[listCount] = kval;
        }
    }
}
