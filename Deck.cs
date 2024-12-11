using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        cards = cardIDs.Select(id => CardDatabase.GetCardById(id)).Where(card => card != null).ToList();
    }

    // Constructor that takes a card
    public Deck(Card card)
    {
        cards = new List<Card> { card };
    }

    public void AddCard(Card card)
    {
        if (card != null)
        {
            cards.Add(card);
        }
    }

    public List<Card> GetCards()
    {
        return cards.ToList();
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
        cards = cards.OrderBy(x => Guid.NewGuid()).ToList();
    }
}