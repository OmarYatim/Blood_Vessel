using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour {

	void Update () {
        if (gameObject.transform.position.y < -8)
        {
            Die();
        }
    }
    public void Die()
    {

        SceneManager.LoadScene("game");
        return ;
    }

}
