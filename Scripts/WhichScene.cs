using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhichScene : MonoBehaviour
{
    public int numberTimes;
    // Start is called before the first frame update
    void Start()
    {
        numberTimes=PlayerPrefs.GetInt("timesPlayed", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DecideScene()
    {
        if (numberTimes == 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
