﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalTextBehaviour : MonoBehaviour
{
    private string text = "Crystal：";

    private Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setText(string text)
    {
        textComponent.text = this.text + text;
    }
}
