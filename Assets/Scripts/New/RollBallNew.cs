using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollBallNew : MonoBehaviour
{
    [SerializeField] AudioClip golfBall;
    private AudioSource gSource;
    [SerializeField] AudioClip ButtonPress;
    

    //force on the ball
    [SerializeField]
    private float ballForce;

    //displays current force
    [SerializeField]
    private int Counter50;

    //The aimer pointer thing
    public Transform Aim;

    //The text objects that will be changed via button presses/clicks
    public Text CounterScore;
    public Text numOfShots;
    

    void Start()
    {
        gSource = GetComponent<AudioSource>();   
    }

    //Adds force to the ball when firing
    public void Add50Force()
    {
        ballForce += 50;
        Counter50 += 50;
        gSource.PlayOneShot(ButtonPress);
        CounterScore.text = Counter50.ToString();
    }
    //Reset force
    public void ResetForce()
    {
        ballForce = 0;
        Counter50 = 0;
        gSource.PlayOneShot(ButtonPress);
        CounterScore.text = "0".ToString();
    }
    //take away force 
    public void Minus50Force()
    {
        ballForce -= 50;
        Counter50 -= 50;
        gSource.PlayOneShot(ButtonPress);
        CounterScore.text = Counter50.ToString();
    }

    //Rotate the ball left, right and up
    public void RotateL()
    {
        transform.Rotate(0, -5, 0);
        gSource.PlayOneShot(ButtonPress);
    }
    public void RotateR()
    {
        transform.Rotate(0, 5, 0);
        gSource.PlayOneShot(ButtonPress);
    }
    public void RotationUp()
    {
        transform.Rotate(-5, 0, 0);
        gSource.PlayOneShot(ButtonPress);
    }

    //Reset the rotation
    public void ResetRotation()
    {
        gSource.PlayOneShot(ButtonPress);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        transform.localEulerAngles = new Vector3(0, 0, 0);
    }

    //When the ball is clicked
    //use the force to launch the ball
    //add to click counter
    //remove the force counter text
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, ballForce);
        Manager.NumberShots++;
        //resets force to 0
        ballForce = 0;
        Counter50 = 0;
        CounterScore.text = Counter50.ToString();
        gSource.PlayOneShot(golfBall);
        numOfShots.text = Manager.NumberShots.ToString();
    }
}
