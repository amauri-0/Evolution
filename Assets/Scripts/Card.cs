using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public enum CardType
    {
        Instantaneo,
        Prolongado,
        Armadilha,
        Campo
    }

    public int cardId;
    public string cardName;
    public int cardEnergy;
    public string cardDescription;
    public Sprite cardImage;
    public CardType cardType; // enum selecionável no Inspector

    [HideInInspector]  // Oculta o campo completamente do Inspector
    public Sprite cardSymbol;

    // Método para carregar o símbolo da carta automaticamente da pasta "Resources"
    public void LoadCardSymbol()
    {
        // Monta o caminho do sprite com base no nome do tipo de carta
        string spritePath = "CardSymbols/" + cardType.ToString();

        // Carrega o sprite da pasta "Resources/CardSymbols"
        cardSymbol = Resources.Load<Sprite>(spritePath);

        // Verifica se o sprite foi carregado corretamente
        if (cardSymbol == null)
        {
            Debug.LogError($"Sprite para o tipo {cardType} não encontrado em {spritePath}");
        }
    }
}

