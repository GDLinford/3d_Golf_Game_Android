using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //When collided, move to 0,0,0
        other.transform.position = new Vector3(0, 0, 0);
    }
}
