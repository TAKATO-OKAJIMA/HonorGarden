using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePanelController : MonoBehaviour
{
    GameController gameController;
    PlayerStatus playerStatus;
    CrystalTextBehaviour textBehaviour;
    ClearPanelBehaviour panelBehaviour;
    NowSuitImage nowSuitImage;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponentInParent<GameController>();
        playerStatus = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
        textBehaviour = GetComponentInChildren<CrystalTextBehaviour>();
        panelBehaviour = GetComponentInChildren<ClearPanelBehaviour>();
        nowSuitImage = GetComponentInChildren<NowSuitImage>();
    }

    // Update is called once per frame
    void Update()
    {
        textBehaviour.setText(gameController.GetLeftCrystals().ToString());
        panelBehaviour.SetActive(gameController.IsClear());
        nowSuitImage.SetSpriteFromSuit(playerStatus.GetSuit());
    }
}
