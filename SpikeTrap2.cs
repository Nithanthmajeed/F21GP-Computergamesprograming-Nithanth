using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap2 : MonoBehaviour

{
    public GameObject Spike2;
    void OnTriggerEnter()
    {
        Spike2.GetComponent<Animation>().Play("SpikeAnim3");
    }
}

