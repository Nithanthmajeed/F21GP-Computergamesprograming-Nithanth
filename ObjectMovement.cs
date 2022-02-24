using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public GameObject[] waypoints;
    int Current = 0;
    float rotspeed;
    public float speed;
    float WPradius = 1;

     void Update()
    {
        if (Vector3.Distance(waypoints[Current].transform.position, transform.position) < WPradius)
        {
            Current = Random.Range(0, waypoints.Length);
            if(Current >= waypoints.Length)
            {
                Current = 0;

            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[Current].transform.position, Time.deltaTime * speed);

    }
}
