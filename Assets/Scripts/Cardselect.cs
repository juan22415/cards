using UnityEngine;


namespace Structures
{ 
public class Cardselect : MonoBehaviour

{

    Deck MyDeck = new Deck();
    SuitType Suit = new SuitType();
    NumberType Number = new NumberType();

    private void Start()
    {
        MyDeck.cardstack = ShuffleDeck.Shuffle(MyDeck.cardstack);
    }   
    
    public void Clickgetcard()
    {
        GetfirstCard();
    }
    public void Clickshufllecards()
    {

        MyDeck.cardstack = ShuffleDeck.Shuffle(MyDeck.cardstack);
        Debug.Log("Deck Shuffled");
    }

    private void GetfirstCard()
    {
        
        cards firstcard = new cards(Suit, Number);
        firstcard = MyDeck.cardstack.Peek();
        string message = string.Format("The card is: {0} of  {1} ", firstcard.Number, firstcard.Suit);
        Debug.Log(message);
            
        }

}


}
