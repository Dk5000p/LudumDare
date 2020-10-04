using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetposition : MonoBehaviour
{
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
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.position = new Vector2(-5.4f,-10.2f);
            collision.attachedRigidbody.velocity = new Vector2(0, 0);
        }
    }
}
