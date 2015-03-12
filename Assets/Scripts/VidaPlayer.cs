using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VidaPlayer : MonoBehaviour {


	Text texto;
	// Use this for initialization
	void Start () {
		texto = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		texto.text = GameControl.gamecontrol.total_vida.ToString();
		//guiText.text = ""+ total_vida;//cambiar por imagen

		if (GameControl.gamecontrol.total_vida <= 0) {
			Application.LoadLevel ("menu");
		}
		
	}
	
}

