using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGen : MonoBehaviour {


	public Square[,] Board;
	public Square square;

	private int playerPosX;
	private int playerPosY;
	// Use this for initialization
	void Start () {
		Board = new Square[10,10];
		SetUpBoard ();
	}
	
	// Update is called once per frame
	void Update () {
		AvaliableMoves ();
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
		//Board [5, 5].Type = 3;

		playerPosX = 9;
		playerPosY = 0;
	}

	private void AvaliableMoves(){
		Debug.Log ("playerPosX " + playerPosX);
		Debug.Log ("playerPosY " + playerPosY);
		//Debug.Log("playerPosX + 1 " + (playerPosX + 1));
		//Debug.Log("playerPosX - 1 " + (playerPosX - 1));
		if ((playerPosX + 1) < 10) {
			Board [playerPosX + 1, playerPosY].Type = 4;
			//Debug.Log ("Type" + Board [playerPosX + 1, playerPosY].Type);
		} 
		if ((playerPosX - 1) > 0) {
			Board [playerPosX - 1, playerPosY].Type = 4;
		}
		if ((playerPosY + 1) < 10) {
			Board [playerPosX, playerPosY + 1].Type = 4;
		} 
		if ((playerPosY - 1) > 0) {
			Board [playerPosX, playerPosY - 1].Type = 4;
		}
	}
}
