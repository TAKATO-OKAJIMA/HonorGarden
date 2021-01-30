using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowSuitImage : MonoBehaviour
{
    private Dictionary<Suit, Sprite> suitSprites = new Dictionary<Suit, Sprite>();
    private Sprite[] sprites;
    private Image image;

    private PlayerStatus playerStatus;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Suit suit in Enum.GetValues(typeof(Suit)))
        {
            suitSprites[suit] = Resources.Load<Sprite>("Images/" + suit.ToString());
            //Debug.Log(suitSprites[suit]);
            //suitSprites[suit] = Resources.LoadAll<Sprite>(suit.ToString());
        }

        //sprites = Resources.LoadAll("Images", typeof(Sprite)).Cast<>
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpriteFromSuit(Suit suit)
    {
        image.sprite = suitSprites[suit];
    }
}
