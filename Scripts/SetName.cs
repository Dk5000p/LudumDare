using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    public Flowchart flowchart;
    public InputField nameInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nameInput.text);
    }
    public void SetPlayerName()
    {
        flowchart.SetStringVariable("Name", nameInput.text.ToString());
    }
}
