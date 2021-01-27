using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitCollider : MonoBehaviour
{
    Suit suit = Suit.HEARTS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision");
            PlayerStatus playerStatus = collision.gameObject.GetComponent<PlayerStatus>();
            if(playerStatus.GetSuit() == suit.String())
            {
                gameObject.SetActive(false);
            }
        }
    }
}
