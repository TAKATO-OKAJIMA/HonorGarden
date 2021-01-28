using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitGimmickCollider : MonoBehaviour
{
    CardSuit cardSuit;
    // Start is called before the first frame update
    void Start()
    {
        cardSuit = GetComponent<CardSuit>();
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
            if(playerStatus.GetSuit() == cardSuit.GetSuit())
            {
                gameObject.SetActive(false);
            }
        }
    }
}
