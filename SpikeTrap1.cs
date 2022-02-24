using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap1 : MonoBehaviour

{
    public GameObject Spike1;
    void OnTriggerEnter()
    {
        Spike1.GetComponent<Animation>().Play("SpikeAnim1");
    }
}
