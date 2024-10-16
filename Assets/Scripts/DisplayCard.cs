using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{

    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int cardId;
    public string cardName;
    public int cardEnergy;
    public string cardDescription;
    public int cardType;
    public Image cardTypeImage;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI energyText;
    public TextMeshProUGUI descriptionText;

    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
    }

    // Update is called once per frame
    void Update()
    {
        cardId = displayCard[0].cardId;
        cardName = displayCard[0].cardName;
        cardEnergy = displayCard[0].cardEnergy;
        cardDescription = displayCard[0].cardDescription;
        cardType = displayCard[0].cardType;
        cardTypeImage.sprite = CardDatabase.typeList[cardType];

        nameText.text = " " + cardName;
        energyText.text = " " + cardEnergy;
        descriptionText.text = " " + cardDescription;
    }
}
