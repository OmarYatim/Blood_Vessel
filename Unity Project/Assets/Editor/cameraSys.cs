using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSys : MonoBehaviour {

	public float area = 2;
	public GameObject play;
	public float yMin;
	public float yMax;

	void Update () {
		
		float y = Mathf.Clamp (play.transform.position.y, yMin, yMax);
		gameObject.transform.position = new Vector3 (play.transform.position.x + 12, y, gameObject.transform.position.z);
		
	}
}
