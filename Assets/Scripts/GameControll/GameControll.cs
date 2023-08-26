using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour
{
    public static float maxGold;
    public static float gold;
    public static float goldPerClick;
    public static float goldPerSecond;
    public static float totalClicks;

    private void Start()
    {
        SetUp();
    }

    private void Update()
    {
        AddGoldPerSecond();
        DesactiveNegativeGold();
        ReloadMaxGold();
        AutoUpgrade();
        AutoSaveGame();
    }

    private void SetUp()
    {
        StartGame();
        DataManagment.LoadGame();
    }

    private void StartGame()
    {
        StartGameGameControll();
        UpgradesScreen.StartGame();
        AchievmentsScreen.StartGame();
    }

    private void StartGameGameControll()
    {
        maxGold = 0;
        gold = 0;
        goldPerClick = 1;
        goldPerSecond = 0;
        totalClicks = 0;
    }

    private void DesactiveNegativeGold()
    {
        if (gold < 0)
        {
            gold = 0;
        }
    }

    private void AddGoldPerSecond()
    {
        gold += goldPerSecond * Time.deltaTime;
    }

    public static void AddTotalCLicks()
    {
        totalClicks++;
    }

    private void ReloadMaxGold()
    {
        if (gold > maxGold)
        {
            maxGold = gold;
        }
    }

    public static void Paying(float prize)
    {
        gold -= prize;
    }

    private void AutoUpgrade()
    {
        if (AutoUpgradeUpgradesScreen.autoUpgradeState)
        {
            Tier1.UpgradeOnClick();
            Tier2.UpgradeOnClick();
            Tier3.UpgradeOnClick();
            Tier4.UpgradeOnClick();
            Tier5.UpgradeOnClick();
        }
    }

    private void AutoSaveGame()
    {
        if (OptionAutoSaveGame.autoSaveGameState)
        {
            DataManagment.SaveGame();
        }
    }

    public static void Upgrading()
    {
        goldPerClick = Tier1.profit;
        goldPerSecond = Tier2.profit + Tier3.profit + Tier4.profit + Tier5.profit;
        MainScreen.Upgrading();
    }
}