using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField]
    private GameObject TeleporterExit;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Ball")
        {
            Debug.Log("colliding");
            return;
        }
        //when you collide with the teleporter
        //go to the teleporter exit
        other.gameObject.transform.position = TeleporterExit.transform.position;
        
    }

    

}
