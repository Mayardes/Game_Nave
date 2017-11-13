using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    public Text score, highScore;
	void Update () {

        score.text = "" + PlayerPrefs.GetInt("score");
        highScore.text = "" + PlayerPrefs.GetInt("highscore");
	}
}
