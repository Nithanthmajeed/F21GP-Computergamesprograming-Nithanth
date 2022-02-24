using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen1 : MonoBehaviour

{
    public GameObject Trap1;
    void OnTriggerEnter()
    {
        Trap1.GetComponent<Animation>().Play("TrapAnim1");
    }
}
