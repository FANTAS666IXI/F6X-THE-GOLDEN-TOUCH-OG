using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatMaxGold : MonoBehaviour
{
    private Text maxGoldText;

    private void Awake()
    {
        GetComponents();
    }

    private void Update()
    {
        ReloadMaxGoldText();
    }

    private void GetComponents()
    {
        maxGoldText = transform.GetChild(0).GetChild(1).GetComponent<Text>();
    }

    private void ReloadMaxGoldText()
    {
        maxGoldText.text = "MAX GOLD : " + GameControll.maxGold.ToString("F1");
    }
}