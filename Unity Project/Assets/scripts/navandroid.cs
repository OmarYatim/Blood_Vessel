using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navandroid : MonoBehaviour {


	public float Max;
	public float Speed;
	public float Min;


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
		if (Input.touchCount > 0) {
			Vector3 touchPosition = Camera.main.ScreenToWorldPoint (new Vector3 (Input.GetTouch (0).position.x, Input.GetTouch (0).position.y, 10));
			transform.position = Vector3.Lerp (transform.position, touchPosition, 6 * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.y = Mathf.Clamp (transform.position.y, Min, Max);
			transform.position = clampedPosition;
		}
	
	
	}
}
