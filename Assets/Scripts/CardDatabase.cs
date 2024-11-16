using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(Resources.LoadAll<Card>("Cards"));
    // Start is called before the first frame update
}