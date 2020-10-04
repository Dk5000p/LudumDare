using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoom : MonoBehaviour
{
    public GameObject[] room;
    public int roomId;
    [SerializeField] private bool Triggered = false;
    public Transform point;
    // Start is called before the first frame update
    void Start()
    {
        roomId = Random.Range(0, room.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"&&Triggered==false)
        {
            Triggered = true;
            Instantiate(room[roomId], point);
        }
    }
}
