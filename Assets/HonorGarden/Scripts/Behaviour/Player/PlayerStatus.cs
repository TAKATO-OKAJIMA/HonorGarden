using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private string nowSuit;

    // Start is called before the first frame update
    void Start()
    {
        nowSuit = Suit.NONE.String();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(nowSuit);
    }

    public void SetSuit(string suit)
    {
        nowSuit = suit;
        Debug.Log(nowSuit);
    }

    public string GetSuit()
    {
        return nowSuit;
    }
}
