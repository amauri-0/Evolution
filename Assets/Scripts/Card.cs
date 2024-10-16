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
    public int cardType; // 1: Instantâneo, 2: Prolongado, 3: Armadilha, 4: Campo


    public Card(int CardId, string CardName, int CardEnergy, string CardDescription, int CardType)
    {
        cardId = CardId;
        cardName = CardName;
        cardEnergy = CardEnergy;
        cardDescription = CardDescription;
        cardType = CardType;
    }


}
