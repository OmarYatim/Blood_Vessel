using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyinobject : MonoBehaviour {
	GameObject player;
	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	void Update () {
		if (transform.position.x - player.transform.position.x < -40)
			Destroy (gameObject);
	}
}
