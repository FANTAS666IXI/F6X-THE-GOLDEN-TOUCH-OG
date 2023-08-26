using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievment1 : MonoBehaviour
{
    public static bool achievment1Achieved; //AUN NO SE USA
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
        if (Achievment1Requirements())
        {
            Achievment1Unlock();
        }
    }

    private void GetComponents()
    {
        background = transform.GetChild(0).GetChild(0).GetComponent<Image>();
    }

    private bool Achievment1Requirements()
    {
        if (GameControll.maxGold >= 500)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Achievment1Unlock()
    {
        achievment1Achieved = true;
        background.color = new Color(0.7062809f, 0.9433962f, 0.4405482f, 1);
    }

    public static void StartGame()
    {
        achievment1Achieved = false;
    }
}