using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapperFall : MonoBehaviour
{
    public GameObject Trapper1;
    void OnTriggerEnter()
    {
        Trapper1.GetComponent<Animation>().Play("TrapperAnim");
    }
}
