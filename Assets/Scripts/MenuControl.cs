using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {
	/*private int bWidth = 3;
	private int bHeigth = 1;
	private float posx = (Screen.width / 2)-150.1f;
	private float posy = (Screen.height / 2)48f;

	public GUISkin skin;*/
	// Use this for initialization

	public class Button : Button Jugar ;

	void Start () {
	
	}
	
	// Update is called once per frame


	void Update () {
		if (Input.GetMouseButtonDown(0) Button Jugar "Button Jugar") {
			Application.LoadLevel("fase1");
		}
	}
	/*void OnGUI () {
		GUI.skin = skin;
		
		if (GUI.Button (new Rect (posx, posy, bHeigth, bWidth), "Button Jugar")) {
			Application.LoadLevel ("fase 1");
		}
	}*/

	}
