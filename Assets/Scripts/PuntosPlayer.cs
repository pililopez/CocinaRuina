using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuntosPlayer : MonoBehaviour {

	Text texto;
	// Use this for initialization
	void Start () {
		texto = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		texto.text = GameControl.gamecontrol.total_puntos.ToString ();
		//guiText.text = ""+ total_vida;//cambiar por imagen
		
	
		
	}
}
