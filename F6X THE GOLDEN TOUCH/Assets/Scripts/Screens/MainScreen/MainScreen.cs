using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreen : MonoBehaviour
{
    private Text goldText;
    private static Text goldPerClickText;
    private static Text goldPerSecondText;

    private void Awake()
    {
        GetComponents();
    }

    private void Start()
    {
        SetUp();
    }

    private void Update()
    {
        ReloadGoldText();
    }

    private void GetComponents()
    {
        goldText = transform.GetChild(2).GetChild(0).GetComponent<Text>();
        goldPerClickText = transform.GetChild(2).GetChild(1).GetComponent<Text>();
        goldPerSecondText = transform.GetChild(2).GetChild(2).GetComponent<Text>();
    }

    private void SetUp()
    {
        ReloadTexts();
    }

    private void ReloadTexts()
    {
        ReloadGoldText();
        ReloadPerTexts();
    }

    private void ReloadGoldText()
    {
        goldText.text = "GOLD : " + GameControll.gold.ToString("F1");
    }

    private static void ReloadPerTexts()
    {
        goldPerClickText.text = "GPC : " + GameControll.goldPerClick.ToString("F1");
        goldPerSecondText.text = "GPS : " + GameControll.goldPerSecond.ToString("F1");
    }

    public void MainButton()
    {
        GameControll.gold += GameControll.goldPerClick;
        GameControll.AddTotalCLicks();
    }

    public static void Upgrading()
    {
        ReloadPerTexts();
    }
}