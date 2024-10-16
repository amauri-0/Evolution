using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();
    public static List<Sprite> typeList = new List<Sprite>();
    public Sprite vazio;
    public Sprite instantaneo;
    public Sprite prolongado;
    public Sprite armadilha;
    public Sprite campo;
    void Awake()
    {   
        typeList.Add(vazio);
        typeList.Add(instantaneo);
        typeList.Add(prolongado);
        typeList.Add(armadilha);
        typeList.Add(campo);
        cardList.Add(new Card(0, "None", 0, "None", 0));
        cardList.Add(new Card(1, "Aumento de fecundidade", 3, "Amplie em duas vezes a geração de filhotes por casal em sua população durante 2 rodadas.", 2));
        cardList.Add(new Card(2, "Desinteresse", 3, "Interrompa a geração de filhotes por casal na população inimiga durante 2 rodadas.", 2));
    }
}
