using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievment2 : MonoBehaviour
{
    public static bool achievment2Achieved; //AUN NO SE USA
    private Image background;

    private void Awake()
    {
        GetComponents();
    }

    private void Start()
    {
        background.color = new Color(1, 1, 1, 0.8f);
    }

    private void Update()
    {
        if (Achievment2Requirements())
        {
            Achievment2Unlock();
        }
    }

    private void GetComponents()
    {
        background = transform.GetChild(0).GetChild(0).GetComponent<Image>();
    }

    private bool Achievment2Requirements()
    {
        if (Tier1.level >= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Achievment2Unlock()
    {
        achievment2Achieved = true;
        background.color = new Color(0.7062809f, 0.9433962f, 0.4405482f, 1);
    }

    public static void StartGame()
    {
        achievment2Achieved = false;
    }
}