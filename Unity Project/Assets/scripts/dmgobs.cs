using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgobs : MonoBehaviour {


	void OnCollisionStay2D (Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.GetComponent<score> ().health -= 150 * Time.deltaTime;
			if (transform.position.y < 0)
				coll.gameObject.transform.Translate (0, 20 * Time.deltaTime, 0);
			else
				coll.gameObject.transform.Translate (0, -20 * Time.deltaTime, 0);

		}
	}
}
