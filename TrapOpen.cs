using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen : MonoBehaviour

{
    public GameObject Trap;
     void OnTriggerEnter()
    {
        Trap.GetComponent<Animation>().Play("TrapAnim");
    }
}
 