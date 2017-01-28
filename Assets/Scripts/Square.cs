using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

	// Use this for initialization
	public string Type;
	public string direction;

	public Sprite Blank;
	public Sprite Red;
	public Sprite Blue;
	public Sprite Dust;
	public Sprite Green;

	public bool green;
	public SpriteRenderer cover;

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
		switch (direction) {
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
		case "0":
			GetComponent<SpriteRenderer> ().sprite = Blank;
			break;
		case "1":
			GetComponent<SpriteRenderer> ().sprite = Red;
			break;
		case "2":
			GetComponent<SpriteRenderer> ().sprite = Blue;
			break;
		case "3":
			GetComponent<SpriteRenderer> ().sprite = Dust;
			break;
		default:
			break;
		}
		if (green) {
			cover.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
		} else {
			cover.color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
		}
	}
}
