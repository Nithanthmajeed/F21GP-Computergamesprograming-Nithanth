using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("Level02");

    }
    public void Menu ()
    {
        SceneManager.LoadScene("Menu");
    }

}
