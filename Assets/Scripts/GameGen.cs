using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGen : MonoBehaviour {


	public Square[,] Board;
	public Square square;
	// Use this for initialization
	void Start () {
		Board = new Square[10,10];
		SetUpBoard ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SetUpBoard(){
		for (int x = 0; x < 10; x++) {
			for (int y = 0; y < 10; y++) {
				Square tempSquare = Instantiate<Square> (square);
				tempSquare.transform.SetParent (this.transform);
				tempSquare.transform.position = new Vector3 (x, y, -0.1f);
				tempSquare.Type = 0;
				//Debug.Log ("Board X Is " + x);
				//Debug.Log ("Board Y Is " + y);
				Board [x,y] = tempSquare;
			}
		}
		Board [0, 9].Type = 1;
		Board [9, 0].Type = 2;
		Board [5, 5].Type = 3;
	}
}
