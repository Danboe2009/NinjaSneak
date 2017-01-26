using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

	// Use this for initialization
	public int Type;

	public Sprite Red;
	public Sprite Blue;
	public Sprite Dust;

	void Start () {
		if (Type == 1) {
			GetComponent<SpriteRenderer> ().sprite = Red;
		} else if (Type == 2) {
			GetComponent<SpriteRenderer> ().sprite = Blue;
		} else if (Type == 3) {
			GetComponent<SpriteRenderer> ().sprite = Dust;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
