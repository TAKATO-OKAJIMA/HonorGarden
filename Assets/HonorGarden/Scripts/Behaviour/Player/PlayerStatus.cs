using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour, ISuit
{
    private Suit nowSuit;

    // Start is called before the first frame update
    void Start()
    {
        nowSuit = Suit.NONE;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(nowSuit);
    }

    public void SetSuit(Suit suit)
    {
        nowSuit = suit;
        Debug.Log(SuitString.ToString(nowSuit));
    }

    public Suit GetSuit()
    {
        return nowSuit;
    }
}
