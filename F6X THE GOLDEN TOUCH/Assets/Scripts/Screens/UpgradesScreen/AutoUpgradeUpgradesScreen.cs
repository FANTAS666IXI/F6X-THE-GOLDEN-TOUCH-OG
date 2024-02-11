using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoUpgradeUpgradesScreen : MonoBehaviour
{
    public static bool autoUpgradeState;
    private Button autoUpgradeButton;
    private ColorBlock autoUpgradeButtonColors;

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
        autoUpgradeButton = transform.GetChild(1).GetComponent<Button>();
        autoUpgradeButtonColors = autoUpgradeButton.GetComponent<Button>().colors;
    }

    private void SetUp()
    {
        DesactivateAutoUpgrade();
    }

    public void AutoUpgradeOnClick()
    {
        if (!autoUpgradeState)
        {
            ActivateAutoUpgrade();
        }
        else if (autoUpgradeState)
        {
            DesactivateAutoUpgrade();
        }
        autoUpgradeButton.colors = autoUpgradeButtonColors;
    }

    private void ActivateAutoUpgrade()
    {
        autoUpgradeState = true;
        autoUpgradeButtonColors.normalColor = new Color(0.2f, 0.9f, 0.2f);
        autoUpgradeButtonColors.highlightedColor = new Color(0.2f, 0.8f, 0.2f);
        autoUpgradeButtonColors.pressedColor = new Color(0.2f, 0.75f, 0.2f);
        autoUpgradeButtonColors.selectedColor = new Color(0.2f, 0.9f, 0.2f);
    }

    private void DesactivateAutoUpgrade()
    {
        autoUpgradeState = false;
        autoUpgradeButtonColors.normalColor = new Color(1, 1, 1, 1);
        autoUpgradeButtonColors.highlightedColor = new Color(0.9607843f, 0.9607843f, 0.9607843f, 1f);
        autoUpgradeButtonColors.pressedColor = new Color(0.7843137f, 0.7843137f, 0.7843137f, 1f);
        autoUpgradeButtonColors.selectedColor = new Color(1, 1, 1, 1f);
    }
}