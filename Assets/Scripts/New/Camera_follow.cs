using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Vector3 BallPos;
    public Transform BallRoll;
    //Specify a distance in the inspector and the camera will follow the ball at that distance
    public void Update()
    {
        transform.position = BallRoll.position + BallPos;
    }
}
