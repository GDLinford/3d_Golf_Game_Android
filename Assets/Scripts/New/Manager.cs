using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    //this is here because its used in both
    //Hole and RollBallNew

    //Putting it as a static in either of those didnt work
    //but putting it here and having the two call it from here
    //using Manager.NumberShots works perfectly
    public static int NumberShots;
}
