using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Structures
{
    public static class ShuffleDeck 

    {
        public static Stack<cards> Shuffle(this Stack<cards> cards)
        {
            

            cards[] arrayDeck = new cards[cards.Count ];
            cards.CopyTo(arrayDeck, 0);

            

            // Knuth shuffle algorithm :: courtesy of Wikipedia :)
            for (int t = 0; t < arrayDeck.Length; t++)
                {
                    cards tmp = arrayDeck[t];
                    int r = UnityEngine.Random.Range(t, arrayDeck.Length);
                    arrayDeck[t] = arrayDeck[r];
                    arrayDeck[r] = tmp;
                }

            Stack<cards> stack3 = new Stack<cards>(arrayDeck);


            return stack3;

            
        }


    }

}
