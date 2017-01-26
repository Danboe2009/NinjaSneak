using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

	// Use this for initialization
	public int Type;

	public Sprite Red;
	public Sprite Blue;
	public Sprite Dust;
	public Sprite Green;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(Type) {
		case 1:
			GetComponent<SpriteRenderer> ().sprite = Red;
			break;
		case 2:
			GetComponent<SpriteRenderer> ().sprite = Blue;
			break;
		case 3:
			GetComponent<SpriteRenderer> ().sprite = Dust;
			break;
		case 4:
			GetComponent<SpriteRenderer> ().sprite = Green;
			break;
		default:
			break;
		}
	}
}
