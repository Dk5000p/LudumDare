using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BacktoTheBeginning : MonoBehaviour
{
    public Flowchart flowchart;
    public int resetCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"&&resetCount==0)
        {
            flowchart.ExecuteBlock("Again");
            collision.transform.position = new Vector2(-5.4f, -10.2f);
            collision.attachedRigidbody.velocity = new Vector2(0, 0);
            resetCount+= 1;
        }else if(collision.gameObject.tag == "Player" && resetCount>0)
            {
                flowchart.ExecuteBlock("Why");
                collision.transform.position = new Vector2(-5.4f, -10.2f);
                collision.attachedRigidbody.velocity = new Vector2(0, 0);
                resetCount = 1;
            }
    }
}
