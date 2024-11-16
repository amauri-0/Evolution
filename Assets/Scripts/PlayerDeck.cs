using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    [HideInInspector]  // Oculta o campo completamente do Inspector
    public List<Card> conteiner = new List<Card>();
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;

        for(int i = 0; i < 4; i++)
        {
            x = Random.Range(1, 7);
            deck[i] = CardDatabase.cardList[x];
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
