using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounterAndAbilities : MonoBehaviour {


    public float score=1;
    public GameObject ScoreUi;
    public float SpeedMumtiplier;
    public GameObject SpeedMultiplierUi;
    public float y;



    void Update () {
        //score += Time.deltaTime;
        y += Time.deltaTime;
        GetComponent<jumping>().speed = (y/20)*3+20;
        SpeedMultiplierUi.gameObject.GetComponent<Text>().text = ("Speed : " + (int)GetComponent<jumping>().speed);
       /* Debug.Log(GetComponent<jumping>().speed);
        Debug.Log(score);
        Debug.Log(y);*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreUi.gameObject.GetComponent<Text>().text = ("Score : " + (int)(score ++));
    }
}
