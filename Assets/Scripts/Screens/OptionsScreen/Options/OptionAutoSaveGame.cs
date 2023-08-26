using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionAutoSaveGame : MonoBehaviour
{
    public static bool autoSaveGameState;
    private Button autoSaveGameButton;
    private ColorBlock autoSaveGameButtonColors;

    private void Awake()
    {
        GetComponents();
    }

    void Start()
    {
        SetUp();
    }

    private void GetComponents()
    {
        autoSaveGameButton = transform.GetChild(1).GetComponent<Button>();
        autoSaveGameButtonColors = autoSaveGameButton.GetComponent<Button>().colors;
    }

    private void SetUp()
    {
        DesactivateAutoSaveGame();
    }

    public void AutoSaveGameOnClick()
    {
        if (!autoSaveGameState)
        {
            ActivateAutoSaveGame();
        }
        else if (autoSaveGameState)
        {
            DesactivateAutoSaveGame();
        }
        autoSaveGameButton.colors = autoSaveGameButtonColors;
    }

    private void ActivateAutoSaveGame()
    {
        autoSaveGameState = true;
        autoSaveGameButtonColors.normalColor = new Color(0.2f, 0.9f, 0.2f);
        autoSaveGameButtonColors.highlightedColor = new Color(0.2f, 0.8f, 0.2f);
        autoSaveGameButtonColors.pressedColor = new Color(0.2f, 0.75f, 0.2f);
        autoSaveGameButtonColors.selectedColor = new Color(0.2f, 0.9f, 0.2f);
    }

    private void DesactivateAutoSaveGame()
    {
        autoSaveGameState = false;
        autoSaveGameButtonColors.normalColor = new Color(1, 1, 1, 1);
        autoSaveGameButtonColors.highlightedColor = new Color(0.9607843f, 0.9607843f, 0.9607843f, 1);
        autoSaveGameButtonColors.pressedColor = new Color(0.7843137f, 0.7843137f, 0.7843137f, 1);
        autoSaveGameButtonColors.selectedColor = new Color(1, 1, 1, 1);
    }
}