using UnityEngine;
using System.Collections;

public class PuntosPlayer : MonoBehaviour {

	public int total_puntos = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "0"+ total_puntos;//cambiar por imagen
		if (total_puntos > 50) {
			total_puntos = 0 && total_vida = (total_vida + 1);
		}
		if (total_puntos < 50) {
			total_puntos = +50 && total_vida = total_vida - 1;
	}
}
}
