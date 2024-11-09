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
        Card card = Card.CreateCard(0, "None", 0, "None", false, false, "None", "None", "None", "SpriteName");

        //Champions
        Card card1 = Card.CreateCard(1, "Vilethorn Revenant", 0, "Champion", true, false, "", "Purple", "Blue", "Name");
        Card card2 = Card.CreateCard(2, "Vespera", 0, "Champion", true, false, "", "Green", "Purple", "Name");

        //Cards (might make it so i split them even further into both color, type, and more)
        Card card3 = Card.CreateCard(3, "Shield", 1, "Spell", false, true, "Target champion gains 2 shield.", "Green", "None", "Shield");
        Card card4 = Card.CreateCard(4, "Natures Wrath", 3, "Spell", false, false,"Deal 2 damage to each enemy champion. If your active champion has more HP than the active enemy champion, your active champion gains shield equal to the damage dealt to the active enemy champion", "Green", "None", "Natures Wrath");
        Card card5 = Card.CreateCard(5, "Repair the Land", 2, "Spell", false, false, "Heal target champion 3 HP. Draw a card.", "Green", "None", "Repair the Land");
        Card card6 = Card.CreateCard(6, "Enchanted Vines", 3, "Mod", true, false, "The first time the equipped champions looses all its shield each round, it gains 2 shield.", "Green", "None", "Enchanted Vines");
        Card card7 = Card.CreateCard(7, "Vengeful Thorns", 5, "Mod", true, false, "Whenever the equipped champion takes damage to their shield, deal that amount of damage to the active enemy champion.", "Green", "None", "Vengeful Thons");
        Card card8 = Card.CreateCard(8, "Forsight Ritual", 2, "Spell", false, true, "Forsee 3. You may draw a card. If you have cast two or more spells this turn gain 1 energy.", "Blue", "None", "Forsight Ritual");
        Card card9 = Card.CreateCard(9, "Aetheric Shield", 3, "Mod", true, false, "When your opponent plays a card, gain 1 shield. If it was their second card that turn gain 2 shield instead.", "Blue", "None", "Aetheric Shield");
        Card card10 = Card.CreateCard(10, "Mana Flux", 5, "Mod", true, false, "Whenever you cast a spell gain 1 energy. his ability can only trigger twice per round.", "Blue", "None", "Mana Flux");
        Card card11 = Card.CreateCard(11, "Heart of the Cards", 0, "Spell", false, true, "Draw a card and reveal it. You take damage equal to half its cost.", "Purple", "None", "Heart of the Cards");
        Card card12 = Card.CreateCard(12, "Blood Offering", 3, "Mod", true, false, "Equipped champion gains: Take 2 damage to daw a card.", "Purple", "None", "Blood Offering");
        Card card13 = Card.CreateCard(13, "Just the One", 2, "Spell", false, false, "Whenever the equipped champion takes damage from their own ability, mods, or ", "Purple", "None", "Just the One");
        Card card14 = Card.CreateCard(14, "Tainted Madness", 2, "Mod", true, false, "Discard a card to deal 3 damage to target champion", "Purple", "None", "Tainted Madness");
        Card card15 = Card.CreateCard(15, "Vampiric Embrace", 5, "Mod", true, false, "Whenever the equipped champion deals damage, heal equal to half the damage dealt that way.", "Purple", "None", "Vampiric Embrace");
        Card card16 = Card.CreateCard(16, "Twilight Sacrifice", 3, "Spell", false, true, "Sacrifice all shield on target champion to draw a card for every 2 shield sacrificed this way.", "Purple", "None", "Twilight Sacrifice");
        Card card17 = Card.CreateCard(17, "Doomed Weapon", 3, "Mod", true, false, "Tap: Deal 4 damage to the active enemy champion, your active champion takes 2 damage.", "Purple", "None", "Doomed Weapon");


        cardList.Add(card);
        cardList.Add(card1);
        cardList.Add(card2);
        cardList.Add(card3);
        cardList.Add(card4);
        cardList.Add(card5);
        cardList.Add(card6);
        cardList.Add(card7);
        cardList.Add(card8);
        cardList.Add(card9);
        cardList.Add(card10);
        cardList.Add(card11);
        cardList.Add(card12);
        cardList.Add(card13);
        cardList.Add(card14);
        cardList.Add(card15);
        cardList.Add(card16);
        cardList.Add(card17);


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