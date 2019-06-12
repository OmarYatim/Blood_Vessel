using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {


    public bool isDead = true;
    public GameObject deathMenuUi;

	void Update () {
        if (isDead)
        {
            deathMenuUi.SetActive(true);
            Time.timeScale = 0f;
            isDead = false;
        }
		
	}

    public void Restart()
    {
        SceneManager.LoadScene("game");
        Time.timeScale = 1f;
    }

}
