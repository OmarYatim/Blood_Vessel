using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enmyAI : MonoBehaviour {


    public int atkpnt;
	Color Cred = Color.red;

    private void Start()
    {
		//Cred = new Color (255, 92, 92, 255);
        atkpnt = (int) (gameObject.transform.localScale.x * 80);
		if (atkpnt <= GameObject.FindGameObjectWithTag ("Player").GetComponent<score> ().atkpnt) {
			//Debug.Log("hello");
			GetComponent<SpriteRenderer> ().color = Cred;
		}
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (atkpnt >= collision.gameObject.GetComponent<score>().atkpnt)
            {
                playernegative(collision);
            }
            else playerpositive(collision);
        }


    }

    void playernegative(Collider2D collision)
    {
        //Debug.Log("hello");
        collision.gameObject.GetComponent<score>().health -= atkpnt ;
        Destroy(gameObject);
    }
    void playerpositive(Collider2D collision)
    {
		GameObject.FindGameObjectWithTag ("Player").GetComponent<score> ().atkpnt += 0.5f;
        collision.gameObject.GetComponent<score>().health += atkpnt;
		collision.gameObject.GetComponent<score> ().points += atkpnt;
        if (collision.gameObject.GetComponent<score>().health > 100)
            collision.gameObject.GetComponent<score>().health = 100;
        Destroy(gameObject);



        //collision.gameObject.GetComponent<score>().atkpnt += 1;


    }


}
