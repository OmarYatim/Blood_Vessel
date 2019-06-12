using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigation : MonoBehaviour {

    bool nav;
    public float Upspeed;
    public float Speed;
    public float NavRangeV;
    public float NavRangeH;
    int i;
	void Start () {
		
	}
	
	
	void Update () {
        Updown();
        Sprint();
		
	}

    void Sprint()
    {
        gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
    }







    void Updown ()
    {
        var V3 = Input.mousePosition;
        V3.z = 10.0f;
        V3 = Camera.main.ScreenToWorldPoint(V3);
        nav = Input.GetButton("Fire1");
        if (nav && (Mathf.Abs(V3.y - transform.position.y) > NavRangeV/* || Mathf.Abs(V3.x - transform.position.x) > NavRangeH)*/))
        {

            if (V3.y > gameObject.transform.position.y)
            {
                gameObject.transform.Translate(0, Upspeed * Time.deltaTime, 0);
            }
            else if (V3.y < gameObject.transform.position.y)
            {
                gameObject.transform.Translate(0, -Upspeed * Time.deltaTime, 0);
            }

            /* if (V3.x > gameObject.transform.position.x)
             {
                 gameObject.transform.Translate(Upspeed * Time.deltaTime,0, 0);
             }
             else if (V3.x < gameObject.transform.position.x)
             {
                 gameObject.transform.Translate(-Upspeed * Time.deltaTime,0, 0);
             }
             */

        }

        


            /*if (Input.GetTouch(i).phase == TouchPhase.Began && i == 0)
        {
            Vector3 v3 = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);


        }*/


        
    }



}
