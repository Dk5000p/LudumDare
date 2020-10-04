using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Talk : MonoBehaviour
{
    public Flowchart flowchart;
    public string target;
    public bool triggered = false;
    public Rigidbody2D rb;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player"&&triggered==false)
        {
            triggered = true;
            rb.velocity = new Vector2(0, 0);
            flowchart.ExecuteBlock(target);
        }
    }
}
