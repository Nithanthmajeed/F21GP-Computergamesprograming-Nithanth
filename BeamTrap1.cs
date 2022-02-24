using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamTrap1 : MonoBehaviour
{
    public GameObject Beam8;
    void OnTriggerEnter()
    {
        Beam8.GetComponent<Animation>().Play("BeamAnim1");
    }
}
