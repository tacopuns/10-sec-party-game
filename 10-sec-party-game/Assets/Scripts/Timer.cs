using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    
    public float timeValue = 12;
    
    public TextMeshProUGUI timeText;

    public GameObject winTextObject;

    public GameObject loseTextObject;

    private PlayerBunny Player;

    public GameObject quitLeaveObject;

    public AudioSource failSound;
    

    bool timerPause = false;


    void Start()
    {
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
        quitLeaveObject.SetActive(false);


        Player = FindObjectOfType<PlayerBunny> ();

    }

    
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);


        if (timerPause)
        {
            timeValue +=Time.deltaTime;
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
            loseTextObject.SetActive(true);
            winTextObject.SetActive(false);
            quitLeaveObject.SetActive(true);

        }

        if (Player.carrotNumber == 5)
        {
            winTextObject.SetActive(true);
            loseTextObject.SetActive(false);
            quitLeaveObject.SetActive(true);
            timerPause = true;

        }

        

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("Time: {00}", seconds);
    }
}
