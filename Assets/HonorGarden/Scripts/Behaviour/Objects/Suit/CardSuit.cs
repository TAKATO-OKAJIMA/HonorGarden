using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardSuit : MonoBehaviour, ISuit
{
    protected Suit suit = Suit.NONE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Suit GetSuit()
    {
        return suit;
    }
}