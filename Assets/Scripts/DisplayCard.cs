using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    // Lista de cartas, ser� preenchida automaticamente
    public List<Card> displayCard = new List<Card>();
    public int displayId; // �ndice da carta a ser exibida

    // Componentes de UI para exibir as informa��es da carta
    public Image cardTypeImage;
    public Image cardImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI energyText;
    public TextMeshProUGUI descriptionText;

    // Start is called before the first frame update
    void Start()
    {
        // Carrega todas as cartas da pasta "Resources/Cards"
        displayCard = CardDatabase.cardList;

        // Verifica se a lista foi carregada corretamente
        if (displayCard.Count > 0 && displayId < displayCard.Count)
        {
            // Atualiza a carta com base no ID fornecido
            UpdateCardDisplay();
        }
        else
        {
            Debug.LogError("Nenhuma carta encontrada ou displayId fora do intervalo.");
        }
    }

    // M�todo que atualiza a exibi��o da carta
    void UpdateCardDisplay()
    {
        // Acessa o Card selecionado
        Card card = displayCard[displayId];

        // Atualiza os campos do UI com base nos dados do Card
        nameText.text = card.cardName;
        energyText.text = card.cardEnergy.ToString();
        descriptionText.text = card.cardDescription;
        cardImage.sprite = card.cardImage;

        // Define a imagem do tipo de carta usando o cardSymbol carregado automaticamente
        card.LoadCardSymbol();
        cardTypeImage.sprite = card.cardSymbol;
    }

    // Update � chamado uma vez por frame, se necess�rio (opcional para anima��es din�micas)
    void Update()
    {
        UpdateCardDisplay();
        // Se precisar atualizar constantemente, por exemplo, em tempo real, chame UpdateCardDisplay aqui.
    }

    public void NextCard()
    {
        displayId++;
        if (displayId >= displayCard.Count)
        {
            displayId = 1;
        }
    }
}
