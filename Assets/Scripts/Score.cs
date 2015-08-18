using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text ScoreText;
	public int score;

	// Use this for initialization
	void Start () {
		score = 3;
		ScoreText.text = "Length: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
