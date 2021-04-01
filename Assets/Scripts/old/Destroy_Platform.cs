using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Code for tutorial can be deleted as i have controls working


public class Destroy_Platform : MonoBehaviour
{
    public GameObject Platform;


    private void OnCollisionExit(Collision collision)
    {
        Destroy(Platform);
    }


}
