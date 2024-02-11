using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatGoldPerSecond : MonoBehaviour
{
    public static Text goldPerSecondText;

    private void Awake()
    {
        GetComponents();
    }

    private void Update()
    {
        ReloadGoldPerSecondText();
    }

    private void GetComponents()
    {
        goldPerSecondText = transform.GetChild(0).GetChild(1).GetComponent<Text>();
    }

    public static void ReloadGoldPerSecondText()
    {
        goldPerSecondText.text = "GOLD PER SECOND: " + GameControll.goldPerSecond.ToString("F1");
    }
}