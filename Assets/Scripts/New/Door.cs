using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private GameObject TheDoor;
    [SerializeField]
    private GameObject Lever;

    //When gameobject tagged ball collides
    //Destroy door and Lever
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(Lever);
            Destroy(TheDoor);
        }
        
    }

}
