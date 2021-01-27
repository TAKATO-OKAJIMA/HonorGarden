using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private List<string> suits = new List<string>() { "Hearts", "Diamonds", "Speads", "Clubs", "None"};
    private string nowSuit = "None";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(nowSuit);
    }

    public bool IsSuit(string tag)
    {
        return suits.Contains(tag);
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
