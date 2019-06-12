using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerSyst : MonoBehaviour {

    public float Speed;
	float t;


	void Update () {
        gameObject.transform.Translate(Speed * Time.deltaTime, 0, 0);
		if(t < 70)
		t += Time.deltaTime;
		Speed = 3+ t/5;

    }
}
