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
        Card card1 = Card.CreateCard(1, "Vilethorn Revenant", 0, "Champion", true, false, "", "Purple", "Blue", "SpriteName");
        Card card2 = Card.CreateCard(2, "Vespera", 0, "Champion", true, false, "", "Green", "Purple", "SpriteName");
        Card card67 = Card.CreateCard(0, "Karnak", 0, "Champion", true, false, "", "Green", "Red", "SpriteName");
        Card card68 = Card.CreateCard(0, "Sreaphina", 0, "Champion", true, false, "", "Red", "Yellow", "SpriteName");
        Card card69 = Card.CreateCard(0, "Eirwen", 0, "Champion", true, false, "", "Yellow", "Blue", "SpriteName");
        Card card70 = Card.CreateCard(0, "Sreaphina", 0, "Champion", true, false, "", "Red", "Yellow", "SpriteName");

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
        Card card13 = Card.CreateCard(13, "Just the One", 2, "Spell", false, false, "Look at the top 3 cards of your deck, draw one of them and discard the two others", "Purple", "None", "Just the One");
        Card card14 = Card.CreateCard(14, "Tainted Madness", 2, "Mod", true, false, "Whenever the equipped champion takes damage from their own ability, mods, or waepons. Deal 1 damage to target enemy champion. ", "Purple", "None", "Tainted Madness");
        Card card15 = Card.CreateCard(15, "Vampiric Embrace", 5, "Mod", true, false, "Whenever the equipped champion deals damage, heal equal to half the damage dealt that way.", "Purple", "None", "Vampiric Embrace");
        Card card16 = Card.CreateCard(16, "Twilight Sacrifice", 3, "Spell", false, true, "Sacrifice all shield on target champion to draw a card for every 2 shield sacrificed this way.", "Purple", "None", "Twilight Sacrifice");
        Card card17 = Card.CreateCard(17, "Doomed Weapon", 3, "Mod", true, false, "Tap: Deal 4 damage to the active enemy champion, your active champion takes 2 damage.", "Purple", "None", "Doomed Weapon");
        Card card18 = Card.CreateCard(18, "Flow of Magic", 5, "Mod", true, false, "All spells cost 1 energy less to cast", "Yellow", "None", "Flow of Magic");
        Card card19 = Card.CreateCard(19, "Seer's Gambit", 4, "Spell", false, false, "Forsee 3. Draw a card, reveal it and deal damage equal to its cost to target champion.", "Yellow", "None", "Seer's Gambit");
        Card card20 = Card.CreateCard(20, "Guiding Hand", 3, "Spell", false, false, "Look at the top 3 cards of your deck. You may draw one, discard another and let another be on top.", "Yellow", "None", "Guiding Hand");
        Card card21 = Card.CreateCard(21, "Dual Strike", 2, "Mod", true, false, "Pay 2 energy and tap: Untap equiped weapon", "Red", "None", "Dual Strike");
        Card card22 = Card.CreateCard(22, "Crimson Edge", 2, "Weapon", true, false, "Tap: Apply bleed to the active enemy champion. Tap: Deal 2 damage tp the active enemy champion.", "Red", "None", "Crimson Edge");
        Card card23 = Card.CreateCard(23, "Bloodlust", 2, "Mod", true, false, "Equiped weapon or champion deals 1 more damage on attacks. If the target is bleeding this changes to 50% more damage.", "Red", "None", "Bloodlust");
        Card card24 = Card.CreateCard(24, "Playfull Fire", 1, "Spell", false, true, "Deal 2 damage to the active enemy champion", "Red", "None", "Playfull Fire");
        Card card25 = Card.CreateCard(25, "Flare Burst", 1, "Spell", false, true, "Deal 1 damage to target champion. If you have cast another spell this turn, deal 2 damages instead.", "Red", "None", "Flare Burst");
        Card card26 = Card.CreateCard(26, "Blazing Strike", 1, "Spell", false, true, "Deal 2 damage to the active enemy champion. If this is your second spell this turn deal 3 damage instead.", "Red", "None", "Blazing Strike");
        Card card27 = Card.CreateCard(27, "Firestorm", 4, "Mod", true, false, "Whenever you cast a spell, deal 1 damage to all enemy champions.", "Red", "None", "Firestorm");
        Card card28 = Card.CreateCard(28, "Play With Fire", 1, "Spell", false, true, "Deal 1 damage to the active enemy champion. Draw a card.", "Red", "None", "Play With Fire");
        Card card29 = Card.CreateCard(29, "Enchanted Vines", 3, "Mod", true, false, "The first time this champion looses all its shield each round, gain 2 shield.", "Green", "None", "Enchanted Vines");
        Card card30 = Card.CreateCard(30, "Thorned Armour", 3, "Mod", true, false, "Whenever the equiped champion takes damage from an enemy champion, deal 1 damage to that champion. During night deal 2 damage insread.", "Green", "None", "Thorned Armour");
        Card card31 = Card.CreateCard(31, "Colossal Hammer", 5, "Weapon", true, false, "For every 5 hp your active champion has more than the active enemy champion, Colossal Hammer deals 1 more damage. Tap: Deal 3 damage to the active enemy champion", "Greem", "None", "Colossal Hammer");
        Card card32 = Card.CreateCard(32, "Regrowth Ritual", 2, "Spell", false, false, "If its day, Heal target champion 3 HP. If its night, Heal target champion 2 HP and give it 2 Shield.", "Green", "None", "Regrowth Ritual");
        Card card33 = Card.CreateCard(33, "Echoing Reflection", 4, "Mod", true, false, "Whenever you cast your second spell each turn copy that spell", "Blue", "None", "Echoing Reflection");
        Card card34 = Card.CreateCard(34, "Restricted Knowledge", 4, "Mod", true, false, "When a card enters play under your controll, draw a card. When a card enters play under you opponents controll, deal 2 damage to the active enemy champion.", "Blue", "None", "Restricted Knoledge");
        Card card35 = Card.CreateCard(35, "Mystic Barrier", 2, "Mod", true, false, "Whenever your opponent casts their second spell each turn, gain 2 shield.", "Blue", "None", "Mystic Barrier");
        Card card36 = Card.CreateCard(36, "Atheric Shield", 3, "Mod", true, false, "when your opponent casts a spell gain 1 shield. If it is their second spell gain 2 shield.", "Blue", "None", "Atheric Shield");
        Card card37 = Card.CreateCard(37, "Arcane Momentum", 3, "Mod", true, false, "When you play your second card each turn, draw a card.", "Red", "None", "Arcane Momentum");
        Card card38 = Card.CreateCard(38, "Epiphany Storm", 2, "Spell", false, true, "Draw 3 cards and discard 2 cards.", "Red", "None", "Epiphany Storm");
        Card card39 = Card.CreateCard(39, "Solar Reflection", 4, "Mod", true, false, "Whenever you draw your first card outside of your draw step each turn, gain 1 energy. If its day gain 2 energy instead", "Yellow", "None", "Solar Reflection");
        Card card40 = Card.CreateCard(40, "Sunlit Vision", 1, "Spell", false, true, "Draw a card. If its day draw an additinoal card.", "Yellow", "None", "Sunlit Vision");
        Card card41 = Card.CreateCard(41, "Tactical Advantage", 2, "Spell", false, true, "Firsee 1. Draw a card.", "Yellow", "None", "Tactical Advantage");
        Card card42 = Card.CreateCard(42, "Golden Strike", 2, "Spell", false, false, "Deal 2 damage. If you have drawn two or more cards this turn deal 4 damage instead.", "Yellow", "None", "Golden Strike");
        Card card43 = Card.CreateCard(43, "Sun's Blessing", 3, "Spell", false, true, "Heal 3 HP and draw a card. If its day heal an additinoal 3 HP.", "Yellow", "None", "Sun's Blessing");
        Card card44 = Card.CreateCard(44, "Sun's Judgement", 4, "Spell", false, false, "Deal 4 damage to an enemy champion. If its day deal 8 damage instead.", "Yellow", "None", "Sun's Judgement");
        Card card45 = Card.CreateCard(45, "Golden Shield", 4, "Mod", true, false, "Whenever you darw a card, gain 1 shield. If its day gein 2 shield instead.", "Yellow", "None", "Golden Shield");
        Card card46 = Card.CreateCard(46, "Final Flare", 5, "Spell", false, true, "If its day, deal 6 damage to all enemy champions. If its night deal 3 damage to all enemy champions and stun them.", "Yellow", "None", "Final Flare");
        Card card47 = Card.CreateCard(47, "Harmonize", 1, "Spell", false, true, "If its day, gain 2 energy. If its night, deal 2 damage to the active enemy champion.", "White", "None", "Harmonize");
        Card card48 = Card.CreateCard(48, "Spectral Binding", 3, "Spell", false, false, "Stun target champion. If the target is allready stunned give it a Stun Counter instead.", "White", "None", "Spectral Binding");
        Card card49 = Card.CreateCard(49, "Natures Judgement", 3, "Spell", false, false, "Deal damage equal to your active champions shield to the active enemy champion.", "Green", "None", "Natures Judgement");
        Card card50 = Card.CreateCard(50, "Overgrowth", 3, "Mod", true, false, "If the equiped champion ends its turn with 5 or more shield. Gain 2 shield at your next turn start.", "Green", "None", "Overgrowth");
        Card card51 = Card.CreateCard(51, "Heart of the Forest", 5, "Mod", true, false, "Each time the equiped champion gains shield, they heal half that much as well.", "Green", "None", "Heart of the Forest");
        Card card52 = Card.CreateCard(52, "Verdant Shield", 2, "Mod", true, false, "At the start of your turn, gain 1 shield.", "Green", "None", "Verdant Shield");
        Card card53 = Card.CreateCard(53, "Fast Deflection", 3, "Mod", true, false, "At the start of your turn, gain 2 shield.", "Green", "None", "Fast Deflection");
        Card card54 = Card.CreateCard(54, "Card of Protection", 2, "Spell", false, false, "Target champion gains 2 shield. Draw a crd.", "Green", "None", "Card of Protection");
        Card card55 = Card.CreateCard(55, "Body of Knowladge", 5, "Mod", true, false, "Whenever equiped champion uses a non-attack ability, draw a card.", "Yellow", "None", "Body of Knowladge");
        Card card56 = Card.CreateCard(56, "Solar Ritual", 5, "Spell", false, false, "If its day, Draw 3 cards. If its night, discard 2 cards and draw 4.", "Yellow", "None", "Solar Ritual");
        Card card57 = Card.CreateCard(57, "Giding Ligth", 2, "Spell", false, true, "If its day, draw 2 cards. If its night, discard a card and deal 2 damage to the active enemy champion", "Yellow", "None", "Guding Light");
        Card card58 = Card.CreateCard(58, "Arcane Surge", 2, "Mod", true, false, "The first time you cast a spell each turn, draw a card.", "Blue", "None", "Arcane Surge");
        Card card59 = Card.CreateCard(59, "Warp Reality", 5, "Spell", false, true, "Choose one: Destroy all mods and replace them with random mods from that players deck. OR. Return all mods to their owners hands.", "Blue", "None", "Warp Reality");
        Card card60 = Card.CreateCard(60, "Field Distruption", 4, "Spell", false, true, "Tap up to 2 target champions. If you controll 4 or more mods on a single champion, they do not untap during their owners next untap step.", "Blue", "None", "Field Distruption");
        Card card61 = Card.CreateCard(61, "Duplicate", 4, "Mod", true, false, "Duplicate enters play as a copy of an allied mod.", "Blue", "None", "Duplicate");
        Card card62 = Card.CreateCard(62, "invisibility", 2, "Spell", false, false, "Target champion becomes invissible", "White", "None", "invisibility");
        Card card63 = Card.CreateCard(63, "Metamorphosis", 0, "Spell", false, true, "If its day it becomes night or if its night it becomes day. Create a copy of me in hand that costs 1 more.", "White", "None", "Metamorphosis");
        Card card64 = Card.CreateCard(64, "Gleaming Blessing", 2, "Mod", true, false, "While its day, equiped champio is invissible if above 15 hp.", "White", "None", "Gleaming Blessing");
        Card card65 = Card.CreateCard(65, "Inescapable Light", 3, "Mod", true, false, "Equiped champion can target invissible targets. Equiped champion deals 1 more damage during day.", "White", "None", "Inescapable Light");
        Card card66 = Card.CreateCard(66, "Blessed Blade", 2, "Weapon", true, false, "Tap: If its day, deal 4 damage to the active enemy champion. If its night, deal 2 damage instead.", "White", "None", "Blessed Blade");



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
        cardList.Add(card18);
        cardList.Add(card19);
        cardList.Add(card20);
        cardList.Add(card21);
        cardList.Add(card22);
        cardList.Add(card23);
        cardList.Add(card24);
        cardList.Add(card25);
        cardList.Add(card26);
        cardList.Add(card27);
        cardList.Add(card28);
        cardList.Add(card29);
        cardList.Add(card30);
        cardList.Add(card31);
        cardList.Add(card32);
        cardList.Add(card33);
        cardList.Add(card34);
        cardList.Add(card35);
        cardList.Add(card36);
        cardList.Add(card37);
        cardList.Add(card38);
        cardList.Add(card39);
        cardList.Add(card40);
        cardList.Add(card41);
        cardList.Add(card42);
        cardList.Add(card43);
        cardList.Add(card44);
        cardList.Add(card45);
        cardList.Add(card46);
        cardList.Add(card47);
        cardList.Add(card48);
        cardList.Add(card49);
        cardList.Add(card50);
        cardList.Add(card51);
        cardList.Add(card52);
        cardList.Add(card53);
        cardList.Add(card54);
        cardList.Add(card55);
        cardList.Add(card56);
        cardList.Add(card57);
        cardList.Add(card58);
        cardList.Add(card59);
        cardList.Add(card60);
        cardList.Add(card61);
        cardList.Add(card62);
        cardList.Add(card63);
        cardList.Add(card64);
        cardList.Add(card65);
        cardList.Add(card66);

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