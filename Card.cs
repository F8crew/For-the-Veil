using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "Card", menuName = "Card")]

public class Card : ScriptableObject
{
    public int id;
    public string cardName;
    public int cost;
    public string cardType;
    public bool permanent;
    public bool instant;
    public string cardDescription;
    public string color;
    public string secondColor;
    public string image;

    public Card(Card card)
    {
        
    }

    public Card(int id, string cardName, int cost, string cardType, bool permanent, bool instant, string cardDescription, string color, string secondColor, string img)
    {
        this.id = id;
        this.cardName = cardName;
        this.cost = cost;
        this.cardType = cardType;
        this.permanent = permanent;
        this.instant = instant;
        this.cardDescription = cardDescription;
        this.color = color;
        this.secondColor = secondColor;
        this.image = img;
    }

    public static Card CreateCard(int id, string cardName, int cost, string cardType, bool permanent, bool instant, string cardDescription, string color, string secondColor, string img)
    {
        return new Card(id, cardName, cost, cardType, permanent, instant, cardDescription, color, secondColor, img);
    }
    
}