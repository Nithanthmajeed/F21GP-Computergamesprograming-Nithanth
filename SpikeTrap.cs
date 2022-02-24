using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : MonoBehaviour

{
    public GameObject Spike;
    void OnTriggerEnter()
    {
        Spike.GetComponent<Animation>().Play("SpikeAnim");
    }
}
