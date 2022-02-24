using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    public void RestartButton ()
    {
        SceneManager.LoadScene("Level01");

    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }

    
}
