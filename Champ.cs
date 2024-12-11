using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champ : MonoBehaviour
{
    public GameManager GM;
    public CardDatabase DB;

    public Champ targetChamp;

    //visuals from the DB
    public int ChampDisplayID;
    public int id;
    public string cardName;
    public string cardDescription;
    public string color;
    public string secondColor;
    public string img;

    //.....
    public bool Noctis = false;
    public bool Kael = false;
    public bool Eldrin = false;
    public bool Equinox = false;
    public bool GrimwoodDevourer = false;
    public bool Oliver = false;
    public bool TheOracle = false;
    public bool Vespera = false;
    public bool Karnak = false;
    public bool Sreaphina = false;
    public bool Eirwen = false;
    public bool Gilbert = false;
    public bool Seraphus = false;
    public bool VilethornRevenant = false;
    public bool Harrow = false;

    //further card info
    public int currentHP;
    public int maxHP;
    public int StartingHP;
    public int shield;
    public int critChanse;
    public int modSlots;
    public bool targeted;
    public bool isAlive;
    public bool isTapped;
    public bool activeChampion;
    public int damageBonus;
    public int CD;
    public bool hasShield;
    public int damageDealt;
    
    //statuseffects
    public bool invissible;

    //Champ frame Sprite
    public Sprite GreenRedChamp;
    public Sprite GreenYellowChamp;
    public Sprite GreenPurpleChamp;
    public Sprite BlueGreenChamp;
    public Sprite BlueRedChamp;
    public Sprite BlueWhiteChamp;
    public Sprite WhiteGreenChamp;
    public Sprite WhiteYellowChamp;
    public Sprite PurpleRedChamp;
    public Sprite PurpleWhiteChamp;
    public Sprite PurpleBlueChamp;
    public Sprite RedYellowChamp;
    public Sprite RedWhiteChamp;

    public void Start()
    {
        if (CardDatabase.cardList == null)
        {
            Debug.LogError("CardDatabase.cardList is null");
            return;
        }

        if (ChampDisplayID < 0 || ChampDisplayID >= CardDatabase.cardList.Count)
        {
            Debug.LogError("Invalid displayId: " + ChampDisplayID);
            return;
        }

        Card card = CardDatabase.cardList[ChampDisplayID];
        if (card == null)
        {
            Debug.LogError("Card at index " + ChampDisplayID + " is null");
            return;
        }
    }

    void Update()
    {
        Card card = CardDatabase.cardList[ChampDisplayID];
    }

    public void setCardData(Card card)
    {
        //check the card ID to see what champion it is
        switch(ChampDisplayID)
        {
            case 1:
                //DisplayInfo
                name = "Eldrin";
                id = card.id;

                //Stats
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Eldrin = true;
            break;

            case 2:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Kael = true;
            break;

            case 3:
                maxHP = 25;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Noctis = true;
            break;

            case 4:
                maxHP = 25;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Equinox = true;
            break;

            case 5:
                maxHP = 30;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                GrimwoodDevourer = true;
            break;

            case 6:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Oliver = true;
            break;

            case 7:
                maxHP = 30;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                TheOracle = true;
            break;

            case 8:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Vespera = true;
            break;

            case 9:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Karnak = true;
            break;

            case 10:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Sreaphina = true;
            break;

            case 11:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Eirwen = true;
            break;

            case 12:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Gilbert = true;
            break;

            case 13:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Seraphus = true;
            break;

            case 14:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                VilethornRevenant = true;
            break;

            case 15:
                maxHP = 20;
                StartingHP = maxHP;
                currentHP = maxHP;
                shield = 0;
                modSlots = 4;
                critChanse = 0;
                targeted = false;
                isAlive = true;
                isTapped = false;
                Harrow = true;
            break;
        }
    }


    public void TakeDamage(int amount)
    {
        currentHP -= amount;
    }

    public void Heal(int amount)
    {

    }

    public void GainShield(int amount)
    {
        
    }



    void FixedUpdate()
    {
        float currentTime = Time.time;
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                switch (id)
                {
                    case 1:
                        ELdrinAbilityE();
                    break;

                    case 2:
                        KealAbilityE();
                    break;

                    case 3:
                    break;
                }
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                switch (id)
                {
                    case 1:
                        EldrinAbilityQ();
                    break;

                    case 2:
                    break;

                    case 3:
                    break;


                }
            }
        }
    }

    public void KaelPassive()
    {
        //Whenever you discard a card, deal 1 damage to target champion
        //Play 3 energy and Tap: Discard any number of cards from your hand to draw that many cards.
    }

    public void EldrinPassive()
    {
        while (GM.isNIGHT & Eldrin & isAlive)
        {
            damageBonus += 2;
        }

        //Tap: Eldrin becomes invissible, this ability can not be used next turn.
        
    }

    public void NoctisPassive()
    {
        while (Noctis & isAlive & GM.playerTurn)
        {
            GM.spellsCast = 1;
        }
        

    }

    void ELdrinAbilityE()
    {
        if (CD <= 0)
        {
            if(!isTapped)
            {
                isTapped = true;
                CD = 2;
                if (!invissible)
                {
                    invissible = true;
                }
            }
        }
    }

    //Tap: Deal 3 damage to the active enemy champion, Eldrin does not untap during your next untap step.
    void EldrinAbilityQ()
    {
        if (activeChampion) // Check if Eldrin is active
        {
            if (!isTapped) // Check if Eldrin is not tapped
            {
                isTapped = true; // Tap Eldrin
            }
        }
    }

    void KealAbilityE()
    {
        if(!isTapped) //also check if the player has enough energy
        {
            //energy cost
            isTapped = true;

            //Player chooses a number of cards in hand and discards them
            //Player draws that many cards
            //cards are chosen by clicking on them in hand, does not discard them the second you click on them, but stores them untill you confirm that you want to discard them
        }
    }
}