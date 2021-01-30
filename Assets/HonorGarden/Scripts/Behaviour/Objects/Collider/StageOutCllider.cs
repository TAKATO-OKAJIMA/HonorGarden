using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageOutCllider : MonoBehaviour
{
    Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = GameObject.FindGameObjectWithTag("Respawn").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ;
        }
    }
}
