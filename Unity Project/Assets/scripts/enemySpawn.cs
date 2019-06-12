using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {

    int rand;
    int randS;
	int randO;
    public GameObject enemy;
	public GameObject obs;
    public GameObject player;



	void Start () 
	{
		
        InvokeRepeating("spawn",0,0.2f);
	}

    
    void spawn()
    {
       
        rand = Random.Range(1,5);
        randS = Random.Range(80,200);
        //Debug.Log(rand);

        if (rand == 4)
        {
            GameObject newobj =  Instantiate(enemy, transform.position+ new Vector3(0,Random.Range(-1.5f,2.5f),0), Quaternion.identity) as GameObject ;
            newobj.transform.localScale = new Vector2(randS * newobj.transform.localScale.x / 100, randS * newobj.transform.localScale.y / 100);
			newobj.GetComponent<Animator> ().SetInteger ("rand", Random.Range (0, 4));
			//Debug.Log (newobj.GetComponent<Animator> ().GetInteger("rand"));
        }
		if (randS < 140 && randS > 132) {
			randO = Random.Range (-30, 30);
			if (!(randO < 19 && randO > -11)) {
				GameObject newobj = Instantiate (obs, transform.position + new Vector3 (0, randO / 10, 0), Quaternion.identity) as GameObject;
				if (randO > 0) {
					newobj.GetComponent<SpriteRenderer> ().flipY = true;
				}
			}
		}




    }
	
}
