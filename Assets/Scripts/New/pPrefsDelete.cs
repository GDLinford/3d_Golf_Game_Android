using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pPrefsDelete : Hole
{
    void OnGUI()
    {
        //press a Button to delete the playerPrefs score
        //is not deleted between Scenes, but when the player quits the game
        if (GUI.Button(new Rect(100, 200, 200, 60), "Delete Score"))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
