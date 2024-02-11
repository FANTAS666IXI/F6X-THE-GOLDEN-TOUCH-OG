using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatTotalClicks : MonoBehaviour
{
    public static Text totalClicksText;

    private void Awake()
    {
        GetComponents();
    }

    private void Update()
    {
        ReloadTotalClicksText();
    }

    private void GetComponents()
    {
        totalClicksText = transform.GetChild(0).GetChild(1).GetComponent<Text>();
    }

    public static void ReloadTotalClicksText()
    {
        totalClicksText.text = "TOTAL CLICKS : " + GameControll.totalClicks;
    }
}