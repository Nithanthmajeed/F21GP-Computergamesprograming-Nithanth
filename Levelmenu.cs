using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmenu : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("Level01");

    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Level02");
    }

}
