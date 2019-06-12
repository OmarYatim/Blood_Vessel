using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformscroller : MonoBehaviour {
	public float scrollSpeed=5;




	void Update () {
		transform.Translate (-scrollSpeed* Time.deltaTime, 0, 0);
		if (transform.position.x < -20.33f)
			transform.position = new Vector2 (17.58f, transform.position.y);
	}
}
