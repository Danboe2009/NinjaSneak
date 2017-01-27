using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGen : MonoBehaviour {


	public Square[,] Board;
	public int[,] BoardPos;
	public Square square;
	public bool debug;

	private static int playerPosX;
	private static int playerPosY;
	private static int enemyPosX;
	private static int enemyPosY;
	// Use this for initialization
	void Start () {
		Board = new Square[10,10];
		if (!debug) {
			playerPosX = 9;
			playerPosY = 0;
			SetUpBoard ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		AvaliableMoves ();
	}

	private void SetUpBoard(){
		for (int x = 0; x < 10; x++) {
			for (int y = 0; y < 10; y++) {
				Square tempSquare = Instantiate<Square> (square);
				tempSquare.transform.SetParent (gameObject.transform);
				tempSquare.transform.position = new Vector3 (x, y, -0.1f);
				tempSquare.Type = "0";
				//Debug.Log ("Board X Is " + x);
				//Debug.Log ("Board Y Is " + y);
				Board [x,y] = tempSquare;
			}
		}
		Board [enemyPosX, enemyPosY].Type = "1";
		Board [playerPosX, playerPosY].Type = "2";
		//Board [5, 5].Type = "3";
	}

	private void AvaliableMoves(){
		//Debug.Log ("playerPosX " + playerPosX);
		//Debug.Log ("playerPosY " + playerPosY);
		//Debug.Log("playerPosX + 1 " + (playerPosX + 1));
		//Debug.Log("playerPosX - 1 " + (playerPosX - 1));
		if ((playerPosX + 1) < 10) {
			Board [playerPosX + 1, playerPosY].Type = "4R";
			//Debug.Log ("Type" + Board [playerPosX + 1, playerPosY].Type);
		} 
		if ((playerPosX - 1) > 0) {
			Board [playerPosX - 1, playerPosY].Type = "4L";
		}
		if ((playerPosY + 1) < 10) {
			Board [playerPosX, playerPosY + 1].Type = "4U";
		} 
		if ((playerPosY - 1) > 0) {
			Board [playerPosX, playerPosY - 1].Type = "4D";
		}
	}

	public static void MovePlayer(string dir)
	{
		switch (dir) {
		case "U":
			playerPosY++;
			break;
		case "D":
			playerPosY--;
			break;
		case "L":
			playerPosX--;
			break;
		case "R":
			playerPosX++;
			break;
		default:
			break;
		}
	} 
}
