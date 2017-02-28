namespace Structures
{ 
public class cards  {

        public SuitType Suit
        {
            get;
            set;
        }

        public NumberType Number
        {
            get;
            set;
        }

        public cards(SuitType suit, NumberType number)
        {

            Suit = suit;
            Number = number;
        }

    }
}



