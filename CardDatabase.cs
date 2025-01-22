using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Start()
    {
        Debug.Log("CardDatabase script started");
    }

    void Awake()
    {
        InitializeCards();
    }

    private void InitializeCards()
    {
        // Champions
        Card card1 = Card.CreateCard(1, "Vilethorn Revenant", 0, "Champion", true, false, "", "Purple", "Blue", "SpriteName");
        Card card2 = Card.CreateCard(2, "Vespera", 0, "Champion", true, false, "", "Green", "Purple", "SpriteName");
        Card card67 = Card.CreateCard(0, "Karnak", 0, "Champion", true, false, "", "Green", "Red", "SpriteName");
        Card card68 = Card.CreateCard(0, "Sreaphina", 0, "Champion", true, false, "", "Red", "Yellow", "SpriteName");
        Card card69 = Card.CreateCard(0, "Eirwen", 0, "Champion", true, false, "", "Yellow", "Blue", "SpriteName");
        Card card70 = Card.CreateCard(0, "Sreaphina", 0, "Champion", true, false, "", "Red", "Yellow", "SpriteName");

        // Cards
        Card card3 = Card.CreateCard(3, "Shield", 1, "Spell", false, true, "Target champion gains 2 shield.", "Green", "None", "Shield");
        Card card4 = Card.CreateCard(4, "Natures Wrath", 3, "Spell", false, false, "Deal 2 damage to each enemy champion. If your active champion has more HP than the active enemy champion, your active champion gains shield equal to the damage dealt to the active enemy champion", "Green", "None", "Natures Wrath");
        // ... rest of the cards

        // Add cards to the list
        cardList.Add(Card.CreateCard(0, "None", 0, "None", false, false, "None", "None", "None", "SpriteName"));
        cardList.Add(card1);
        cardList.Add(card2);
        cardList.Add(card3);
        cardList.Add(card4);
        // ... rest of the cards

        // Use a loop to add cards to the list
        Card[] cards = new Card[]
        {
            card1, card2, card3, card4, // ... rest of the cards
        };
        cardList.AddRange(cards);

        Debug.Log("CardDatabase.cardList count: " + cardList.Count);
        foreach (Card currentCard in cardList)
        {
            Debug.Log("Card " + currentCard.id + ": " + currentCard.cardName);
        }
    }

    public static Card GetCardById(int id)
    {
        Card card = cardList.Find(c => c.id == id);
        return card != null ? new Card(card) : null; // Return a new instance of the card
    }
}