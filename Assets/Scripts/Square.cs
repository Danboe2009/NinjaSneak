using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

	// Use this for initialization
	public string Type;

	public Sprite Red;
	public Sprite Blue;
	public Sprite Dust;
	public Sprite Green;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateSquare ();
	}
		
	void OnMouseDown()
	{
		// this object was clicked - do something
		Debug.Log ("Hit " + Type);
		//Destroy (this.gameObject);
		switch (Type) {
		case "4U":
			GameGen.MovePlayer ("U");
			break;
		case "4L":
			GameGen.MovePlayer ("L");
			break;
		case "4R":
			GameGen.MovePlayer ("R");
			break;
		case "4D":
			GameGen.MovePlayer ("D");
			break;
		default:
			break;
		}
	}

	private void UpdateSquare(){
		switch(Type) {
		case "1":
			GetComponent<SpriteRenderer> ().sprite = Red;
			break;
		case "2":
			GetComponent<SpriteRenderer> ().sprite = Blue;
			break;
		case "3":
			GetComponent<SpriteRenderer> ().sprite = Dust;
			break;
		case "4U":
		case "4L":
		case "4R":
		case "4D":
			GetComponent<SpriteRenderer> ().sprite = Green;
			break;
		default:
			break;
		}
	}
}
