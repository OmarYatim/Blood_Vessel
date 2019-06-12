using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

    public AudioSource gameover;
    bool repeat = true;
    public GameObject Menu ;
    public GameObject Resume;

	void Update () {
        if (gameObject.transform.position.y < -13 && repeat)
        {
            StartCoroutine("Die");
            repeat = false;
        }
    }
    IEnumerator Die()
    {
        gameover.Play();

        Menu.GetComponent<DeathMenu>().enabled = true;
        Menu.GetComponent<pauseMenu>().enabled = false;
        yield return null;


        
       // SceneManager.LoadScene("game");
    }
}
