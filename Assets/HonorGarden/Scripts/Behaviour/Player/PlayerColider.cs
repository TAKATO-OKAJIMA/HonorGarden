using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColider : MonoBehaviour
{
    private string collisionTag;

    private PlayerStatus playerStatus;

    // Start is called before the first frame update
    void Start()
    {
        playerStatus = GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        collisionTag = collider.gameObject.tag;
        if (playerStatus.IsSuit(collisionTag))
        {
            playerStatus.SetSuit(collisionTag);
        }
        else if(collisionTag == "Water")
        {
            Debug.Log("Water");
        }
    }
}