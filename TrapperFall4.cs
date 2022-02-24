using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapperFall4 : MonoBehaviour
{
    public GameObject cube;
    void OnTriggerEnter()
    {
        cube.GetComponent<Animation>().Play("Cubeanim1");

    }
}
