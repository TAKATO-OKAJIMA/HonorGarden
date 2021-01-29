using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePanelController : MonoBehaviour
{
    GameController gameController;
    CrystalTextBehaviour textBehaviour;
    ClearPanelBehaviour panelBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponentInParent<GameController>();
        textBehaviour = GetComponentInChildren<CrystalTextBehaviour>();
        panelBehaviour = GetComponentInChildren<ClearPanelBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        textBehaviour.setText(gameController.GetLeftCrystals().ToString());
        panelBehaviour.SetActive(gameController.IsClear());
    }
}
