using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBar : MonoBehaviour
{
    public GameObject skinsScreen;
    public GameObject upgradesScreen;
    public GameObject mainScreen;
    public GameObject statsScreen;
    public GameObject achievmentsScreen;
    public GameObject optionsScreen;
    private Button skinsScreenButton;
    private ColorBlock skinsScreenButtonColors;
    private Button upgradesScreenButton;
    private ColorBlock upgradesScreenButtonColors;
    private Button mainScreenButton;
    private ColorBlock mainScreenButtonColors;
    private Button statsScreenButton;
    private ColorBlock statsScreenButtonColors;
    private Button achievmentsScreenButton;
    private ColorBlock achievmentsScreenButtonColors;
    private Button optionsScreenButton;
    private ColorBlock optionsScreenButtonColors;

    private void Awake()
    {
        GetComponents();
    }

    private void Start()
    {
        SetUp();
    }

    private void GetComponents()
    {
        skinsScreenButton = transform.GetChild(1).GetChild(0).GetComponent<Button>();
        skinsScreenButtonColors = skinsScreenButton.GetComponent<Button>().colors;
        upgradesScreenButton = transform.GetChild(1).GetChild(1).GetComponent<Button>();
        upgradesScreenButtonColors = upgradesScreenButton.GetComponent<Button>().colors;
        mainScreenButton = transform.GetChild(1).GetChild(2).GetComponent<Button>();
        mainScreenButtonColors = mainScreenButton.GetComponent<Button>().colors;
        statsScreenButton = transform.GetChild(1).GetChild(3).GetComponent<Button>();
        statsScreenButtonColors = statsScreenButton.GetComponent<Button>().colors;
        achievmentsScreenButton = transform.GetChild(1).GetChild(4).GetComponent<Button>();
        achievmentsScreenButtonColors = achievmentsScreenButton.GetComponent<Button>().colors;
        optionsScreenButton = transform.GetChild(1).GetChild(5).GetComponent<Button>();
        optionsScreenButtonColors = optionsScreenButton.GetComponent<Button>().colors;
    }

    private void SetUp()
    {
        MainScreenButtonOnclick();
    }

    public void SkinsScreenButtonOnclick()
    {
        ReloadUnactiveScreens();
        ReloadUnactiveScreenButtons();
        skinsScreen.SetActive(true);
        skinsScreenButtonColors.normalColor = new Color(skinsScreenButtonColors.normalColor.r, skinsScreenButtonColors.normalColor.g, skinsScreenButtonColors.normalColor.b, 1f);
        skinsScreenButtonColors.highlightedColor = new Color(skinsScreenButtonColors.highlightedColor.r, skinsScreenButtonColors.highlightedColor.g, skinsScreenButtonColors.highlightedColor.b, 1f);
        skinsScreenButtonColors.pressedColor = new Color(skinsScreenButtonColors.pressedColor.r, skinsScreenButtonColors.pressedColor.g, skinsScreenButtonColors.pressedColor.b, 1f);
        skinsScreenButtonColors.selectedColor = new Color(skinsScreenButtonColors.selectedColor.r, skinsScreenButtonColors.selectedColor.g, skinsScreenButtonColors.selectedColor.b, 1f);
        skinsScreenButton.colors = skinsScreenButtonColors;
    }

    public void UpgradesScreenButtonOnclick()
    {
        ReloadUnactiveScreens();
        ReloadUnactiveScreenButtons();
        upgradesScreen.SetActive(true);
        upgradesScreenButtonColors.normalColor = new Color(upgradesScreenButtonColors.normalColor.r, upgradesScreenButtonColors.normalColor.g, upgradesScreenButtonColors.normalColor.b, 1f);
        upgradesScreenButtonColors.highlightedColor = new Color(upgradesScreenButtonColors.highlightedColor.r, upgradesScreenButtonColors.highlightedColor.g, upgradesScreenButtonColors.highlightedColor.b, 1f);
        upgradesScreenButtonColors.pressedColor = new Color(upgradesScreenButtonColors.pressedColor.r, upgradesScreenButtonColors.pressedColor.g, upgradesScreenButtonColors.pressedColor.b, 1f);
        upgradesScreenButtonColors.selectedColor = new Color(upgradesScreenButtonColors.selectedColor.r, upgradesScreenButtonColors.selectedColor.g, upgradesScreenButtonColors.selectedColor.b, 1f);
        upgradesScreenButton.colors = upgradesScreenButtonColors;
    }

    public void MainScreenButtonOnclick()
    {
        ReloadUnactiveScreens();
        ReloadUnactiveScreenButtons();
        mainScreen.SetActive(true);
        mainScreenButtonColors.normalColor = new Color(mainScreenButtonColors.normalColor.r, mainScreenButtonColors.normalColor.g, mainScreenButtonColors.normalColor.b, 1f);
        mainScreenButtonColors.highlightedColor = new Color(mainScreenButtonColors.highlightedColor.r, mainScreenButtonColors.highlightedColor.g, mainScreenButtonColors.highlightedColor.b, 1f);
        mainScreenButtonColors.pressedColor = new Color(mainScreenButtonColors.pressedColor.r, mainScreenButtonColors.pressedColor.g, mainScreenButtonColors.pressedColor.b, 1f);
        mainScreenButtonColors.selectedColor = new Color(mainScreenButtonColors.selectedColor.r, mainScreenButtonColors.selectedColor.g, mainScreenButtonColors.selectedColor.b, 1f);
        mainScreenButton.colors = mainScreenButtonColors;
    }

    public void StatsScreenButtonOnclick()
    {
        ReloadUnactiveScreens();
        ReloadUnactiveScreenButtons();
        statsScreen.SetActive(true);
        statsScreenButtonColors.normalColor = new Color(statsScreenButtonColors.normalColor.r, statsScreenButtonColors.normalColor.g, statsScreenButtonColors.normalColor.b, 1f);
        statsScreenButtonColors.highlightedColor = new Color(statsScreenButtonColors.highlightedColor.r, statsScreenButtonColors.highlightedColor.g, statsScreenButtonColors.highlightedColor.b, 1f);
        statsScreenButtonColors.pressedColor = new Color(statsScreenButtonColors.pressedColor.r, statsScreenButtonColors.pressedColor.g, statsScreenButtonColors.pressedColor.b, 1f);
        statsScreenButtonColors.selectedColor = new Color(statsScreenButtonColors.selectedColor.r, statsScreenButtonColors.selectedColor.g, statsScreenButtonColors.selectedColor.b, 1f);
        statsScreenButton.colors = statsScreenButtonColors;
    }

    public void AchievmentsScreenButtonOnclick()
    {
        ReloadUnactiveScreens();
        ReloadUnactiveScreenButtons();
        achievmentsScreen.SetActive(true);
        achievmentsScreenButtonColors.normalColor = new Color(achievmentsScreenButtonColors.normalColor.r, achievmentsScreenButtonColors.normalColor.g, achievmentsScreenButtonColors.normalColor.b, 1f);
        achievmentsScreenButtonColors.highlightedColor = new Color(achievmentsScreenButtonColors.highlightedColor.r, achievmentsScreenButtonColors.highlightedColor.g, achievmentsScreenButtonColors.highlightedColor.b, 1f);
        achievmentsScreenButtonColors.pressedColor = new Color(achievmentsScreenButtonColors.pressedColor.r, achievmentsScreenButtonColors.pressedColor.g, achievmentsScreenButtonColors.pressedColor.b, 1f);
        achievmentsScreenButtonColors.selectedColor = new Color(achievmentsScreenButtonColors.selectedColor.r, achievmentsScreenButtonColors.selectedColor.g, achievmentsScreenButtonColors.selectedColor.b, 1f);
        achievmentsScreenButton.colors = achievmentsScreenButtonColors;
    }

    public void OptionsScreenButtonOnclick()
    {
        ReloadUnactiveScreens();
        ReloadUnactiveScreenButtons();
        optionsScreen.SetActive(true);
        optionsScreenButtonColors.normalColor = new Color(optionsScreenButtonColors.normalColor.r, optionsScreenButtonColors.normalColor.g, optionsScreenButtonColors.normalColor.b, 1f);
        optionsScreenButtonColors.highlightedColor = new Color(optionsScreenButtonColors.highlightedColor.r, optionsScreenButtonColors.highlightedColor.g, optionsScreenButtonColors.highlightedColor.b, 1f);
        optionsScreenButtonColors.pressedColor = new Color(optionsScreenButtonColors.pressedColor.r, optionsScreenButtonColors.pressedColor.g, optionsScreenButtonColors.pressedColor.b, 1f);
        optionsScreenButtonColors.selectedColor = new Color(optionsScreenButtonColors.selectedColor.r, optionsScreenButtonColors.selectedColor.g, optionsScreenButtonColors.selectedColor.b, 1f);
        optionsScreenButton.colors = optionsScreenButtonColors;
    }

    private void ReloadUnactiveScreens()
    {
        skinsScreen.SetActive(false);
        upgradesScreen.SetActive(false);
        mainScreen.SetActive(false);
        statsScreen.SetActive(false);
        achievmentsScreen.SetActive(false);
        optionsScreen.SetActive(false);
    }

    private void ReloadUnactiveScreenButtons()
    {
        ReloadUnactiveSkinsScreenButton();
        ReloadUnactiveUpgradesScreenButton();
        ReloadUnactiveMainScreenButton();
        ReloadUnactiveStatsScreenButton();
        ReloadUnactiveAchievmentsScreenButton();
        ReloadUnactiveOptionsScreenButton();
    }

    private void ReloadUnactiveSkinsScreenButton()
    {
        skinsScreenButtonColors.normalColor = new Color(skinsScreenButtonColors.normalColor.r, skinsScreenButtonColors.normalColor.g, skinsScreenButtonColors.normalColor.b, 0.8f);
        skinsScreenButtonColors.highlightedColor = new Color(skinsScreenButtonColors.highlightedColor.r, skinsScreenButtonColors.highlightedColor.g, skinsScreenButtonColors.highlightedColor.b, 0.8f);
        skinsScreenButtonColors.pressedColor = new Color(skinsScreenButtonColors.pressedColor.r, skinsScreenButtonColors.pressedColor.g, skinsScreenButtonColors.pressedColor.b, 0.8f);
        skinsScreenButtonColors.selectedColor = new Color(skinsScreenButtonColors.selectedColor.r, skinsScreenButtonColors.selectedColor.g, skinsScreenButtonColors.selectedColor.b, 0.8f);
        skinsScreenButton.colors = skinsScreenButtonColors;
    }

    private void ReloadUnactiveUpgradesScreenButton()
    {
        upgradesScreenButtonColors.normalColor = new Color(upgradesScreenButtonColors.normalColor.r, upgradesScreenButtonColors.normalColor.g, upgradesScreenButtonColors.normalColor.b, 0.8f);
        upgradesScreenButtonColors.highlightedColor = new Color(upgradesScreenButtonColors.highlightedColor.r, upgradesScreenButtonColors.highlightedColor.g, upgradesScreenButtonColors.highlightedColor.b, 0.8f);
        upgradesScreenButtonColors.pressedColor = new Color(upgradesScreenButtonColors.pressedColor.r, upgradesScreenButtonColors.pressedColor.g, upgradesScreenButtonColors.pressedColor.b, 0.8f);
        upgradesScreenButtonColors.selectedColor = new Color(upgradesScreenButtonColors.selectedColor.r, upgradesScreenButtonColors.selectedColor.g, upgradesScreenButtonColors.selectedColor.b, 0.8f);
        upgradesScreenButton.colors = upgradesScreenButtonColors;
    }

    private void ReloadUnactiveMainScreenButton()
    {
        mainScreenButtonColors.normalColor = new Color(mainScreenButtonColors.normalColor.r, mainScreenButtonColors.normalColor.g, mainScreenButtonColors.normalColor.b, 0.8f);
        mainScreenButtonColors.highlightedColor = new Color(mainScreenButtonColors.highlightedColor.r, mainScreenButtonColors.highlightedColor.g, mainScreenButtonColors.highlightedColor.b, 0.8f);
        mainScreenButtonColors.pressedColor = new Color(mainScreenButtonColors.pressedColor.r, mainScreenButtonColors.pressedColor.g, mainScreenButtonColors.pressedColor.b, 0.8f);
        mainScreenButtonColors.selectedColor = new Color(mainScreenButtonColors.selectedColor.r, mainScreenButtonColors.selectedColor.g, mainScreenButtonColors.selectedColor.b, 0.8f);
        mainScreenButton.colors = mainScreenButtonColors;
    }

    private void ReloadUnactiveStatsScreenButton()
    {
        statsScreenButtonColors.normalColor = new Color(statsScreenButtonColors.normalColor.r, statsScreenButtonColors.normalColor.g, statsScreenButtonColors.normalColor.b, 0.8f);
        statsScreenButtonColors.highlightedColor = new Color(statsScreenButtonColors.highlightedColor.r, statsScreenButtonColors.highlightedColor.g, statsScreenButtonColors.highlightedColor.b, 0.8f);
        statsScreenButtonColors.pressedColor = new Color(statsScreenButtonColors.pressedColor.r, statsScreenButtonColors.pressedColor.g, statsScreenButtonColors.pressedColor.b, 0.8f);
        statsScreenButtonColors.selectedColor = new Color(statsScreenButtonColors.selectedColor.r, statsScreenButtonColors.selectedColor.g, statsScreenButtonColors.selectedColor.b, 0.8f);
        statsScreenButton.colors = statsScreenButtonColors;
    }

    private void ReloadUnactiveAchievmentsScreenButton()
    {
        achievmentsScreenButtonColors.normalColor = new Color(achievmentsScreenButtonColors.normalColor.r, achievmentsScreenButtonColors.normalColor.g, achievmentsScreenButtonColors.normalColor.b, 0.8f);
        achievmentsScreenButtonColors.highlightedColor = new Color(achievmentsScreenButtonColors.highlightedColor.r, achievmentsScreenButtonColors.highlightedColor.g, achievmentsScreenButtonColors.highlightedColor.b, 0.8f);
        achievmentsScreenButtonColors.pressedColor = new Color(achievmentsScreenButtonColors.pressedColor.r, achievmentsScreenButtonColors.pressedColor.g, achievmentsScreenButtonColors.pressedColor.b, 0.8f);
        achievmentsScreenButtonColors.selectedColor = new Color(achievmentsScreenButtonColors.selectedColor.r, achievmentsScreenButtonColors.selectedColor.g, achievmentsScreenButtonColors.selectedColor.b, 0.8f);
        achievmentsScreenButton.colors = achievmentsScreenButtonColors;
    }

    private void ReloadUnactiveOptionsScreenButton()
    {
        optionsScreenButtonColors.normalColor = new Color(optionsScreenButtonColors.normalColor.r, optionsScreenButtonColors.normalColor.g, optionsScreenButtonColors.normalColor.b, 0.8f);
        optionsScreenButtonColors.highlightedColor = new Color(optionsScreenButtonColors.highlightedColor.r, optionsScreenButtonColors.highlightedColor.g, optionsScreenButtonColors.highlightedColor.b, 0.8f);
        optionsScreenButtonColors.pressedColor = new Color(optionsScreenButtonColors.pressedColor.r, optionsScreenButtonColors.pressedColor.g, optionsScreenButtonColors.pressedColor.b, 0.8f);
        optionsScreenButtonColors.selectedColor = new Color(optionsScreenButtonColors.selectedColor.r, optionsScreenButtonColors.selectedColor.g, optionsScreenButtonColors.selectedColor.b, 0.8f);
        optionsScreenButton.colors = optionsScreenButtonColors;
    }
}