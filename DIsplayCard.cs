using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{

    PlayerWeapon playerWeapon;
    GameManager GM;

    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public string cardDescription;
    public string color;
    public string secondColor;
    public string img;
    public string type;
    public string extraInfo;
    public Image art;

    public string modType;

    public Text nameText;
    public Image costImage;
    public Text descriptionText;
    public Text CardType;
    public Text Subtype;
    public Text MarginText_Right;
    public Text MarginText_Left;

    //Card Sprites
    public Sprite GreenSpell;
    public Sprite GreenMod;

    public Sprite BlueSpell;
    public Sprite BlueMod;

    public Sprite PurpleSpell;
    public Sprite PurpleMod;
    
    public Sprite RedSpell;
    public Sprite RedMod;
    
    public Sprite YellowSpell;
    public Sprite YellowMod;

    public Sprite WhiteSpell;
    public Sprite WhiteMod;

    public Sprite ColorlessSpell;
    public Sprite ColorlessMod;

    //champion sprites
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

    void Start()
    {
        if (CardDatabase.cardList == null)
        {
            Debug.LogError("CardDatabase.cardList is null");
            return;
        }

        if (displayId < 0 || displayId >= CardDatabase.cardList.Count)
        {
            Debug.LogError("Invalid displayId: " + displayId);
            return;
        }

        Card card = CardDatabase.cardList[displayId];
        if (card == null)
        {
            Debug.LogError("Card at index " + displayId + " is null");
            return;
        }

        UpdateCardDisplay(card);
    }

    void Update()
    {
        Card card = CardDatabase.cardList[displayId];
        UpdateCardDisplay(card);
    }

    void UpdateCardDisplay(Card card)
    {
        id = card.id;
        cardName = card.cardName;
        cost = card.cost;
        cardDescription = card.cardDescription;
        color = card.color;
        secondColor = card.secondColor;
        type = card.cardType;

        Sprite cardSprite = Resources.Load<Sprite>(card.image);

        Image cardImage = gameObject.GetComponent<Image>();

        if (cardSprite != null)
        {
            // Assign the loaded sprite to the art Image component
            art.sprite = cardSprite;
        }
        else
        {
            Debug.LogError("Failed to load sprite: " + card.image);
        }

        if (type == "Champion")
        {
            if (color == "Green")
            {
                if (secondColor == "Red")
                {
                    cardImage.sprite = GreenRedChamp;
                }
                
                if (secondColor == "Yellow")
                {
                    cardImage.sprite = GreenYellowChamp;
                }

                if (secondColor == "Purple")
                {
                    cardImage.sprite = GreenPurpleChamp;
                }
            }

            if (color == "Red")
            {
                if (secondColor == "White")
                {
                    cardImage.sprite = RedWhiteChamp;
                }
                
                if (secondColor == "Yellow")
                {
                    cardImage.sprite = RedYellowChamp;
                }
            }

            if (color == "Yellow")
            {
                if (secondColor == "Blue")
                {
                    cardImage.sprite = GreenRedChamp;
                }
                
                if (secondColor == "Purple")
                {
                    cardImage.sprite = GreenYellowChamp;
                }
            }

            if (color == "Purple")
            {
                if (secondColor == "Red")
                {
                    cardImage.sprite = PurpleRedChamp;
                }
                
                if (secondColor == "Blue")
                {
                    cardImage.sprite = PurpleBlueChamp;
                }

                if (secondColor == "White")
                {
                    cardImage.sprite = PurpleWhiteChamp;
                }
            }

            if (color == "Blue")
            {
                if (secondColor == "Red")
                {
                    cardImage.sprite = BlueRedChamp;
                }
                
                if (secondColor == "Green")
                {
                    cardImage.sprite = PurpleBlueChamp;
                }

                if (secondColor == "White")
                {
                    cardImage.sprite = PurpleWhiteChamp;
                }
            }
            
        }


        if (color == "Green")
        {
            if (type == "Spell")
            {
                cardImage.sprite = GreenSpell;
            }
            else if (type != "Spell")
            {
                cardImage.sprite = GreenMod;
            }
        }

        if (color == "Red")
        {
            if (type == "Spell")
            {
                cardImage.sprite = RedSpell;
            }
            else if (type != "Spell")
            {
                cardImage.sprite = RedMod;
            }
        }

        if (color == "Blue")
        {
            if (type == "Spell")
            {
                cardImage.sprite = BlueSpell;
            }
            else if (type != "Spell")
            {
                cardImage.sprite = BlueMod;
            }
        }

        if (color == "Yellow")
        {
            if (type == "Spell")
            {
                cardImage.sprite = YellowSpell;
            }
            else if (type != "Spell")
            {
                cardImage.sprite = YellowMod;
            }
        }

        if (color == "Purple")
        {
            if (type == "Spell")
            {
                cardImage.sprite = PurpleSpell;
            }
            else if (type != "Spell")
            {
                cardImage.sprite = PurpleMod;
            }
        }

        if (color == "White")
        {
            if (type == "Spell")
            {
                cardImage.sprite = WhiteSpell;
            }
            else if (type != "Spell")
            {
                cardImage.sprite = WhiteMod;
            }
        }

        if (color == "Colorless")
        {
            if (type == "Spell")
            {
                cardImage.sprite = ColorlessSpell;
            }
            else if (type != "Spell")
            {
                cardImage.sprite = ColorlessMod;
            }
        }
        
        nameText.text = "" + cardName;
        descriptionText.text = "" + cardDescription;
        CardType.text = "" + type;
        
        if (type == "Spell")
        {
            Subtype.text = "";
        }
        
        if (type == "Mod")
        {
            Subtype.text = "" + modType;
        }

        if (type == "Weapon")
        {
            Subtype.text = "" + playerWeapon.ModSlots;
        }
        

    }
}