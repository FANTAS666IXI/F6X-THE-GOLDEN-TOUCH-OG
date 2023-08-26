using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesScreen : MonoBehaviour
{
    private Text goldText;

    private void Awake()
    {
        GetComponents();
    }

    void Update()
    {
        ReloadGoldText();
    }

    private void GetComponents()
    {
        goldText = transform.GetChild(1).GetComponent<Text>();
    }

    public static void StartGame()
    {
        Tier1.StartGame();
        Tier2.StartGame();
        Tier3.StartGame();
        Tier4.StartGame();
        Tier5.StartGame();
    }

    private void ReloadGoldText()
    {
        goldText.text = "GOLD : " + GameControll.gold.ToString("F1");
    }
}