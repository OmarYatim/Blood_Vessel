using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {

    public float health;
    public Slider healthUI;
    public GameObject healthTextUI;
	public float atkpnt;
    public GameObject atkpntUI;
	public GameObject pointsUI;
	public float points;
	public int SMultiplier = 0;
	float t;

	public GameObject Restart;
	public GameObject GameOver;


    void Update()
    {
		transform.localScale = new Vector3 (atkpnt/100, atkpnt/100, 1);
		points += Time.deltaTime;
		if(t < 70)
		t += Time.deltaTime;
		GetComponent<navigation> ().Speed = 3 + t / 5;
        health -= 2*Time.deltaTime;
		if (health <= 0) {
			
			Restart.SetActive (true);
			GameOver.SetActive (true);
			GetComponent<SpriteRenderer> ().enabled = false;
			healthTextUI.SetActive (false);


		}
		if (atkpnt >= 30) {
			atkpnt = 19;
			SMultiplier += 2;
		}

        float healthy = Mathf.Clamp01(health / 100);
        healthUI.value = healthy;
        healthTextUI.GetComponent<Text>().text = ("health :" + (int)health);
		atkpntUI.GetComponent<Text>().text = ("" + (int)atkpnt);
		if(SMultiplier<= 0)
		pointsUI.GetComponent<Text> ().text = ("" + (int)points);
		else pointsUI.GetComponent<Text> ().text = ("" + (int)points + " X " + (int)SMultiplier);



    }
}
