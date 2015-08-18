using UnityEngine;
using System.Collections;

public class Fruit : MonoBehaviour {

	public GameObject fruit;

	// Use this for initialization
	void Start () {
		seed ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void seed()
	{
		int x = 0;
		int y;
		do{
			x = Random.Range (1, 31);
			y = Random.Range (-15, 15);
		}while(FindObjectOfType<Snake> ().isTouchingTheSnake(x, y));

		fruit.transform.position = new Vector3 (x, y, 0);

		Instantiate (fruit,
		             new Vector3 (x, y, 0),
		             Quaternion.identity);
	}

	public void remove()
	{
		GameObject[] currentFruit = GameObject.FindGameObjectsWithTag ("Fruit");
		Destroy(currentFruit[0]);
	}

}
