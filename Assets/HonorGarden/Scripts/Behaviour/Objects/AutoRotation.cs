using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{ 
    private Vector3 rotation = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        rotation.y += Time.deltaTime * 15;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
