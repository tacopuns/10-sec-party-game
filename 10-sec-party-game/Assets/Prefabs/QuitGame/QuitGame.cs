using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape")) //If the player presses the "escape" key...
        {
            Application.Quit(); //Quits the game if running in the build
        }
    }
}
