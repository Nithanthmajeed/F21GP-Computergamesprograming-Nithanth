using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamTrap : MonoBehaviour
{
    public GameObject Beam1;
    void OnTriggerEnter()
    {
        Beam1.GetComponent<Animation>().Play("BeamAnim");
    }
}
