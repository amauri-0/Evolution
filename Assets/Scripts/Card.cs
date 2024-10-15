using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int cardId;
    public string cardName;
    public int cardEnergy;
    public string cardDescription;
    

    public Card(int CardId, string CardName, int CardEnergy, string CardDescription)
    {
        cardId = CardId;
        cardName = CardName;
        cardEnergy = CardEnergy;
        cardDescription = CardDescription;
    }


}
