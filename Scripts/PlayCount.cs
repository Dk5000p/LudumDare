using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCount : MonoBehaviour
{
    PlayerPrefs timesPlayed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseTimesPlayed()
    {
        PlayerPrefs.SetInt("timesPlayed", (PlayerPrefs.GetInt("timesPlayed",0) + 1));
    }
}
