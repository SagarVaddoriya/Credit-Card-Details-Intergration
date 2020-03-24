using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSagarVaddoriya
{
    enum CardType
    {
        Visa, MasterCard
    }

    public class Card
    {

            internal CardType TypeOfCard { get; set; }
            public string Name { get; set; }
            public long Number { get; set; }
            public string ExpirtyDate { get; set; }
            public int Ccv { get; set; }

        public override string ToString()
        {
            return $"Card Type:{TypeOfCard}\n CardHolder's Name:{Name}"+
                $"\n Card NUmber:{Number}\n Expiry Date :{ExpirtyDate}"+
                $"\n CCV: {Ccv}";
        }


    }
}
