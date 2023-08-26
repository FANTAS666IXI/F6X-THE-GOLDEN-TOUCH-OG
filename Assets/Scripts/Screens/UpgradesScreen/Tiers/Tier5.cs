using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tier5 : MonoBehaviour
{
    public static int level;
    public static float profit;
    public static float nextProfit;
    public static float prize;
    public static float scaled;
    public static Text levelText;
    public static Text profitText;
    public static Text nextProfitText;
    public static Button upgradeButton;
    public static Text upgradeText;
    private ColorBlock upgradeButtonColors;

    private void Awake()
    {
        GetComponents();
    }

    private void Update()
    {
        UpgradeTierAvailable();
        ReloadTexts();
    }

    private void GetComponents()
    {
        levelText = transform.GetChild(1).GetChild(1).GetComponent<Text>();
        profitText = transform.GetChild(2).GetChild(1).GetComponent<Text>();
        nextProfitText = transform.GetChild(3).GetChild(1).GetComponent<Text>();
        upgradeButton = transform.GetChild(4).GetComponent<Button>();
        upgradeText = transform.GetChild(4).GetChild(0).GetComponent<Text>();
        upgradeButtonColors = upgradeButton.GetComponent<Button>().colors;
    }

    public static void StartGame()
    {
        level = 0;
        profit = 0;
        prize = 270;
        scaled = 1.2f;
        nextProfit = 13.5f;
    }

    private void ReloadTexts()
    {
        levelText.text = "LVL : " + level;
        profitText.text = "GPS : " + profit.ToString("F1");
        nextProfitText.text = "GPS : " + nextProfit.ToString("F1");
        upgradeText.text = "COSTS : " + prize.ToString("F1") + " G";
    }

    public static bool CheckUpgradeAvailable()
    {
        if ((prize - 0.01f) <= GameControll.gold)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void UpgradeTierAvailable()
    {
        if (CheckUpgradeAvailable())
        {
            upgradeButtonColors.normalColor = new Color(0.2f, 0.9f, 0.2f);
            upgradeButtonColors.highlightedColor = new Color(0.2f, 0.8f, 0.2f);
            upgradeButtonColors.pressedColor = new Color(0.2f, 0.75f, 0.2f);
            upgradeButtonColors.selectedColor = new Color(0.2f, 0.9f, 0.2f);
        }
        else
        {
            upgradeButtonColors.normalColor = new Color(1, 1, 1, 1);
            upgradeButtonColors.highlightedColor = new Color(0.9607843f, 0.9607843f, 0.9607843f, 1f);
            upgradeButtonColors.pressedColor = new Color(0.7843137f, 0.7843137f, 0.7843137f, 1f);
            upgradeButtonColors.selectedColor = new Color(1, 1, 1, 1f);
        }
        upgradeButton.colors = upgradeButtonColors;
    }

    public static void UpgradeOnClick()
    {
        if (CheckUpgradeAvailable())
        {
            GameControll.Paying(prize);
            level++;
            profit = nextProfit;
            nextProfit *= scaled;
            prize *= scaled;
            GameControll.Upgrading();
        }
    }
}