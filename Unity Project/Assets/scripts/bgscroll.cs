using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgscroll : MonoBehaviour {

	float speed;
	public float comp ;
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<MeshRenderer> ().material.mainTextureOffset = offset;
		if(speed < 2 )
		speed = comp + Time.deltaTime / 10;
	}
}
