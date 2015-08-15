using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text ScoreText;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		ScoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
