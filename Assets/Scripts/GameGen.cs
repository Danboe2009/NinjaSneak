using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGen : MonoBehaviour {


	public Square[,] Board;
	public static string[,] DustCloud;
	public Square square;
	public bool debug;

	private static int playerPosX;
	private static int playerPosY;
	private static int enemyPosX;
	private static int enemyPosY;
	// Use this for initialization
	void Start () {
		Board = new Square[10,10];
		DustCloud = new string[10, 10];
		if (!debug) {
			enemyPosX = 0;
			enemyPosY = 9;
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
		for (int x = 0; x < 10; x++) {
			for (int y = 0; y < 10; y++) {
				DustCloud [x, y] = "0";
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
		ResetBoard();
		for (int x = 0; x < 10; x++) {
			for (int y = 0; y < 10; y++) {
				Board [x, y].Type = DustCloud[x,y];
			}
		}
		if ((playerPosX + 1) < 10) {
			Board [playerPosX + 1, playerPosY].direction = "4R";
			Board [playerPosX + 1, playerPosY].green = true;
			//Debug.Log ("Type" + Board [playerPosX + 1, playerPosY].Type);
		} 
		if ((playerPosX - 1) > -1) {
			Board [playerPosX - 1, playerPosY].direction = "4L";
			Board [playerPosX - 1, playerPosY].green = true;
		}
		if ((playerPosY + 1) < 10) {
			Board [playerPosX, playerPosY + 1].direction = "4U";
			Board [playerPosX, playerPosY + 1].green = true;
		} 
		if ((playerPosY - 1) > -1) {
			Board [playerPosX, playerPosY - 1].direction = "4D";
			Board [playerPosX, playerPosY - 1].green = true;
		}
		Board [enemyPosX, enemyPosY].Type = "1";
		Board [playerPosX, playerPosY].Type = "2";

	}

	public static void MovePlayer(string dir)
	{
		DustCloud [playerPosX, playerPosY] = "3";

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

	private void ResetBoard(){
		for (int x = 0; x < 10; x++) {
			for (int y = 0; y < 10; y++) {
				Board [x, y].Type = "0";
				Board [x, y].direction = "";
				Board [x, y].green = false;
			}
		}
	}
}
