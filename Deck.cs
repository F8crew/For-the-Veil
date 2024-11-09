using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : IEnumerable<Card>
{
    private List<Card> cards;

    // Implement the GetEnumerator method for IEnumerable<Card>
    public IEnumerator<Card> GetEnumerator()
    {
        return cards.GetEnumerator();
    }

    // Explicit interface implementation for non-generic IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Default constructor
    public Deck(int[] cardIDs)
    {
        cards = new List<Card>();
        foreach (int id in cardIDs)
        {
            // Assuming you have a method to get a Card by its ID
            Card card = CardDatabase.GetCardById(id);
            if (card != null)
            {
                cards.Add(card);
            }
        }
    }

    // Constructor that takes a card
    public Deck(Card card)
    {
        cards = new List<Card> { card };
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public List<Card> GetCards()
    {
        return cards;
    }
    
    public Card DrawCard()
    {
        if (cards.Count == 0) return null;
        Card drawnCard = cards[0];
        cards.RemoveAt(0);
        return drawnCard;
    }

    public void Shuffle()
    {
        // Shuffle logic (e.g., using Fisher-Yates algorithm)
    }
}