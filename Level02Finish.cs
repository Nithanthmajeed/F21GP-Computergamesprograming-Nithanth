using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level02Finish : MonoBehaviour
{

   
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("Finish");
    }
}

