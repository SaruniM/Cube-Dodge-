using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour
  {
    Public Text scoretext;
    Public float scoreAmount;
    Public float pointIncreasedPerSecond;

//Use this for initialization

    void Start()
    {
       scoreAmount = 0f;
       pointIncreasedPerSecond = 1f;
       
    }
//Update is called once per frame
    void Update() {

       scoreText.text = (int)scoreAmount + "Score";
       scoreAmount +=pointIncreasedPerSecond * Time.deltaTime;

 }
}
