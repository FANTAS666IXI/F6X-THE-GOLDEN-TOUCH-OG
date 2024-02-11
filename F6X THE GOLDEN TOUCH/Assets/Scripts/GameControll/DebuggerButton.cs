using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggerButton : MonoBehaviour
{
    public void Debugg()
    {
        Debug.Log(PlayerPrefs.GetFloat("maxGold"));
        Debug.Log("Debuging");
    }
}