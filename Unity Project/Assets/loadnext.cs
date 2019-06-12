using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadnext : MonoBehaviour {


	void Start () {
		StartCoroutine ("loadnextS");
	}

	IEnumerator loadnextS(){

		yield return new WaitForSeconds (8);
		SceneManager.LoadScene ("ggj");

	}

}
