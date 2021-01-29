using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollider : MonoBehaviour
{

    private string collisionTag;

    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        collisionTag = other.gameObject.tag;

        if(collisionTag == "Player")
        {
            gameObject.SetActive(false);
            gameController.DcrementLeftCrystals();
        }
    }
}
