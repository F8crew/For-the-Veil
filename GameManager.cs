using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<Deck> deckList = new List<Deck>();

    public CardDatabase cardDatabase;

    public string modType;
    public int PlayedCardID;

    // List of card IDs to add to the deck
    private int[] cardIDsToAdd = {}; 

    void Start()
    {
        int[] cardIDs = new int[] { 3, 3, 3, 7, 7, 6, 6, 6, 4, 4, 4, 5, 5, 11, 11, 11, 17, 17, 17, 16, 16, 16, 14, 14, 12, 12, 12, 13, 13, 13, 15, 15, 9, 9, 9, 10, 10, 8, 8, 8 };
        
        Deck playerDeck = new Deck(cardIDs);
        // Iterate through the card IDs to add
        foreach (int cardID in cardIDsToAdd)
        {
            // Retrieve the card from the CardDatabase using the cardID
            Card card = CardDatabase.GetCardById(cardID); // Use GetCardById instead of GetCardByID

            if (card != null)
            {
                playerDeck.AddCard(card); // Assuming AddCard method exists in Deck class
            }
        }

        deckList.Add(playerDeck);

        foreach (Card currentCard in playerDeck)
        {
            Debug.Log("Card " + currentCard.id + ": " + currentCard.cardName);
        }
    }

    public void PlayCard()
    {
        switch (PlayedCardID)
        {
            case 0:
                break;
            
            case 1:
                break;
            
            case 2:
                break;

            case 3:
                PlayCard3();
                break;
            
            case 4:
                PlayCard4();
                break;
            
            case 5:
                PlayCard5();
                break;
            
            case 6:
                PlayCard6();
                break;
            
            case 7:
                PlayCard7();
                break;
            
            case 8:
                PlayCard8();
                break;
            
            case 9:
                PlayCard9();
                break;

            case 10:
                PlayCard10();
                break;
            
            case 11:
                PlayCard11();
                break;
            
            case 12:
                PlayCard12();
                break;
            
            case 13:
                PlayCard13();
                break;
            
            case 14:
                PlayCard14();
                break;
            
            case 15:
                PlayCard15();
                break;
            
            case 16:
                PlayCard16();
                break;
            
            case 17:
                PlayCard17();
                break;
            
        }
    }

    public void PlayCard3()
    {
        
    }

    public void PlayCard4()
    {
        
    }

    public void PlayCard5()
    {
        
    }

    public void PlayCard6()
    {
        
    }

    public void PlayCard7()
    {
        
    }

    public void PlayCard8()
    {
        
    }

    public void PlayCard9()
    {
        
    }

    public void PlayCard10()
    {
        
    }

    public void PlayCard11()
    {
        
    }

    public void PlayCard12()
    {
        
    }

    public void PlayCard13()
    {
        
    }

    public void PlayCard14()
    {
        
    }

    public void PlayCard15()
    {
        
    }

    public void PlayCard16()
    {
        
    }

    public void PlayCard17()
    {
        
    }
}