using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Vector3 nowPostion;
    private Vector3 nowRotation;

    // Start is called before the first frame update
    void Start()
    {
        nowRotation = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R)){
            nowPostion = transform.position;
            nowPostion.z *= -1;
            transform.position = nowPostion;

            nowRotation.y += 180;
            transform.rotation = Quaternion.Euler(nowRotation);
        }
    }
}
