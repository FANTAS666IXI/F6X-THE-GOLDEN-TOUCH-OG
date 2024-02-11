using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievment3 : MonoBehaviour
{
    public static bool achievment3Achieved; //AUN NO SE USA
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
        if (Achievment3Requirements())
        {
            Achievment3Unlock();
        }
    }

    private void GetComponents()
    {
        background = transform.GetChild(0).GetChild(0).GetComponent<Image>();
    }

    private bool Achievment3Requirements()
    {
        if (GameControll.totalClicks >= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Achievment3Unlock()
    {
        achievment3Achieved = true;
        background.color = new Color(0.7062809f, 0.9433962f, 0.4405482f, 1);
    }

    public static void StartGame()
    {
        achievment3Achieved = false;
    }
}