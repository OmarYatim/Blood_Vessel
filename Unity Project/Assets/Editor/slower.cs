using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slower : MonoBehaviour {

    public GameObject player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            player.GetComponent<scoreCounterAndAbilities>().y -= 20;
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().enabled = false;
            transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().enabled = false;
            //Destroy(gameObject);

        }
    }

}
