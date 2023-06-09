using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collission.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }

}
