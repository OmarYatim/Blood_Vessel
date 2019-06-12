using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navandroidbeta : MonoBehaviour {

	public float Max;
	public float Speed;
	public float Min;
	bool nav;
	public float NavRangeV;
	public float NavRangeH;


	void Start()
	{

	}


	void Update()
	{
		Updown();
		Sprint();

	}

	void Sprint()
	{
		gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
	}







	void Updown()
	{
		var V3 = Input.mousePosition;
		V3.z = 10.0f;
		V3 = Camera.main.ScreenToWorldPoint(V3);
		nav = Input.GetButton("Fire1");
		if (nav && (Mathf.Abs(V3.y - transform.position.y) > NavRangeV || Mathf.Abs(V3.x - transform.position.x) > NavRangeH))
		{
			transform.position = Vector3.Lerp(transform.position, V3, 6 * Time.deltaTime);
			Vector3 clampedPosition = transform.position;
			clampedPosition.y = Mathf.Clamp(transform.position.y, Min, Max);
			transform.position = clampedPosition;
		}


	}
}
