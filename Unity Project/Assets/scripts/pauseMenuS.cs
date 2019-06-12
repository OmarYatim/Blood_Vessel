using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class pauseMenuS : MonoBehaviour {


	public GameObject pausemenu;
	public AudioMixer audiomixer;

	public void Pause (){
		Time.timeScale = 0f;
		pausemenu.SetActive (true);
	}


	public void Resume(){
		Time.timeScale = 1f;
		pausemenu.SetActive (false);

	}

	public void quit(){

		Application.Quit ();
	}

	public void Menu (){
		SceneManager.LoadScene ("ggj");
		Time.timeScale = 1f; 

	}
	public void setVolume(float volume){

		audiomixer.SetFloat ("volume", volume);


	}



	public void Restart(){
		
		SceneManager.LoadScene ("game");

	}
}
