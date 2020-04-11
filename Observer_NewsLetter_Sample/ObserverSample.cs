using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_NewsLetter_Sample
{
    class ObserverSample
    {


        public static void Demo() 
        {
            var skroutz = new Skroutz("Welcome to Skroutz");

            var Stroggulos = new Subscriber("Stroggulos", skroutz);
            var Rizos = new Subscriber("Rizos", skroutz);

            skroutz.Attach(Rizos);
            skroutz.Attach(Stroggulos);

            skroutz.Message = $"All our products have 50 % discount for one month \n";
            skroutz.Message = $"Merry Christmas and Happy new Year!!! \n";

            skroutz.Dettach(Rizos);
            skroutz.Message = $"Summer is coming! Take a look at Skroutz's Summer Clothes \n";

            Console.ReadKey();


        }



    }
}
