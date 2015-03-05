using UnityEngine;
using System.Collections;

public class PuntosPlayer : MonoBehaviour {

	public int Total_puntos = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "0"+ GameControl.gamecontrol.total_puntos ;//cambiar por imagen
	//	GameObjet.gamecontrol.total_puntos;
	}
}
