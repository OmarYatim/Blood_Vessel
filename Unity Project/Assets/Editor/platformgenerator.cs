using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformgenerator : MonoBehaviour {

	public Transform pointer;
	public GameObject o1;
	public GameObject slowingObj;
    public GameObject speedingObj;
	float platformWidth;
	int distanceBetween;
	//public float bgWidth;
	//Vector2 bg=new Vector2 (11.8f,0.4f);
	//int bgs =2 ;

	void Start(){
		platformWidth = o1.GetComponent<BoxCollider2D> ().size.x;
		//bgWidth = background.GetComponent<SpriteRenderer> ().bounds.size.x;
	}
	void Update () {
		
		if (transform.position.x < pointer.position.x) {
			int randS = Random.Range(50,120);
			distanceBetween = Random.Range (4,6);
			transform.position = new Vector2 (transform.position.x + randS*platformWidth/100 + distanceBetween,Random.Range(-9,0));
			GameObject newobject =  Instantiate (o1,transform.position,transform.rotation) as GameObject;
            int random = Random.Range(0, 30);
            if (random == 7)
                Instantiate(slowingObj, transform.position + new Vector3(Random.Range(-29, -9), Random.Range(5, 11), 0), Quaternion.identity);
            else if (random == 13)
                Instantiate(speedingObj, transform.position + new Vector3(Random.Range(-29, -9), Random.Range(5, 11), 0), Quaternion.identity);


            newobject.transform.localScale = new Vector2(randS*newobject.transform.localScale.x/100,randS*newobject.transform.localScale.y/100);
		}
			
	}

}
