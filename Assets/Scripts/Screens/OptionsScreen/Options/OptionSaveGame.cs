using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionSaveGame : MonoBehaviour
{
    public void SaveGameOnclick()
    {
        DataManagment.SaveGame();
    }
}