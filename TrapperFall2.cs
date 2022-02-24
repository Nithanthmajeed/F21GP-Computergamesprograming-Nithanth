using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapperFall2 : MonoBehaviour
{
    public GameObject Trapper3;
    void OnTriggerEnter()
    {
        Trapper3.GetComponent<Animation>().Play("TrapperAnim2");
    }
}
