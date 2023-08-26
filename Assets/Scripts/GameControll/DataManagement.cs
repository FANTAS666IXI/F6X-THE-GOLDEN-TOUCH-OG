using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManagment : MonoBehaviour
{
    private bool autoSave;

    public static void SaveGame()
    {
        SaveGameControll();
        SaveUpgrades();
    }

    private static void SaveGameControll()
    {
        PlayerPrefs.SetFloat("maxGold", GameControll.maxGold);
        PlayerPrefs.SetFloat("gold", GameControll.gold);
        PlayerPrefs.SetFloat("goldPerClick", GameControll.goldPerClick);
        PlayerPrefs.SetFloat("goldPerSecond", GameControll.goldPerSecond);
        PlayerPrefs.SetFloat("totalClicks", GameControll.totalClicks);
    }

    private static void SaveUpgrades()
    {
        SaveTier1();
        SaveTier2();
        SaveTier3();
        SaveTier4();
        SaveTier5();
    }

    private static void SaveTier1()
    {
        PlayerPrefs.SetInt("tier1Level", Tier1.level);
        PlayerPrefs.SetFloat("tier1Profit", Tier1.profit);
        PlayerPrefs.SetFloat("tier1NextProfit", Tier1.nextProfit);
        PlayerPrefs.SetFloat("tier1Prize", Tier1.prize);
    }

    private static void SaveTier2()
    {
        PlayerPrefs.SetInt("tier2Level", Tier2.level);
        PlayerPrefs.SetFloat("tier2Profit", Tier2.profit);
        PlayerPrefs.SetFloat("tier2NextProfit", Tier2.nextProfit);
        PlayerPrefs.SetFloat("tier2Prize", Tier2.prize);
    }

    private static void SaveTier3()
    {
        PlayerPrefs.SetInt("tier3Level", Tier3.level);
        PlayerPrefs.SetFloat("tier3Profit", Tier3.profit);
        PlayerPrefs.SetFloat("tier3NextProfit", Tier3.nextProfit);
        PlayerPrefs.SetFloat("tier3Prize", Tier3.prize);
    }

    private static void SaveTier4()
    {
        PlayerPrefs.SetInt("tier4Level", Tier4.level);
        PlayerPrefs.SetFloat("tier4Profit", Tier4.profit);
        PlayerPrefs.SetFloat("tier4NextProfit", Tier4.nextProfit);
        PlayerPrefs.SetFloat("tier4Prize", Tier4.prize);
    }

    private static void SaveTier5()
    {
        PlayerPrefs.SetInt("tier5Level", Tier5.level);
        PlayerPrefs.SetFloat("tier5Profit", Tier5.profit);
        PlayerPrefs.SetFloat("tier5NextProfit", Tier5.nextProfit);
        PlayerPrefs.SetFloat("tier5Prize", Tier5.prize);
    }

    public static void LoadGame()
    {
        LoadGameControll();
        LoadUpgrades();
    }

    private static void LoadGameControll()
    {
        GameControll.maxGold = PlayerPrefs.GetFloat("maxGold");
        GameControll.gold = PlayerPrefs.GetFloat("gold");
        if (PlayerPrefs.GetFloat("goldPerClick") >= 1)
        {
            GameControll.goldPerClick = PlayerPrefs.GetFloat("goldPerClick");
        }
        GameControll.goldPerSecond = PlayerPrefs.GetFloat("goldPerSecond");
        GameControll.totalClicks = PlayerPrefs.GetFloat("totalClicks");
    }

    private static void LoadUpgrades()
    {
        LoadTier1();
        LoadTier2();
        LoadTier3();
        LoadTier4();
        LoadTier5();
    }

    private static void LoadTier1()
    {
        if (PlayerPrefs.GetInt("tier1Level") >= 1)
        {
            Tier1.level = PlayerPrefs.GetInt("tier1Level");
        }
        if (PlayerPrefs.GetFloat("tier1Profit") >= 1)
        {
            Tier1.profit = PlayerPrefs.GetFloat("tier1Profit");
        }
        if (PlayerPrefs.GetFloat("tier1NextProfit") >= 1.2f)
        {
            Tier1.nextProfit = PlayerPrefs.GetFloat("tier1NextProfit");
        }
        if (PlayerPrefs.GetFloat("tier1Prize") >= 10)
        {
            Tier1.prize = PlayerPrefs.GetFloat("tier1Prize");
        }
    }

    private static void LoadTier2()
    {
        Tier2.level = PlayerPrefs.GetInt("tier2Level");
        Tier2.profit = PlayerPrefs.GetFloat("tier2Profit");
        if (PlayerPrefs.GetFloat("tier2NextProfit") >= 0.5f)
        {
            Tier2.nextProfit = PlayerPrefs.GetFloat("tier2NextProfit");
        }
        if (PlayerPrefs.GetFloat("tier2Prize") >= 10)
        {
            Tier2.prize = PlayerPrefs.GetFloat("tier2Prize");
        }
    }

    private static void LoadTier3()
    {
        Tier3.level = PlayerPrefs.GetInt("tier3Level");
        Tier3.profit = PlayerPrefs.GetFloat("tier3Profit");
        if (PlayerPrefs.GetFloat("tier3NextProfit") >= 1.5f)
        {
            Tier3.nextProfit = PlayerPrefs.GetFloat("tier3NextProfit");
        }
        if (PlayerPrefs.GetFloat("tier3Prize") >= 30)
        {
            Tier3.prize = PlayerPrefs.GetFloat("tier3Prize");
        }
    }

    private static void LoadTier4()
    {
        Tier4.level = PlayerPrefs.GetInt("tier4Level");
        Tier4.profit = PlayerPrefs.GetFloat("tier4Profit");
        if (PlayerPrefs.GetFloat("tier4NextProfit") >= 4.5f)
        {
            Tier4.nextProfit = PlayerPrefs.GetFloat("tier4NextProfit");
        }
        if (PlayerPrefs.GetFloat("tier4Prize") >= 90)
        {
            Tier4.prize = PlayerPrefs.GetFloat("tier4Prize");
        }
    }

    private static void LoadTier5()
    {
        Tier5.level = PlayerPrefs.GetInt("tier5Level");
        Tier5.profit = PlayerPrefs.GetFloat("tier5Profit");
        if (PlayerPrefs.GetFloat("tier5NextProfit") >= 13.5f)
        {
            Tier5.nextProfit = PlayerPrefs.GetFloat("tier5NextProfit");
        }
        if (PlayerPrefs.GetFloat("tier5Prize") >= 270)
        {
            Tier5.prize = PlayerPrefs.GetFloat("tier5Prize");
        }
    }

    public static void ResetGame()
    {
        PlayerPrefs.DeleteAll();
    }
}