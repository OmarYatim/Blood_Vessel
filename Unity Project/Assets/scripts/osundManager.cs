using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osundManager : MonoBehaviour {

	public AudioSource vv;
	public AudioSource bb;
	void Start(){
		StartCoroutine ("playAwait");
	}

	IEnumerator playAwait(){
		vv.Play ();
		yield return new WaitForSeconds (48.988f);
		bb.Play ();

	}

}
