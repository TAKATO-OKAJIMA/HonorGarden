using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitCollider : MonoBehaviour
{
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
            if(playerStatus.GetSuit() == tag)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Collision");
            PlayerStatus playerStatus = other.gameObject.GetComponent<PlayerStatus>();
            if (playerStatus.GetSuit() == tag)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Debug.Log("Collision");
            PlayerStatus playerStatus = hit.gameObject.GetComponent<PlayerStatus>();
            if (playerStatus.GetSuit() == tag)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
