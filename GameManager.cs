using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<Deck> deckList = new List<Deck>();

    public CardDatabase cardDatabase;
    public Champ champ;
    public Card card;
    public Deck deck;
    public PlayerRecources pRecources;

    public string modType;
    public int PlayedCardID;

    public bool isDAY;
    public bool isNIGHT;

    public int spellsCast;
    public int cardsCast;

    public bool playerTurn;
    public bool enemyTurn;
    public int turn;
    public int round;

    // List of card IDs to add to the deck
    private int[] cardIDsToAdd = { 3, 3, 3, 7, 7, 6, 6, 6, 4, 4, 4, 5, 5, 11, 11, 11, 17, 17, 17, 16, 16, 16, 14, 14, 12, 12, 12, 13, 13, 13, 15, 15, 9, 9, 9, 10, 10, 8, 8, 8 };

    //players hand
    private List<Card> playerHand = new List<Card>();

    // Method to get the active enemy champion

    void Start()
    {
        CreatePlayerDeck();
        InitializeGame();
    }

    private void CreatePlayerDeck()
    {
        Deck playerDeck = new Deck(cardIDsToAdd);
        deckList.Add(playerDeck);

        foreach (Card currentCard in playerDeck)
        {
            Debug.Log("Card " + currentCard.id + ": " + currentCard.cardName);
        }
    }

    private void InitializeGame()
    {
        isDAY = true;
        champ.setCardData(card);
    }

    public void DiscardCard(int amount)
    {
        // Implement discard logic
    }

    public void Draw(int amount)
    {
        if (deckList.Count < amount)
        {
            amount = deckList.Count;
        }
        for (int i = 0; i < amount; i++)
        {
            Card drawnCard = deckList[0].DrawCard();
            if (drawnCard != null)
            {
                playerHand.Add(drawnCard);
            }
        }
    }

    public void Forsee(int amount)
    {
        // Implement foresee logic
    }

    public void lookAtTopCards(int amount)
    {
        // Implement look at top cards logic
    }

    public void RemoveCard()
    {
        // Implement remove card logic
    }

    void checkDayTime()
    {
        int D = 0;
        int N = 0;

        if (!isDAY)
        {
            isNIGHT = true;
        }

        if (!isNIGHT)
        {
            isDAY = true;
        }

        if (round == 3 + D)
        {
            N += 4;
            swapDayAndNight();
        }

        if (round == 1 + D)
        {
            D += 4;
            swapDayAndNight();
        }
    }

    public void swapDayAndNight()
    {
        if (isDAY)
        {
            isDAY = false;
            isNIGHT = true;
        }
        else
        {
            isDAY = true;
            isNIGHT = false;
        }
    }

    public delegate void RoundStartEventHandler();
    public event RoundStartEventHandler OnRoundStart;

    public void roundStart()
    {
        round += 1;
        champ.CD -= 1;
        checkDayTime();

        // Invoke the event if there are any subscribers
        OnRoundStart?.Invoke();
    }

    public void turnStart()
    {
        turn += 1;
        if (turn >= 5)
        {
            pRecources.energy = 5;
        }
        else
        {
            pRecources.energy = turn;
        }

        Draw(1);
    }
}

/*
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<Deck> deckList = new List<Deck>();

    public CardDatabase cardDatabase;
    public Champ champ;
    public Card card;
    public Deck deck;
    public PlayerRecources pRecources;

    public string modType;
    public int PlayedCardID;

    public bool isDAY;
    public bool isNIGHT;

    public int spellsCast;
    public int cardsCast;


    public bool playerTurn;
    public bool enemyTurn;
    public int turn;
    public int round;

    // List of card IDs to add to the deck
    private int[] cardIDsToAdd = {}; 

    //players hand
    private List<Card> playerHand = new List<Card>();

    // Method to get the active enemy champion

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

    public void DiscardCard(int amount)
    {
        
    }

    public void Draw(int amount)
    {
        if (deckList.Count < amount)
        {
            amount = deckList.Count;
        }
        for (int i = 0; i < amount; i++)
        {
            Card drawnCard = deckList[0].DrawCard();
            if (drawnCard != null)
            {
                playerHand.Add(drawnCard);
            }

        }
    }   

    public void Forsee(int amount)
    {

    }

    public void lookAtTopCards(int amount)
    {

    }

    public void RemoveCard()
    {

    }


    void gameStart()
    {
        isDAY = true;
        
        champ.setCardData(card);
    }

    void checkDayTime()
    {
        int D = 0;
        int N = 0;

        if (!isDAY)
        {
            isNIGHT = true;
        }

        if (!isNIGHT)
        {
            isDAY = true;
        }

        if (round == 3 + D)
        {
            N += 4;
            swapDayAndNight();
        }

        if (round == 1 + D)
        {
            D += 4;
            swapDayAndNight();
        }
    }

    public void swapDayAndNight()
    {
        if(isDAY)
        {
            isDAY = false;
            isNIGHT = true;
        }
        else{
            isDAY = true;
            isNIGHT = false;
        }
    }

    public delegate void RoundStartEventHandler();
    public event RoundStartEventHandler OnRoundStart;

    public void roundStart()
    {
        round += 1;
        champ.CD -= 1; 
        checkDayTime();
        
        // Invoke the event if there are any subscribers
        OnRoundStart?.Invoke();
    }

    public void turnStart()
    {
        turn += 1;
        if(turn >= 5)
        {
            pRecources.energy = 5;
        }
        else{
            pRecources.energy = turn;
        }
        
        Draw(1);
    }

}*/