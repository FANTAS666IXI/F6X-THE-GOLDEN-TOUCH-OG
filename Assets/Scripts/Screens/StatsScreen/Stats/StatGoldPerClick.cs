using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatGoldPerClick : MonoBehaviour
{
    public static Text goldPerClickText;

    private void Awake()
    {
        GetComponents();
    }

    private void Update()
    {
        ReloadGoldPerClickText();
    }

    private void GetComponents()
    {
        goldPerClickText = transform.GetChild(0).GetChild(1).GetComponent<Text>();
    }

    public static void ReloadGoldPerClickText()
    {
        goldPerClickText.text = "GOLD PER CLICK: " + GameControll.goldPerClick.ToString("F1");
    }
}