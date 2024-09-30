using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(1, "Bode", 2, 1, "Isso é um bode"));
        cardList.Add(new Card(2, "Urso", 3, 3, "Isso é um urso"));
        cardList.Add(new Card(3, "Coelho", 4, 4, "Isso é um coelho"));
        cardList.Add(new Card(4, "Baleia", 5, 5, "Isso é uma baleia"));
        
    }
}
