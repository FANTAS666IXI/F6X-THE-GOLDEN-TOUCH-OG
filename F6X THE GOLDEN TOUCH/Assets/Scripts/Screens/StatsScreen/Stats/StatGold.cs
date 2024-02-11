using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatGold : MonoBehaviour
{
    private Text goldText;

    private void Awake()
    {
        GetComponents();
    }

    private void Update()
    {
        ReloadGoldText();
    }

    private void GetComponents()
    {
        goldText = transform.GetChild(0).GetChild(1).GetComponent<Text>();
    }

    private void ReloadGoldText()
    {
        goldText.text = "GOLD : " + GameControll.gold.ToString("F1");
    }
}