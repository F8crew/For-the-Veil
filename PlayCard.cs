using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayCard : MonoBehaviour
{
    public GameManager GM;
    public PlayerRecources pResources;
    public DisplayCard displayCard;

    public Champ enemychampion1;
    public Champ enemychampion2;
    public Champ allychampion1;
    public Champ allychampion2;

    public Champ activeAllyChampion;
    public Champ activeEnemyChampion;

    public Champ equipedChampion;

    public int id;
    public string cardName;
    public int cost;
    public string cardDescription;
    public string color;
    public string secondColor;
    public string img;
    public string type;
    public string extraInfo;

    public int shieldAmount;
    public int damageAmount;
    public int healAmount;
    public int shieldModifier;
    public int damageModifier;
    public int healModifier;
    public bool active;


    public void Start()
    {

    }
    public void playCard()
    {
        
        switch (GM.PlayedCardID)
        {
            case 0:
                break;
            
            case 1:
                break;
            
            case 2:
                break;

            case 3:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard3();
                }
                break;
            
            case 4:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard4();
                }
                break;
            
            case 5:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard5();
                }
                break;
            
            case 6:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard6();
                }

                break;
            
            case 7:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard7();
                }
                break;
            
            case 8:
                if(pResources.energy >= displayCard.cost)
                {
                   PlayCard8(); 
                }
                
                break;
            
            case 9:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard9();
                }
                
                break;

            case 10:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard10();
                }
                
                break;
            
            case 11:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard11();
                }
                
                break;
            
            case 12:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard12();
                }
                
                break;
            
            case 13:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard13();
                }
                
                break;
            
            case 14:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard14();
                }
                
                break;
            
            case 15:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard15();
                }
                
                break;
            
            case 16:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard16();
                }
                
                break;
            
            case 17:
                if(pResources.energy >= displayCard.cost)
                {
                    PlayCard17();
                }
                
                break;
        }
    }

    public void Update()
    {
        while(allychampion1.activeChampion == true)
        {
            activeAllyChampion = allychampion1;
        }

        while(allychampion2.activeChampion == true)
        {
            activeAllyChampion = allychampion2;
        }

        while(enemychampion1.activeChampion == true)
        {
            activeEnemyChampion = enemychampion1;
        }

        while(enemychampion2.activeChampion == true)
        {
            activeEnemyChampion = enemychampion2;
        }
    }

    public void PlayCard3()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        GM.spellsCast += 1;
        shieldAmount = 2;
        //target champion
        if (allychampion1.targeted == true)
        {
            allychampion1.GainShield(shieldAmount + shieldModifier);
        }

        if (allychampion2.targeted == true)
        {
            allychampion2.GainShield(shieldAmount + shieldModifier);
        }
    }

    public void PlayCard4()
    {
        pResources.energy -= displayCard.cost;
        damageAmount = 2;
        
        GM.cardsCast += 1;
        GM.spellsCast += 1;
        int predamageHP;
        predamageHP = activeEnemyChampion.currentHP;
        // Example of targeting enemy champions
        if (enemychampion1 != null)
        {
            enemychampion1.TakeDamage(damageAmount + damageModifier);
        }
        
        if (enemychampion2 != null)
        {
            enemychampion2.TakeDamage(damageAmount + damageModifier);
        }
        
        if(activeAllyChampion.currentHP > activeEnemyChampion.currentHP && predamageHP > activeEnemyChampion.currentHP)
        {
            activeAllyChampion.GainShield(predamageHP - activeEnemyChampion.currentHP + shieldModifier);
        }
    }

    public void PlayCard5()
    {
        pResources.energy -= displayCard.cost;
        healAmount = 3;
        GM.cardsCast += 1;
        GM.spellsCast += 1;

        //target champion
        if (allychampion1.targeted == true)
        {
            allychampion1.Heal(healAmount + healModifier);
        }

        if (allychampion2.targeted == true)
        {
            allychampion2.Heal(healAmount + healModifier);
        }

        GM.Draw(1);
    }

    public void PlayCard6()
    {
        pResources.energy -= displayCard.cost;
        shieldAmount = 2;
        GM.cardsCast += 1;
        equipedChampion.modSlots -= 1;
        active = true;
        bool canActivate = true;
        int currentRoundWhenActivated = 0;
        while(active && canActivate)
        {
            if(!equipedChampion.hasShield)
            {
                equipedChampion.GainShield(shieldAmount + shieldModifier);
                canActivate = false;
                currentRoundWhenActivated = GM.round;
            }
        }

        while(active && !canActivate)
        {
            if (currentRoundWhenActivated != GM.round)
            {
                canActivate = true;
            }
        }
    }

    public void PlayCard7()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        equipedChampion.modSlots -= 1;
        active = true;
        while(active)
        {
            //When equipped champion takes shield damage, deal that much damage to the acitve enemy champion
        }
    }

    public void PlayCard8()
    {
        pResources.energy -= displayCard.cost;
        GM.spellsCast += 1;
        GM.cardsCast += 1;
        
        GM.Forsee(3);
        GM.Draw(1);

        if (GM.spellsCast >= 2)
        {
            pResources.energy += 1;
        }
    }

    public void PlayCard9()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;

        //when the enemy plays a spell (dont know how to check that yet)
        //gain 1 shield and 2 if it was their second spell cast that turn (also dont know how to make it count the different players spells cast)
    }

    public void PlayCard10()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        equipedChampion.modSlots -= 1;
        active = true;
        bool canActivate = true;
        int spellsCast = 0;
        while (active && canActivate && spellsCast < 2)
        {
            if (spellsCast < GM.spellsCast)
            {
                pResources.energy += 1;
                spellsCast += 1;
            }
        }
    }

    public void PlayCard11()
    {
        pResources.energy -= displayCard.cost;
        GM.spellsCast += 1;
        GM.cardsCast += 1;
        int bonusDraw = 0;
        bool repeat = true;
        while(repeat)
        {
            GM.Draw(1 + bonusDraw);
            
            //reveal the drawn card
            //activeChampion takes damage equal to helf the cost of the revealed card

            bonusDraw += 1;
            if(pResources.energy != 0)
            {
                //player can choose to pay 1 energy to repeat this effect

                //if the player played
                    //repeat = true;
                
                //else
                    //repeat = false;
            }
            else{
                repeat = false;
            }
        }
    }

    public void PlayCard12()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        equipedChampion.modSlots -= 1;
        active = true;
    
        while(active)
        {
            //player gets the option to click their champion and pay 2 HP to draw a card
        }
    }

    public void PlayCard13()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        GM.spellsCast += 1;
        
        GM.lookAtTopCards(3);
        //pick one of them to draw
        //discard the other 2
    }

    public void PlayCard14()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        equipedChampion.modSlots -= 1;
        active = true;

        while(active)
        {
            //When equiped champion takes damage from an allied source, deal 1 damage to target enemy champ
        }
    }

    public void PlayCard15()
    {   
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        equipedChampion.modSlots -= 1;
        active = true;

        while (active)
        {
            int preDamageHP;
            preDamageHP = equipedChampion.targetChamp.currentHP;
            if(equipedChampion.targetChamp.currentHP < preDamageHP)
            {
                equipedChampion.Heal(equipedChampion.damageDealt / 2);
            }
        }
    }

    public void PlayCard16()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        GM.spellsCast += 1;

        int shieldBeforeSacrifice;
        //target champion
        if (allychampion1.targeted)
        {
            shieldBeforeSacrifice = allychampion1.shield;
            allychampion1.shield = 0;
            GM.Draw(shieldBeforeSacrifice/2);
        }
    }

    public void PlayCard17()
    {
        pResources.energy -= displayCard.cost;
        GM.cardsCast += 1;
        equipedChampion.modSlots -= 1;
        active = true;
        bool canActivate = true;
        while(active && canActivate)
        {
            //tap
                //Deal 4 damage to the active enemy champion and 2 damage to your active champion
        }
    }
}