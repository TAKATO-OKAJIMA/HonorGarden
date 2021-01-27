using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollider : MonoBehaviour
{
    string collisionTag;
    Suit suit = Suit.HEARTS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string collisionTag = collision.gameObject.tag;

        if(collisionTag == "Player")
        {
            PlayerStatus playerStatus = collision.gameObject.GetComponent<PlayerStatus>();
            playerStatus.SetSuit(suit.String());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string collisionTag = other.gameObject.tag;

        if (collisionTag == "Player")
        {
            PlayerStatus playerStatus = other.gameObject.GetComponent<PlayerStatus>();
            playerStatus.SetSuit(suit.String());
        }
    }
}
