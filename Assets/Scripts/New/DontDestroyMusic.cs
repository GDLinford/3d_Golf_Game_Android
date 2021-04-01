using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    private static DontDestroyMusic volumeControl = null;
    public static DontDestroyMusic control
    {
        get { return volumeControl; }
    }
    void Awake()
    {
        if (volumeControl != null && volumeControl != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            volumeControl = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
