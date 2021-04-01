using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Hole : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Time.timeScale = 0;
        }
    }

}
