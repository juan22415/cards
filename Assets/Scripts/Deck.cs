using System.Collections.Generic;


namespace Structures
{


    public class  Deck
    {

        public Stack<cards> cardstack = new Stack<cards>();

        public Deck()
        {
            SuitType[] Suit = (SuitType[])System.Enum.GetValues(typeof(SuitType));
            NumberType[] Number = (NumberType[])System.Enum.GetValues(typeof(NumberType));

            foreach (NumberType numbertype in Number)
            {
                foreach (SuitType suitytpe in Suit)
                {
                    cardstack.Push(new cards(suitytpe, numbertype));
                }
            }
        }
     

    }
}
