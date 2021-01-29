using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int leftCrystals;
    private bool onClear;

    // Start is called before the first frame update
    void Start()
    {
        var crystals = GameObject.FindGameObjectsWithTag("Crystal");

        leftCrystals = crystals.Length;
        onClear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(leftCrystals == 0)
        {
            onClear = true;
        }
    }

    public void DcrementLeftCrystals()
    {
        leftCrystals--;
    }

    public int GetLeftCrystals()
    {
        return leftCrystals;
    }

    public bool IsClear()
    {
        return onClear;
    }
}
