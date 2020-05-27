using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text ScoreText;
	public static float Scorenumb = 0;
	public static bool enemy;
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale == 1f){
			Scorenumb += 1f * Time.deltaTime;;
		}

		if (enemy == true){
			Scorenumb += 50;
			enemy = false;
		}
		ScoreText.text = Scorenumb.ToString("0");
	}
}
