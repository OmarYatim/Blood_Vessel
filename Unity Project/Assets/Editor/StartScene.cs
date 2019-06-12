using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour {

	void Start () {
        Time.timeScale = 0f;
 
    }
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
        }
    }
}
