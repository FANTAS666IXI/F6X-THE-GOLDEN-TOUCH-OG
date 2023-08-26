using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionResetGame : MonoBehaviour
{
    private void DesactiveAutoSaveGame()
    {
        OptionAutoSaveGame.autoSaveGameState = false;
    }

    public static void ResetGame()
    {
        DataManagment.ResetGame();
        SceneManager.LoadScene(0);
    }

    public void ResetGameOnclick()
    {
        DesactiveAutoSaveGame();
        ResetGame();
    }

}