using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumping : MonoBehaviour {

    GameObject[] t =new GameObject[3]  ;
    public GameObject o1,o2,o3        ;   
	public float speed;
	public float jumpforce;
    float distanceWax;
    public float distanceToBotOfplayer;
    public int abilityToJump = 2;
    public float distanceToRightOfplayer;
    private void Start()
    {
        t[0] = o1;
        t[1] = o2;
        t[2] = o3;
        distanceWax = distanceToBotOfplayer + o1.GetComponent<SpriteRenderer>().bounds.size.y/2     ;
        InvokeRepeating("Spawn",0,( o1.GetComponent<SpriteRenderer>().bounds.size.x / speed)-0.01f);
    }

    void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        //Debug.Log(hit.distance);
        if (hit.distance < distanceToBotOfplayer && hit.collider != null)
            abilityToJump = 2;
        if (Input.GetButtonDown("Fire1") && ((hit.distance < distanceToBotOfplayer && hit.collider != null) || abilityToJump > 0))
        {

            if(abilityToJump == 2)
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce*3/4);
            else GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce);
            abilityToJump--;
        }
 
		transform.Translate (speed* Time.deltaTime,0,0);
        //GetComponent<Rigidbody2D>().velocity = new Vector2 (speed*Time.deltaTime,GetComponent<Rigidbody2D>().velocity.y);

        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right);
        if (hitRight.distance < distanceToRightOfplayer && hitRight.collider != null && hitRight.collider.gameObject.tag == ("Ground"))
        {
            GameObject.FindGameObjectWithTag("background").GetComponent<bgscroll>().enabled = false;
            speed = 0;
        }
        else
        {
            GameObject.FindGameObjectWithTag("background").GetComponent<bgscroll>().enabled = true;
            speed = 20;
        }

    }
    void Spawn()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        if (hit.distance-distanceToBotOfplayer <0 && hit.distance - distanceToBotOfplayer > -0.1f && hit.collider!= null)
        Instantiate(t[Random.Range(0,3)],transform.position-new Vector3(0,distanceWax,0),transform.rotation);

    }

}
